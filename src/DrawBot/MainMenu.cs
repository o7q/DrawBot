using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DrawBot
{
    public partial class MainMenu : Form
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
        private bool DetectKey(string key)
        {
            int keyInt = 0x00;
            if (key == "LeftMouse") keyInt = 0x01;
            if (key == "Escape") keyInt = 0x1B;

            short keyState = GetAsyncKeyState(keyInt);
            bool keyPressed = ((keyState >> 15) & 0x0001) == 0x0001;

            if (keyPressed)
                return true;

            return false;
        }

        const string version = "v2.1.0";

        public struct colorInfo
        {
            public int x, y, r, g, b;
        }

        // region
        int x_region_start = 0;
        int y_region_start = 0;
        int x_region_end = 0;
        int y_region_end = 0;

        // luminance correction
        const double r_luma_fix = 0.299;
        const double g_luma_fix = 0.587;
        const double b_luma_fix = 0.114;
        double r_luma = r_luma_fix;
        double g_luma = g_luma_fix;
        double b_luma = b_luma_fix;

        // preset creator
        string colorsTemp = "";
        int colorsIndex = 0;
        bool hasSavedPalette = false;

        // palette storage
        public colorInfo[] colorPalette { get; set; }
        int paletteAmount;
        bool paletteLoaded = false;

        // image
        string imagePath = "";
        Bitmap image;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // default labels
            TitlebarLabel.Text = "DrawBot " + version;
            InfoLabel.Text = "DrawBot " + version + " by o7q";
            ImageLabel.Text = "";
            PaletteLabel.Text = "";

            // select default algorithm
            DrawMethodComboBox.SelectedIndex = 1;

            Directory.CreateDirectory("DrawBot\\presets");
            RefreshColorsList();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ImageLabel.Text == "")
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

            if (DrawMethodComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a drawing method");
                return;
            }

            TopMost = true;

            int quality_step = 200 / int.Parse(QualityTextBox.Text);
            double speed = 0.1 / double.Parse(SpeedTextBox.Text);

            int x_bound = (x_region_end - x_region_start) / quality_step;
            int y_bound = (y_region_end - y_region_start) / quality_step;

            if (LoadURLImageBox.Text == "")
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
                    var request = WebRequest.Create(LoadURLImageBox.Text);

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
            switch (DrawMethodComboBox.SelectedIndex)
            {
                case 0: completeState = DrawUsingStrips(x_bound, y_bound, quality_step, speed); break;
                case 1: completeState = DrawUsingBlobs(x_bound, y_bound, quality_step, speed); break;
            }

            image.Dispose();
            TopMost = false;

            if (completeState == 1) return;
            MoveCursor(x_region_start, y_region_start);
        }

        private int DrawUsingStrips(int x_bound, int y_bound, int quality_step, double speed)
        {
            int area = x_bound * y_bound;

            int x_track = 0;
            int y_track = 0;

            bool selectNew = true;
            bool initialSelect = true;

            MoveCursor(x_region_start, y_region_start);

            for (int i = 0; i < area; i++)
            {
                // abort draw
                if (DetectKey("Escape") == true)
                {
                    int x_pause_temp = Cursor.Position.X;
                    int y_pause_temp = Cursor.Position.Y;

                    DialogResult prompt = MessageBox.Show("Drawing paused.\n\nPress OK to resume\nPress CANCEL to stop", "", MessageBoxButtons.OKCancel);
                    if (prompt == DialogResult.Cancel) return 1;

                    MoveCursor(x_pause_temp, y_pause_temp);
                }

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
                int nearestDist = int.MaxValue;
                int nearestDistNext = int.MaxValue;
                for (int j = 0; j < paletteAmount; j++)
                {
                    // calculate distance to color
                    int dist = Get3DDistance(color.R, colorPalette[j].r, color.G, colorPalette[j].g, color.B, colorPalette[j].b);
                    int distNext = Get3DDistance(colorNext.R, colorPalette[j].r, colorNext.G, colorPalette[j].g, colorNext.B, colorPalette[j].b);

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
                    MoveCursor(colorPalette[nearestIndex].x, colorPalette[nearestIndex].y);
                    ClickCursor(speed);

                    MoveCursor(x_track_temp, y_track_temp);

                    initialSelect = false;
                }

                if (nearestIndex == nearestIndexNext)
                {
                    // place pixel using same color
                    if (selectNew == true)
                    {
                        MoveCursor(colorPalette[nearestIndex].x, colorPalette[nearestIndex].y);
                        ClickCursor(speed);

                        MoveCursor(x_track_temp, y_track_temp);
                    }
                    selectNew = false;

                    ClickCursor(speed);
                }
                else
                {
                    // place pixel using new color
                    MoveCursor(colorPalette[nearestIndex].x, colorPalette[nearestIndex].y);
                    ClickCursor(speed);

                    MoveCursor(x_track_temp, y_track_temp);
                    ClickCursor(speed);

                    selectNew = true;
                }

                MoveCursor(Cursor.Position.X + quality_step, Cursor.Position.Y);

                x_track++;
            }

            return 0;
        }

        private int DrawUsingBlobs(int x_bound, int y_bound, int quality_step, double speed)
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
                int nearestDist = int.MaxValue;
                for (int j = 0; j < paletteAmount; j++)
                {
                    // calculate distance to color
                    int dist = Get3DDistance(color.R, colorPalette[j].r, color.G, colorPalette[j].g, color.B, colorPalette[j].b);

                    // update closest color
                    if (dist < nearestDist)
                        nearestDist = dist;
                }
                quantizedImage[x_pixel, y_pixel] = nearestDist;

                x_pixel++;
            }

            MoveCursor(x_region_start, y_region_start);

            int colorIndex = 0;
            int[,] pixelIndex = new int[x_bound, y_bound];

            // for every color scan the entire area
            for (int j = 0; j < paletteAmount; j++)
            {
                // select color at index with position (x, y)
                MoveCursor(colorPalette[colorIndex].x, colorPalette[colorIndex].y);
                ClickCursor(speed);

                int x_index = 0;
                int y_index = 0;

                int mouseX_pos = x_region_start;
                int mouseY_pos = y_region_start;

                // draw with selected color
                for (int i = 0; i < area; i++)
                {
                    // abort draw
                    if (DetectKey("Escape") == true)
                    {
                        int x_pause_temp = Cursor.Position.X;
                        int y_pause_temp = Cursor.Position.Y;

                        DialogResult prompt = MessageBox.Show("Drawing paused.\n\nPress OK to resume\nPress CANCEL to stop", "", MessageBoxButtons.OKCancel);
                        if (prompt == DialogResult.Cancel) return 1;

                        MoveCursor(x_pause_temp, y_pause_temp);
                    }

                    // calculate new line (like a typewriter resetting)
                    if (x_index == x_bound)
                    {
                        mouseX_pos = mouseX_pos - x_bound * quality_step;
                        mouseY_pos = mouseY_pos + quality_step;

                        x_index = 0;
                        y_index++;
                    }

                    // getting the color of the pixel at (x, y)
                    Color color = image.GetPixel(x_index, y_index);
                    int dist = Get3DDistance(color.R, colorPalette[colorIndex].r, color.G, colorPalette[colorIndex].g, color.B, colorPalette[colorIndex].b);

                    // place blob pixel if not already
                    if (dist == quantizedImage[x_index, y_index] && pixelIndex[x_index, y_index] == 0)
                    {
                        // placing pixel
                        MoveCursor(mouseX_pos, mouseY_pos);
                        ClickCursor(speed);

                        // set pixel to already placed
                        pixelIndex[x_index, y_index] = 1;
                    }

                    // prepare for next pixel
                    mouseX_pos += quality_step;
                    x_index++;
                }

                // cycling through palette colors
                colorIndex++;
            }

            return 0;
        }

        private int Get3DDistance(int r1, int r2, int g1, int g2, int b1, int b2)
        {
            return (int)Math.Sqrt
            (
                r_luma * Math.Pow(r1 - r2, 2) +
                g_luma * Math.Pow(g1 - g2, 2) +
                b_luma * Math.Pow(b1 - b2, 2)
            );
        }
        private void MoveCursor(int x, int y)
        {
            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
        }
        private void ClickCursor(double wait)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedTicks < Math.Round(wait * Stopwatch.Frequency)) { }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            openImageDialog.Filter = "All files (*.*)|*.*|PNG|*.png|JPG|*.jpg";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImageDialog.FileName;
                ImageLabel.Text = Path.GetFileName(imagePath);
            }
        }

        private void LoadURLImageBox_TextChanged(object sender, EventArgs e)
        {
            ImageLabel.Text = LoadURLImageBox.Text;
            if (ImageLabel.Text.Length > 11)
                ImageLabel.Text = ImageLabel.Text.Substring(ImageLabel.Text.Length - 11);

            if (LoadURLImageBox.Text == "")
                ImageLabel.Text = Path.GetFileName(imagePath);
        }

        private void RegionStartButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (DetectKey("LeftMouse") == false) { }

            x_region_start = Cursor.Position.X;
            y_region_start = Cursor.Position.Y;
            Pos1Label.Text = (x_region_start, y_region_start).ToString();
            BoundsLabel.Text = "(" + (x_region_end - x_region_start).ToString() + ", " + (y_region_end - y_region_start).ToString() + ")";
        }

        private void RegionEndButton_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (DetectKey("LeftMouse") == false) { }

            x_region_end = Cursor.Position.X;
            y_region_end = Cursor.Position.Y;
            Pos2Label.Text = (x_region_end, y_region_end).ToString();
            BoundsLabel.Text = "(" + (x_region_end - x_region_start).ToString() + ", " + (y_region_end - y_region_start).ToString() + ")";
        }

        private void RegisterColorButton_Click(object sender, EventArgs e)
        {
            if (hasSavedPalette == true)
            {
                colorsTemp = "";
                colorsIndex = 0;
                ColorIndexLabel.Text = "Color 0"; ColorIndexLabel.Refresh();
                ColorRGBLabel.Text = "(0, 0, 0)"; ColorRGBLabel.Refresh();
                ColorSquare.BackColor = Color.FromArgb(255, 0, 0, 0);

                hasSavedPalette = false;
            }

            TopMost = true;
            while (DetectKey("LeftMouse") == false) { }

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            var rgb = GetColorAt(x, y);
            colorsTemp += "|" + x + "," + y + "," + rgb.Item1 + "," + rgb.Item2 + "," + rgb.Item3;
            colorsIndex++;

            ColorIndexLabel.Text = "Color " + colorsIndex.ToString();
            ColorRGBLabel.Text = rgb.ToString();
            ColorSquare.BackColor = Color.FromArgb(255, rgb.Item1, rgb.Item2, rgb.Item3);
        }

        private void UndoColorButton_Click(object sender, EventArgs e)
        {
            if (colorsTemp == "") return;

            colorsIndex--;
            if (colorsIndex == 0)
                colorsTemp = "";
            else
                colorsTemp = colorsTemp.Remove(colorsTemp.LastIndexOf('|'));

            ColorIndexLabel.Text = "Color " + colorsIndex;
            ColorRGBLabel.Text = "(0, 0, 0)";
            ColorSquare.BackColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void SavePaletteButton_Click(object sender, EventArgs e)
        {
            if (colorsTemp == "") return;
            colorsTemp = colorsTemp.Substring(1);
            string name = PaletteNameTextBox.Text == "" ? "preset" + DateTime.Now.ToString("Mdy-hms") : PaletteNameTextBox.Text;
            File.WriteAllText("DrawBot\\presets\\" + name + ".palette", colorsTemp);
            RefreshColorsList();

            PaletteNameTextBox.Text = "";
            hasSavedPalette = true;
        }

        private void LoadPaletteButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("DrawBot\\presets", "*.*", SearchOption.TopDirectoryOnly).Length == 0) return;

            string paletteFilePath = "DrawBot\\presets\\" + PaletteListBox.SelectedItem + ".palette";
            string paletteFile = File.ReadAllText(paletteFilePath);

            string[] RGBpixel = paletteFile.Split('|');
            paletteAmount = RGBpixel.Length;
            colorPalette = new colorInfo[paletteFile.Length];

            // load xyrgb data into palette
            for (int i = 0; i < RGBpixel.Length; i++)
            {
                string[] value = RGBpixel[i].Split(',');

                int[] valueInt = new int[5];
                for (int j = 0; j < 5; j++)
                    valueInt[j] = int.Parse(value[j]);

                colorPalette[i].x = valueInt[0];
                colorPalette[i].y = valueInt[1];
                colorPalette[i].r = valueInt[2];
                colorPalette[i].g = valueInt[3];
                colorPalette[i].b = valueInt[4];
            }

            PaletteLabel.Text = Path.GetFileNameWithoutExtension(paletteFilePath);
            paletteLoaded = true;
        }

        private void DeletePaletteButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("DrawBot\\presets", "*.*", SearchOption.TopDirectoryOnly).Length == 0) return;
            File.Delete("DrawBot\\presets\\" + PaletteListBox.SelectedItem + ".palette");
            RefreshColorsList();
            if (PaletteListBox.Items.Count > 0) PaletteListBox.SelectedIndex = 0;

            PaletteLabel.Text = "";
            paletteLoaded = false;
        }

        private void QualityTextBox_TextChanged(object sender, EventArgs e)
        {
            int quality;
            try
            {
                quality = int.Parse(QualityTextBox.Text);
            }
            catch
            {
                quality = 50;
            }
            if (quality > 100) quality = 100;
            if (quality < 1) quality = 1;
            QualityTextBox.Text = quality.ToString();
            QualityBar.Value = quality;
        }
        private void QualityBar_Scroll(object sender, EventArgs e)
        {
            QualityTextBox.Text = QualityBar.Value.ToString();
        }

        private void SpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            int speed;
            try
            {
                speed = int.Parse(SpeedTextBox.Text);
            }
            catch
            {
                speed = 50;
            }
            if (speed > 100) speed = 100;
            if (speed < 1) speed = 1;
            SpeedTextBox.Text = speed.ToString();
            SpeedBar.Value = speed;
        }
        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            SpeedTextBox.Text = SpeedBar.Value.ToString();
        }

        private void LumaFixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LumaFixCheckBox.Checked == true)
            {
                r_luma = r_luma_fix;
                g_luma = g_luma_fix;
                b_luma = b_luma_fix;
            }
            else
            {
                r_luma = 1.0;
                g_luma = 1.0;
                b_luma = 1.0;
            }
        }

        private void MainMenu_MouseEnter(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void TitlebarLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        private void SidebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void RefreshColorsList()
        {
            PaletteListBox.Items.Clear();
            string[] paletteFiles = Directory.GetFiles("DrawBot\\presets", "*.palette");
            for (int i = 0; i < paletteFiles.Length; i++)
                PaletteListBox.Items.Add(Path.GetFileNameWithoutExtension(paletteFiles[i]));
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

        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}