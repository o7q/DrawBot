using System;
using System.IO;
using System.Net;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DrawBot
{
    public partial class program : Form
    {
        // grab dlls for mouse controls
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // mouse inputs
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        // abort drawing script
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        // 0x1B = esc
        // 0x01 = leftmouse

        private bool detectInput(int key)
        {
            short keyState = GetAsyncKeyState(key);
            bool keyPressed = ((keyState >> 15) & 0x0001) == 0x0001;

            if (keyPressed)
                return true;

            return false;
        }

        // 0x01 stands for left Mouse click
        // for different Virtual-Keys view list:
        // https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

        const string version = "v1.0.0";

        int x_region_start = 0;
        int y_region_start = 0;
        int x_region_end = 0;
        int y_region_end = 0;

        int x_bound = 0;
        int y_bound = 0;

        string colorsTemp = "";
        int colorsIndex = 0;

        public int[,] colorPalette { get; set; }
        int paletteAmount;

        bool presetLoaded = false;

        string imagePath = "";
        Image image;

        public program()
        {
            InitializeComponent();

            infoLabel.Text = "DrawBot " + version + " by o7q";
            imageLabel.Text = "";
        }

        private void program_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("DrawBot\\presets");
            refreshColorsList();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (x_region_start * x_region_end == 0)
            {
                MessageBox.Show("Please configure your canvas bounds");
                return;
            }

            if (presetLoaded == false)
            {
                MessageBox.Show("Please select a color preset");
                return;
            }

            Thread.Sleep(500);

            TopMost = true;

            int quality_step = 500 / (Int32.Parse(qualityBox.Text) + 1);
            double speed = 0.1 / double.Parse(speedBox.Text);

            x_bound = (x_region_end - x_region_start) / quality_step;
            y_bound = (y_region_end - y_region_start) / quality_step;

            if (loadURLImageBox.Text == "")
                image = new Bitmap(Image.FromFile(imagePath), new Size(x_bound, y_bound));
            else
            {
                var request = WebRequest.Create(loadURLImageBox.Text);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                    image = new Bitmap(Bitmap.FromStream(stream), new Size(x_bound, y_bound));
            }

            int area = x_bound * y_bound;
            int x_track = 0;
            int y_track = 0;

            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x_region_start, y_region_start);

            for (int i = 0; i < area; i++)
            {
                if (detectInput(0x1B) == true)
                {
                    TopMost = false;
                    return;
                }

                if (x_track == x_bound)
                {
                    Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X - x_bound * quality_step, Cursor.Position.Y + quality_step);

                    x_track = 0;
                    y_track++;
                }

                int r, g, b;
                using (Bitmap bmp = new Bitmap(image))
                {
                    Color clr = bmp.GetPixel(x_track, y_track);
                    r = clr.R;
                    g = clr.G;
                    b = clr.B;
                }

                int dist = 0;
                int[,] colors = new int[paletteAmount, 6];
                for (int j = 0; j < paletteAmount; j++)
                {
                    dist = (int)Math.Sqrt(Math.Pow(r - colorPalette[j, 2], 2) + Math.Pow(g - colorPalette[j, 3], 2) + Math.Pow(b - colorPalette[j, 4], 2));

                    colors[j, 0] = dist;
                    for (int k = 0; k < 5; k++)
                        colors[j, k + 1] = colorPalette[j, k];
                }

                int[,] colorsSorted = colors.OrderBy(x => x[0]);

                int x_track_temp = Cursor.Position.X;
                int y_track_temp = Cursor.Position.Y;

                Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(colorsSorted[0, 1], colorsSorted[0, 2]);

                clickCursor(speed);

                Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(x_track_temp + quality_step, y_track_temp);


                clickCursor(speed);

                x_track++;
            }

            image.Dispose();
            TopMost = false;
        }
        private void clickCursor(double wait)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedTicks < Math.Round(wait * Stopwatch.Frequency)) { }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            openImageDialog.Filter = "PNG|*.png|JPG|*.jpg|All files (*.*)|*.*";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImageDialog.FileName;
                imageLabel.Text = Path.GetFileName(imagePath);
            }
        }

        private void loadURLImageBox_TextChanged(object sender, EventArgs e)
        {
            imageLabel.Text = loadURLImageBox.Text;
            if (loadURLImageBox.Text == "") imageLabel.Text = Path.GetFileName(imagePath);
        }

        private void imageLabel_TextChanged(object sender, EventArgs e)
        {
            if (imageLabel.Text.Length > 10)
                imageLabel.Text = imageLabel.Text.Substring(imageLabel.Text.Length - 10);
        }

        private void regionStartButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (detectInput(0x01) == false) { }

            x_region_start = Cursor.Position.X;
            y_region_start = Cursor.Position.Y;
            pos1Label.Text = (x_region_start, y_region_start).ToString();
            boundsLabel.Text = "(" + (x_region_end - x_region_start).ToString() + ", " + (y_region_end - y_region_start).ToString() + ")";
        }

        private void regionEndButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (detectInput(0x01) == false) { }

            x_region_end = Cursor.Position.X;
            y_region_end = Cursor.Position.Y;
            pos2Label.Text = (x_region_end, y_region_end).ToString();
            boundsLabel.Text = "(" + (x_region_end - x_region_start).ToString() + ", " + (y_region_end - y_region_start).ToString() + ")";
        }

        private void registerColorButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (detectInput(0x01) == false) { }

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            var rgb = GetColorAt(x, y);
            colorsTemp += x + "," + y + "," + rgb.Item1 + "," + rgb.Item2 + "," + rgb.Item3 + "|";
            colorsIndex++;

            colorIndexLabel.Text = "Color " + colorsIndex.ToString();
            colorLabel.Text = rgb.ToString();
            colorSquare.BackColor = Color.FromArgb(255, rgb.Item1, rgb.Item2, rgb.Item3);
        }

        private void resetColorsButton_Click(object sender, EventArgs e)
        {
            colorsTemp = "";
            colorsIndex = 0;
            colorIndexLabel.Text = "Color 0";
            colorLabel.Text = "(0, 0, 0)";
            colorSquare.BackColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void finalizeColorsButton_Click(object sender, EventArgs e)
        {
            if (colorsTemp == "") return;
            colorsTemp = colorsTemp.Remove(colorsTemp.Length - 1, 1);
            string name = finalizeColorsBox.Text == "" ? "preset" + DateTime.Now.ToString("[Mdy-hms]") : finalizeColorsBox.Text;
            File.WriteAllText("DrawBot\\presets\\" + name + ".palette", colorsTemp);
            refreshColorsList();

            finalizeColorsBox.Text = "";
            colorsTemp = "";
            colorsIndex = 0;
            colorIndexLabel.Text = "Color 0";
            colorLabel.Text = "(0, 0, 0)";
            colorSquare.BackColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void loadColorsButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("DrawBot\\presets", "*.*", SearchOption.TopDirectoryOnly).Length == 0) return;

            string paletteFile = File.ReadAllText("DrawBot\\presets\\" + colorsList.SelectedItem + ".palette");
            string[] RGBpixel = paletteFile.Split('|');
            paletteAmount = RGBpixel.Length;
            colorPalette = new int[paletteFile.Length, 5];
            for (int i = 0; i < RGBpixel.Length; i++)
            {
                string[] value = RGBpixel[i].Split(',');
                for (int j = 0; j < 5; j++)
                    colorPalette[i, j] = Int32.Parse(value[j]);
            }

            presetLoaded = true;
        }

        private void deleteColorsButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("DrawBot\\presets", "*.*", SearchOption.TopDirectoryOnly).Length == 0) return;
            File.Delete("DrawBot\\presets\\" + colorsList.SelectedItem + ".palette");
            refreshColorsList();
            if (colorsList.Items.Count > 0) colorsList.SelectedIndex = 0;

            presetLoaded = false;
        }

        private void qualityBox_TextChanged(object sender, EventArgs e)
        {
            int quality;
            try { quality = Int32.Parse(qualityBox.Text); } catch { quality = 50; }
            if (quality > 100) quality = 100;
            if (quality < 1) quality = 1;
            qualityBox.Text = quality.ToString();
            qualityBar.Value = quality;
        }
        private void qualityBar_Scroll(object sender, EventArgs e)
        {
            qualityBox.Text = qualityBar.Value.ToString();
        }

        private void speedBox_TextChanged(object sender, EventArgs e)
        {
            int speed;
            try { speed = Int32.Parse(speedBox.Text); } catch { speed = 50; }
            if (speed > 100) speed = 100;
            if (speed < 1) speed = 1;
            speedBox.Text = speed.ToString();
            speedBar.Value = speed;
        }
        private void speedBar_Scroll(object sender, EventArgs e)
        {
            speedBox.Text = speedBar.Value.ToString();
        }

        Tuple<int, int, int> GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            Color col = bmp.GetPixel(0, 0);
            return Tuple.Create(Convert.ToInt32(col.R), Convert.ToInt32(col.G), Convert.ToInt32(col.B));
        }

        private void refreshColorsList()
        {
            colorsList.Items.Clear();
            string[] paletteFiles = Directory.GetFiles("DrawBot\\presets", "*.palette");
            for (int i = 0; i < paletteFiles.Length; i++)
            {
                colorsList.Items.Add(Path.GetFileNameWithoutExtension(paletteFiles[i]));
            }
        }

        private void program_MouseEnter(object sender, EventArgs e)
        {
            TopMost = false;
        }
    }

    // CODE FORKED FROM:
    // https://www.codeproject.com/Tips/166236/Sorting-a-Two-Dimensional-Array-in-Csharp
    public static class MultiDimensionalArrayExtensions
    {
        /// <summary>
        ///   Orders the two dimensional array by the provided key in the key selector.
        /// </summary>
        /// <typeparam name="T">The type of the source two-dimensional array.</typeparam>
        /// <param name="source">The source two-dimensional array.</param>
        /// <param name="keySelector">The selector to retrieve the column to sort on.</param>
        /// <returns>A new two dimensional array sorted on the key.</returns>
        public static T[,] OrderBy<T>(this T[,] source, Func<T[], T> keySelector)
        {
            return source.ConvertToSingleDimension().OrderBy(keySelector).ConvertToMultiDimensional();
        }
        /// <summary>
        ///   Orders the two dimensional array by the provided key in the key selector in descending order.
        /// </summary>
        /// <typeparam name="T">The type of the source two-dimensional array.</typeparam>
        /// <param name="source">The source two-dimensional array.</param>
        /// <param name="keySelector">The selector to retrieve the column to sort on.</param>
        /// <returns>A new two dimensional array sorted on the key.</returns>
        public static T[,] OrderByDescending<T>(this T[,] source, Func<T[], T> keySelector)
        {
            return source.ConvertToSingleDimension().
                OrderByDescending(keySelector).ConvertToMultiDimensional();
        }
        /// <summary>
        ///   Converts a two dimensional array to single dimensional array.
        /// </summary>
        /// <typeparam name="T">The type of the two dimensional array.</typeparam>
        /// <param name="source">The source two dimensional array.</param>
        /// <returns>The repackaged two dimensional array as a single dimension based on rows.</returns>
        private static IEnumerable<T[]> ConvertToSingleDimension<T>(this T[,] source)
        {
            T[] arRow;

            for (int row = 0; row < source.GetLength(0); ++row)
            {
                arRow = new T[source.GetLength(1)];

                for (int col = 0; col < source.GetLength(1); ++col)
                    arRow[col] = source[row, col];

                yield return arRow;
            }
        }
        /// <summary>
        ///   Converts a collection of rows from a two dimensional array back into a two dimensional array.
        /// </summary>
        /// <typeparam name="T">The type of the two dimensional array.</typeparam>
        /// <param name="source">The source collection of rows to convert.</param>
        /// <returns>The two dimensional array.</returns>
        private static T[,] ConvertToMultiDimensional<T>(this IEnumerable<T[]> source)
        {
            T[,] twoDimensional;
            T[][] arrayOfArray;
            int numberofColumns;

            arrayOfArray = source.ToArray();
            numberofColumns = (arrayOfArray.Length > 0) ? arrayOfArray[0].Length : 0;
            twoDimensional = new T[arrayOfArray.Length, numberofColumns];

            for (int row = 0; row < arrayOfArray.GetLength(0); ++row)
                for (int col = 0; col < numberofColumns; ++col)
                    twoDimensional[row, col] = arrayOfArray[row][col];

            return twoDimensional;
        }
    }
    //
}