using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DrawBot
{
    public partial class program : Form
    {
        // configure mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // grab dlls for mousedown
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // grab dlls for mouse controls
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // mouse inputs
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        // key detection script
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        // 0x01 = leftmouse
        // 0x1B = esc
        private bool keyDetect(int key)
        {
            short keyState = GetAsyncKeyState(key);
            bool keyPressed = ((keyState >> 15) & 0x0001) == 0x0001;

            if (keyPressed)
                return true;

            return false;
        }

        const string version = "v2.0.0";

        // region
        int x_region_start = 0;
        int y_region_start = 0;
        int x_region_end = 0;
        int y_region_end = 0;

        // preset creator
        string colorsTemp = "";
        int colorsIndex = 0;
        bool hasSavedPalette = false;

        // palette storage
        public int[,] colorPalette { get; set; }
        int paletteAmount;
        bool paletteLoaded = false;

        // image
        string imagePath = "";
        Bitmap image;

        public program()
        {
            InitializeComponent();

            // default labels
            titlebarLabel.Text = "DrawBot " + version;
            infoLabel.Text = "DrawBot " + version + " by o7q";
            imageLabel.Text = "";
            colorsLabel.Text = "";
            
            // select default algorithm
            algorithmComboBox.SelectedIndex = 1;
        }

        private void program_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("DrawBot\\presets");
            refreshColorsList();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (imageLabel.Text == "")
            {
                MessageBox.Show("Please select an image");
                return;
            }

            if (x_region_start * x_region_end == 0 || y_region_start * y_region_end == 0)
            {
                MessageBox.Show("Please define your canvas bounds");
                return;
            }

            if (paletteLoaded == false)
            {
                MessageBox.Show("Please select a color preset");
                return;
            }

            if (algorithmComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a drawing method");
                return;
            }

            TopMost = true;

            int quality_step = 500 / (Int32.Parse(qualityBox.Text) + 1);
            double speed = 0.1 / double.Parse(speedBox.Text);

            int x_bound = (x_region_end - x_region_start) / quality_step;
            int y_bound = (y_region_end - y_region_start) / quality_step;

            if (loadURLImageBox.Text == "")
            {
                // load local image
                try
                {
                    image = new Bitmap(Image.FromFile(imagePath), new Size(x_bound, y_bound));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading local image\n\n" + ex);
                    return;
                }
            }
            else
            {
                // load web image
                try
                {
                    var request = WebRequest.Create(loadURLImageBox.Text);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                        image = new Bitmap(Bitmap.FromStream(stream), new Size(x_bound, y_bound));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading web image\n\n" + ex);
                    return;
                }
            }

            int completeState = 0;
            switch(algorithmComboBox.SelectedIndex)
            {
                case 0: completeState = drawUsingStrips(x_bound, y_bound, quality_step, speed); break;
                case 1: completeState = drawUsingBlobs(x_bound, y_bound, quality_step, speed); break;
            }

            image.Dispose();
            TopMost = false;

            if (completeState == 1) return;
            moveCursor(x_region_start, y_region_start);
        }

        private int drawUsingStrips(int x_bound, int y_bound, int quality_step, double speed)
        {
            int area = x_bound * y_bound;

            int x_track = 0;
            int y_track = 0;

            bool selectNew = true;
            bool initialSelect = true;

            moveCursor(x_region_start, y_region_start);

            for (int i = 0; i < area; i++)
            {
                // abort draw
                if (keyDetect(0x1B) == true) return 1;

                // calculate future color
                Color colorNext = new Color();
                if (x_track + 1 < x_bound)
                    colorNext = image.GetPixel(x_track + 1, y_track);

                // calculate next line
                if (x_track == x_bound)
                {
                    Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X - x_bound * quality_step, Cursor.Position.Y + quality_step);

                    x_track = 0;
                    y_track++;

                    colorNext = image.GetPixel(x_track + 1, y_track);
                }

                Color color = image.GetPixel(x_track, y_track);

                // color matching algorithm (thank you emmett!)
                int nearestIndex = -1;
                int nearestIndexNext = -1;
                int nearestDist = Int32.MaxValue;
                int nearestDistNext = Int32.MaxValue;
                for (int j = 0; j < paletteAmount; j++)
                {
                    // calculate distance to color
                    int dist = getDist(color.R, colorPalette[j, 2], color.G, colorPalette[j, 3], color.B, colorPalette[j, 4]);
                    int distNext = getDist(colorNext.R, colorPalette[j, 2], colorNext.G, colorPalette[j, 3], colorNext.B, colorPalette[j, 4]);

                    // update nearest color
                    if (dist < nearestDist)
                    {
                        nearestDist = dist;
                        nearestIndex = j;
                    }

                    // update future nearest color
                    if (distNext < nearestDistNext)
                    {
                        nearestDistNext = distNext;
                        nearestIndexNext = j;
                    }
                }

                int x_track_temp = Cursor.Position.X;
                int y_track_temp = Cursor.Position.Y;

                // select first needed color
                if (initialSelect == true)
                {
                    moveCursor(colorPalette[nearestIndex, 0], colorPalette[nearestIndex, 1]);
                    clickCursor(speed);

                    moveCursor(x_track_temp, y_track_temp);

                    initialSelect = false;
                }

                if (nearestIndex == nearestIndexNext)
                {
                    // place pixel using same color
                    if (selectNew == true)
                    {
                        moveCursor(colorPalette[nearestIndex, 0], colorPalette[nearestIndex, 1]);
                        clickCursor(speed);

                        moveCursor(x_track_temp, y_track_temp);
                    }
                    selectNew = false;

                    clickCursor(speed);
                }
                else
                {
                    // place pixel using new color
                    moveCursor(colorPalette[nearestIndex, 0], colorPalette[nearestIndex, 1]);
                    clickCursor(speed);

                    moveCursor(x_track_temp, y_track_temp);
                    clickCursor(speed);

                    selectNew = true;
                }

                moveCursor(Cursor.Position.X + quality_step, Cursor.Position.Y);

                x_track++;
            }

            return 0;
        }

        private int drawUsingBlobs(int x_bound, int y_bound, int quality_step, double speed)
        {
            int area = x_bound * y_bound;

            int x_pixel = 0;
            int y_pixel = 0;

            // quantize image using 3d rgb distance
            int[,] quantizedImage = new int[x_bound, y_bound];
            for (int i = 0; i < area; i++)
            {
                if (x_pixel == x_bound)
                {
                    x_pixel = 0;
                    y_pixel++;
                }

                Color color = image.GetPixel(x_pixel, y_pixel);

                // color matching algorithm (thank you emmett!)
                int nearestDist = Int32.MaxValue;
                for (int j = 0; j < paletteAmount; j++)
                {
                    // calculate distance to color
                    int dist = getDist(color.R, colorPalette[j, 2], color.G, colorPalette[j, 3], color.B, colorPalette[j, 4]);

                    // update closest color
                    if (dist < nearestDist)
                        nearestDist = dist;
                }
                quantizedImage[x_pixel, y_pixel] = nearestDist;

                x_pixel++;
            }

            moveCursor(x_region_start, y_region_start);

            int colorIndex = 0;
            int[,] pixelIndex = new int[x_bound, y_bound];

            for (int j = 0; j < paletteAmount; j++)
            {
                moveCursor(colorPalette[colorIndex, 0], colorPalette[colorIndex, 1]);
                clickCursor(speed);

                int x_index = 0;
                int y_index = 0;

                int mouseX_pos = x_region_start;
                int mouseY_pos = y_region_start;

                for (int i = 0; i < area; i++)
                {
                    // abort draw
                    if (keyDetect(0x1B) == true) return 1;

                    // calculate new line
                    if (x_index == x_bound)
                    {
                        mouseX_pos = mouseX_pos - x_bound * quality_step;
                        mouseY_pos = mouseY_pos + quality_step;

                        x_index = 0;
                        y_index++;
                    }

                    Color color = image.GetPixel(x_index, y_index);
                    int dist = getDist(color.R, colorPalette[colorIndex, 2], color.G, colorPalette[colorIndex, 3], color.B, colorPalette[colorIndex, 4]);

                    // place blob pixel
                    if (dist == quantizedImage[x_index, y_index] && pixelIndex[x_index, y_index] == 0)
                    {
                        moveCursor(mouseX_pos, mouseY_pos);
                        clickCursor(speed);

                        pixelIndex[x_index, y_index] = 1;
                    }

                    mouseX_pos += quality_step;
                    x_index++;
                }

                colorIndex++;
            }

            return 0;
        }

        private int getDist(int r1, int r2, int g1, int g2, int b1, int b2)
        {
            return (int)Math.Sqrt
            (
                Math.Pow(r1 - r2, 2) +
                Math.Pow(g1 - g2, 2) +
                Math.Pow(b1 - b2, 2)
            );
        }
        private void moveCursor(int x, int y)
        {
            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
        }
        private void clickCursor(double wait)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedTicks < Math.Round(wait * Stopwatch.Frequency)) { }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (imageLabel.Text.Length > 11)
                imageLabel.Text = imageLabel.Text.Substring(imageLabel.Text.Length - 11);
        }

        private void regionStartButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (keyDetect(0x01) == false) { }

            x_region_start = Cursor.Position.X;
            y_region_start = Cursor.Position.Y;
            pos1Label.Text = (x_region_start, y_region_start).ToString();
            boundsLabel.Text = "(" + (x_region_end - x_region_start).ToString() + ", " + (y_region_end - y_region_start).ToString() + ")";
        }

        private void regionEndButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (keyDetect(0x01) == false) { }

            x_region_end = Cursor.Position.X;
            y_region_end = Cursor.Position.Y;
            pos2Label.Text = (x_region_end, y_region_end).ToString();
            boundsLabel.Text = "(" + (x_region_end - x_region_start).ToString() + ", " + (y_region_end - y_region_start).ToString() + ")";
        }

        private void registerColorButton_Click(object sender, EventArgs e)
        {
            if (hasSavedPalette == true)
            {
                colorsTemp = "";
                colorsIndex = 0;
                colorIndexLabel.Text = "Color 0"; colorIndexLabel.Refresh();
                colorLabel.Text = "(0, 0, 0)"; colorLabel.Refresh();
                colorSquare.BackColor = Color.FromArgb(255, 0, 0, 0);

                hasSavedPalette = false;
            }

            TopMost = true;
            while (keyDetect(0x01) == false) { }

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            var rgb = GetColorAt(x, y);
            colorsTemp += "|" + x + "," + y + "," + rgb.Item1 + "," + rgb.Item2 + "," + rgb.Item3;
            colorsIndex++;

            colorIndexLabel.Text = "Color " + colorsIndex.ToString();
            colorLabel.Text = rgb.ToString();
            colorSquare.BackColor = Color.FromArgb(255, rgb.Item1, rgb.Item2, rgb.Item3);
        }

        private void undoColorButton_Click(object sender, EventArgs e)
        {
            if (colorsTemp == "") return;

            colorsTemp = colorsTemp.Remove(colorsTemp.LastIndexOf('|'));
            colorsIndex--;

            colorIndexLabel.Text = "Color " + colorsIndex;
            colorLabel.Text = "(0, 0, 0)";
            colorSquare.BackColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void finalizeColorsButton_Click(object sender, EventArgs e)
        {
            if (colorsTemp == "") return;
            colorsTemp = colorsTemp.Substring(1);
            string name = finalizeColorsBox.Text == "" ? "preset" + DateTime.Now.ToString("Mdy-hms") : finalizeColorsBox.Text;
            File.WriteAllText("DrawBot\\presets\\" + name + ".palette", colorsTemp);
            refreshColorsList();

            finalizeColorsBox.Text = "";
            hasSavedPalette = true;
        }

        private void loadColorsButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("DrawBot\\presets", "*.*", SearchOption.TopDirectoryOnly).Length == 0) return;

            string paletteFilePath = "DrawBot\\presets\\" + colorsList.SelectedItem + ".palette";
            string paletteFile = File.ReadAllText(paletteFilePath);

            string[] RGBpixel = paletteFile.Split('|');
            paletteAmount = RGBpixel.Length;
            colorPalette = new int[paletteFile.Length, 5];
            for (int i = 0; i < RGBpixel.Length; i++)
            {
                string[] value = RGBpixel[i].Split(',');
                for (int j = 0; j < 5; j++)
                    colorPalette[i, j] = Int32.Parse(value[j]);
            }

            colorsLabel.Text = Path.GetFileNameWithoutExtension(paletteFilePath);
            paletteLoaded = true;
        }

        private void deleteColorsButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("DrawBot\\presets", "*.*", SearchOption.TopDirectoryOnly).Length == 0) return;
            File.Delete("DrawBot\\presets\\" + colorsList.SelectedItem + ".palette");
            refreshColorsList();
            if (colorsList.Items.Count > 0) colorsList.SelectedIndex = 0;

            colorsLabel.Text = "";
            paletteLoaded = false;
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

        private void program_MouseEnter(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void titlebarLabel_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }
        private void titlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }
        private void sidebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }

        private void refreshColorsList()
        {
            colorsList.Items.Clear();
            string[] paletteFiles = Directory.GetFiles("DrawBot\\presets", "*.palette");
            for (int i = 0; i < paletteFiles.Length; i++)
                colorsList.Items.Add(Path.GetFileNameWithoutExtension(paletteFiles[i]));
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

        private void moveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}