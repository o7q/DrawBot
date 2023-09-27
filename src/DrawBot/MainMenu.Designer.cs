namespace DrawBot
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.StartButton = new System.Windows.Forms.Button();
            this.RegionStartButton = new System.Windows.Forms.Button();
            this.RegionEndButton = new System.Windows.Forms.Button();
            this.Pos1Label = new System.Windows.Forms.Label();
            this.Pos2Label = new System.Windows.Forms.Label();
            this.BoundsLabel = new System.Windows.Forms.Label();
            this.CanvasLabel = new System.Windows.Forms.Label();
            this.RegisterColorButton = new System.Windows.Forms.Button();
            this.SavePaletteButton = new System.Windows.Forms.Button();
            this.PaletteNameTextBox = new System.Windows.Forms.TextBox();
            this.LoadPaletteButton = new System.Windows.Forms.Button();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.QualityTextBox = new System.Windows.Forms.TextBox();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.QualityBar = new System.Windows.Forms.TrackBar();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.PaletteListBox = new System.Windows.Forms.ListBox();
            this.UndoColorButton = new System.Windows.Forms.Button();
            this.ColorRGBLabel = new System.Windows.Forms.Label();
            this.ColorSquare = new System.Windows.Forms.Panel();
            this.ColorIndexLabel = new System.Windows.Forms.Label();
            this.DeletePaletteButton = new System.Windows.Forms.Button();
            this.CreatePresetLabel = new System.Windows.Forms.Label();
            this.LoadPresetLabel = new System.Windows.Forms.Label();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LoadURLImageBox = new System.Windows.Forms.TextBox();
            this.UrlNoticeLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PaletteLabel = new System.Windows.Forms.Label();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.TitlebarLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.DrawMethodComboBox = new System.Windows.Forms.ComboBox();
            this.DrawMethodLabel = new System.Windows.Forms.Label();
            this.LumaFixCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.QualityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.TitlebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.StartButton.Location = new System.Drawing.Point(16, 376);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(159, 50);
            this.StartButton.TabIndex = 18;
            this.StartButton.Text = "Draw";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RegionStartButton
            // 
            this.RegionStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.RegionStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegionStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.RegionStartButton.Location = new System.Drawing.Point(104, 41);
            this.RegionStartButton.Name = "RegionStartButton";
            this.RegionStartButton.Size = new System.Drawing.Size(20, 20);
            this.RegionStartButton.TabIndex = 3;
            this.RegionStartButton.Text = "A";
            this.RegionStartButton.UseVisualStyleBackColor = false;
            this.RegionStartButton.Click += new System.EventHandler(this.RegionStartButton_Click);
            // 
            // RegionEndButton
            // 
            this.RegionEndButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.RegionEndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegionEndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionEndButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.RegionEndButton.Location = new System.Drawing.Point(104, 60);
            this.RegionEndButton.Name = "RegionEndButton";
            this.RegionEndButton.Size = new System.Drawing.Size(20, 20);
            this.RegionEndButton.TabIndex = 4;
            this.RegionEndButton.Text = "B";
            this.RegionEndButton.UseVisualStyleBackColor = false;
            this.RegionEndButton.Click += new System.EventHandler(this.RegionEndButton_Click);
            // 
            // Pos1Label
            // 
            this.Pos1Label.AutoSize = true;
            this.Pos1Label.BackColor = System.Drawing.Color.Transparent;
            this.Pos1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.Pos1Label.Location = new System.Drawing.Point(124, 44);
            this.Pos1Label.Name = "Pos1Label";
            this.Pos1Label.Size = new System.Drawing.Size(26, 12);
            this.Pos1Label.TabIndex = 0;
            this.Pos1Label.Text = "(0, 0)";
            // 
            // Pos2Label
            // 
            this.Pos2Label.AutoSize = true;
            this.Pos2Label.BackColor = System.Drawing.Color.Transparent;
            this.Pos2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.Pos2Label.Location = new System.Drawing.Point(124, 63);
            this.Pos2Label.Name = "Pos2Label";
            this.Pos2Label.Size = new System.Drawing.Size(26, 12);
            this.Pos2Label.TabIndex = 0;
            this.Pos2Label.Text = "(0, 0)";
            // 
            // BoundsLabel
            // 
            this.BoundsLabel.AutoSize = true;
            this.BoundsLabel.BackColor = System.Drawing.Color.Transparent;
            this.BoundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoundsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.BoundsLabel.Location = new System.Drawing.Point(123, 80);
            this.BoundsLabel.Name = "BoundsLabel";
            this.BoundsLabel.Size = new System.Drawing.Size(32, 12);
            this.BoundsLabel.TabIndex = 0;
            this.BoundsLabel.Text = "(0, 0)";
            // 
            // CanvasLabel
            // 
            this.CanvasLabel.AutoSize = true;
            this.CanvasLabel.BackColor = System.Drawing.Color.Transparent;
            this.CanvasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvasLabel.ForeColor = System.Drawing.Color.White;
            this.CanvasLabel.Location = new System.Drawing.Point(12, 25);
            this.CanvasLabel.Name = "CanvasLabel";
            this.CanvasLabel.Size = new System.Drawing.Size(129, 16);
            this.CanvasLabel.TabIndex = 0;
            this.CanvasLabel.Text = "Configure Canvas";
            // 
            // RegisterColorButton
            // 
            this.RegisterColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.RegisterColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.RegisterColorButton.Location = new System.Drawing.Point(16, 118);
            this.RegisterColorButton.Name = "RegisterColorButton";
            this.RegisterColorButton.Size = new System.Drawing.Size(23, 23);
            this.RegisterColorButton.TabIndex = 5;
            this.RegisterColorButton.Text = "+";
            this.RegisterColorButton.UseVisualStyleBackColor = false;
            this.RegisterColorButton.Click += new System.EventHandler(this.RegisterColorButton_Click);
            // 
            // SavePaletteButton
            // 
            this.SavePaletteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.SavePaletteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePaletteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.SavePaletteButton.Location = new System.Drawing.Point(85, 138);
            this.SavePaletteButton.Name = "SavePaletteButton";
            this.SavePaletteButton.Size = new System.Drawing.Size(90, 26);
            this.SavePaletteButton.TabIndex = 8;
            this.SavePaletteButton.Text = "Save";
            this.SavePaletteButton.UseVisualStyleBackColor = false;
            this.SavePaletteButton.Click += new System.EventHandler(this.SavePaletteButton_Click);
            // 
            // PaletteNameTextBox
            // 
            this.PaletteNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.PaletteNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletteNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.PaletteNameTextBox.Location = new System.Drawing.Point(85, 118);
            this.PaletteNameTextBox.Name = "PaletteNameTextBox";
            this.PaletteNameTextBox.Size = new System.Drawing.Size(90, 20);
            this.PaletteNameTextBox.TabIndex = 7;
            this.PaletteNameTextBox.Tag = "";
            // 
            // LoadPaletteButton
            // 
            this.LoadPaletteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.LoadPaletteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPaletteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.LoadPaletteButton.Location = new System.Drawing.Point(16, 340);
            this.LoadPaletteButton.Name = "LoadPaletteButton";
            this.LoadPaletteButton.Size = new System.Drawing.Size(44, 21);
            this.LoadPaletteButton.TabIndex = 10;
            this.LoadPaletteButton.Text = "Load";
            this.LoadPaletteButton.UseVisualStyleBackColor = false;
            this.LoadPaletteButton.Click += new System.EventHandler(this.LoadPaletteButton_Click);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.SpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.SpeedTextBox.Location = new System.Drawing.Point(147, 208);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(28, 20);
            this.SpeedTextBox.TabIndex = 14;
            this.SpeedTextBox.Text = "50";
            this.SpeedTextBox.TextChanged += new System.EventHandler(this.SpeedTextBox_TextChanged);
            // 
            // QualityTextBox
            // 
            this.QualityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.QualityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QualityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.QualityTextBox.Location = new System.Drawing.Point(112, 208);
            this.QualityTextBox.Name = "QualityTextBox";
            this.QualityTextBox.Size = new System.Drawing.Size(28, 20);
            this.QualityTextBox.TabIndex = 12;
            this.QualityTextBox.Text = "50";
            this.QualityTextBox.TextChanged += new System.EventHandler(this.QualityTextBox_TextChanged);
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.BackColor = System.Drawing.Color.Transparent;
            this.QualityLabel.ForeColor = System.Drawing.Color.White;
            this.QualityLabel.Location = new System.Drawing.Point(108, 194);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(39, 13);
            this.QualityLabel.TabIndex = 0;
            this.QualityLabel.Text = "Quality";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLabel.ForeColor = System.Drawing.Color.White;
            this.SpeedLabel.Location = new System.Drawing.Point(143, 194);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "Speed";
            // 
            // QualityBar
            // 
            this.QualityBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.QualityBar.Location = new System.Drawing.Point(110, 228);
            this.QualityBar.Maximum = 100;
            this.QualityBar.Name = "QualityBar";
            this.QualityBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.QualityBar.Size = new System.Drawing.Size(45, 90);
            this.QualityBar.TabIndex = 13;
            this.QualityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.QualityBar.Value = 50;
            this.QualityBar.Scroll += new System.EventHandler(this.QualityBar_Scroll);
            // 
            // SpeedBar
            // 
            this.SpeedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.SpeedBar.Location = new System.Drawing.Point(145, 228);
            this.SpeedBar.Maximum = 100;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SpeedBar.Size = new System.Drawing.Size(45, 90);
            this.SpeedBar.TabIndex = 15;
            this.SpeedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SpeedBar.Value = 50;
            this.SpeedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
            // 
            // PaletteListBox
            // 
            this.PaletteListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.PaletteListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletteListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.PaletteListBox.FormattingEnabled = true;
            this.PaletteListBox.Location = new System.Drawing.Point(16, 208);
            this.PaletteListBox.Name = "PaletteListBox";
            this.PaletteListBox.Size = new System.Drawing.Size(92, 132);
            this.PaletteListBox.TabIndex = 9;
            // 
            // UndoColorButton
            // 
            this.UndoColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.UndoColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.UndoColorButton.Location = new System.Drawing.Point(16, 141);
            this.UndoColorButton.Name = "UndoColorButton";
            this.UndoColorButton.Size = new System.Drawing.Size(23, 23);
            this.UndoColorButton.TabIndex = 6;
            this.UndoColorButton.Text = "x";
            this.UndoColorButton.UseVisualStyleBackColor = false;
            this.UndoColorButton.Click += new System.EventHandler(this.UndoColorButton_Click);
            // 
            // ColorRGBLabel
            // 
            this.ColorRGBLabel.AutoSize = true;
            this.ColorRGBLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorRGBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorRGBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.ColorRGBLabel.Location = new System.Drawing.Point(36, 173);
            this.ColorRGBLabel.Name = "ColorRGBLabel";
            this.ColorRGBLabel.Size = new System.Drawing.Size(36, 12);
            this.ColorRGBLabel.TabIndex = 0;
            this.ColorRGBLabel.Text = "(0, 0, 0)";
            // 
            // ColorSquare
            // 
            this.ColorSquare.BackColor = System.Drawing.Color.Black;
            this.ColorSquare.Location = new System.Drawing.Point(39, 118);
            this.ColorSquare.Name = "ColorSquare";
            this.ColorSquare.Size = new System.Drawing.Size(46, 46);
            this.ColorSquare.TabIndex = 0;
            // 
            // ColorIndexLabel
            // 
            this.ColorIndexLabel.AutoSize = true;
            this.ColorIndexLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorIndexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.ColorIndexLabel.Location = new System.Drawing.Point(36, 164);
            this.ColorIndexLabel.Name = "ColorIndexLabel";
            this.ColorIndexLabel.Size = new System.Drawing.Size(34, 12);
            this.ColorIndexLabel.TabIndex = 0;
            this.ColorIndexLabel.Text = "Color 0";
            // 
            // DeletePaletteButton
            // 
            this.DeletePaletteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.DeletePaletteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePaletteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.DeletePaletteButton.Location = new System.Drawing.Point(60, 340);
            this.DeletePaletteButton.Name = "DeletePaletteButton";
            this.DeletePaletteButton.Size = new System.Drawing.Size(48, 21);
            this.DeletePaletteButton.TabIndex = 11;
            this.DeletePaletteButton.Text = "Delete";
            this.DeletePaletteButton.UseVisualStyleBackColor = false;
            this.DeletePaletteButton.Click += new System.EventHandler(this.DeletePaletteButton_Click);
            // 
            // CreatePresetLabel
            // 
            this.CreatePresetLabel.AutoSize = true;
            this.CreatePresetLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreatePresetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePresetLabel.ForeColor = System.Drawing.Color.White;
            this.CreatePresetLabel.Location = new System.Drawing.Point(12, 101);
            this.CreatePresetLabel.Name = "CreatePresetLabel";
            this.CreatePresetLabel.Size = new System.Drawing.Size(102, 16);
            this.CreatePresetLabel.TabIndex = 0;
            this.CreatePresetLabel.Text = "Create Preset";
            // 
            // LoadPresetLabel
            // 
            this.LoadPresetLabel.AutoSize = true;
            this.LoadPresetLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadPresetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPresetLabel.ForeColor = System.Drawing.Color.White;
            this.LoadPresetLabel.Location = new System.Drawing.Point(12, 192);
            this.LoadPresetLabel.Name = "LoadPresetLabel";
            this.LoadPresetLabel.Size = new System.Drawing.Size(91, 16);
            this.LoadPresetLabel.TabIndex = 0;
            this.LoadPresetLabel.Text = "Load Preset";
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.LoadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.LoadImageButton.Location = new System.Drawing.Point(16, 41);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(44, 20);
            this.LoadImageButton.TabIndex = 1;
            this.LoadImageButton.Text = "Select";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "Image";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.ImageLabel.Location = new System.Drawing.Point(13, 80);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(37, 12);
            this.ImageLabel.TabIndex = 0;
            this.ImageLabel.Text = "IMAGE";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.InfoLabel.Location = new System.Drawing.Point(32, 428);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(121, 12);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "DrawBot v0.0.0 by o7q";
            // 
            // LoadURLImageBox
            // 
            this.LoadURLImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.LoadURLImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadURLImageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.LoadURLImageBox.Location = new System.Drawing.Point(16, 61);
            this.LoadURLImageBox.Name = "LoadURLImageBox";
            this.LoadURLImageBox.Size = new System.Drawing.Size(83, 20);
            this.LoadURLImageBox.TabIndex = 2;
            this.LoadURLImageBox.TextChanged += new System.EventHandler(this.LoadURLImageBox_TextChanged);
            // 
            // UrlNoticeLabel
            // 
            this.UrlNoticeLabel.AutoSize = true;
            this.UrlNoticeLabel.BackColor = System.Drawing.Color.Transparent;
            this.UrlNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlNoticeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.UrlNoticeLabel.Location = new System.Drawing.Point(61, 47);
            this.UrlNoticeLabel.Name = "UrlNoticeLabel";
            this.UrlNoticeLabel.Size = new System.Drawing.Size(37, 12);
            this.UrlNoticeLabel.TabIndex = 0;
            this.UrlNoticeLabel.Text = "or URL:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.SizeLabel.Location = new System.Drawing.Point(97, 80);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(26, 12);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size:";
            // 
            // PaletteLabel
            // 
            this.PaletteLabel.AutoSize = true;
            this.PaletteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaletteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.PaletteLabel.Location = new System.Drawing.Point(13, 361);
            this.PaletteLabel.Name = "PaletteLabel";
            this.PaletteLabel.Size = new System.Drawing.Size(45, 12);
            this.PaletteLabel.TabIndex = 0;
            this.PaletteLabel.Text = "PALETTE";
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.TitlebarPanel.Controls.Add(this.TitlebarLabel);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(-4, -3);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(194, 20);
            this.TitlebarPanel.TabIndex = 0;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // TitlebarLabel
            // 
            this.TitlebarLabel.AutoSize = true;
            this.TitlebarLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitlebarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlebarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.TitlebarLabel.Location = new System.Drawing.Point(9, 5);
            this.TitlebarLabel.Name = "TitlebarLabel";
            this.TitlebarLabel.Size = new System.Drawing.Size(95, 13);
            this.TitlebarLabel.TabIndex = 0;
            this.TitlebarLabel.Text = "DrawBot v0.0.0";
            this.TitlebarLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarLabel_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.CloseButton.Location = new System.Drawing.Point(176, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(16, 16);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.SidebarPanel.Location = new System.Drawing.Point(-4, -4);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(7, 452);
            this.SidebarPanel.TabIndex = 0;
            this.SidebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidebarPanel_MouseDown);
            // 
            // DrawMethodComboBox
            // 
            this.DrawMethodComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.DrawMethodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawMethodComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.DrawMethodComboBox.FormattingEnabled = true;
            this.DrawMethodComboBox.Items.AddRange(new object[] {
            "Strips (quality)",
            "Blobs (fast)"});
            this.DrawMethodComboBox.Location = new System.Drawing.Point(108, 340);
            this.DrawMethodComboBox.Name = "DrawMethodComboBox";
            this.DrawMethodComboBox.Size = new System.Drawing.Size(67, 20);
            this.DrawMethodComboBox.TabIndex = 17;
            // 
            // DrawMethodLabel
            // 
            this.DrawMethodLabel.AutoSize = true;
            this.DrawMethodLabel.BackColor = System.Drawing.Color.Transparent;
            this.DrawMethodLabel.ForeColor = System.Drawing.Color.White;
            this.DrawMethodLabel.Location = new System.Drawing.Point(108, 327);
            this.DrawMethodLabel.Name = "DrawMethodLabel";
            this.DrawMethodLabel.Size = new System.Drawing.Size(71, 13);
            this.DrawMethodLabel.TabIndex = 0;
            this.DrawMethodLabel.Text = "Draw Method";
            // 
            // LumaFixCheckBox
            // 
            this.LumaFixCheckBox.AutoSize = true;
            this.LumaFixCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.LumaFixCheckBox.Checked = true;
            this.LumaFixCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LumaFixCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.LumaFixCheckBox.Location = new System.Drawing.Point(112, 312);
            this.LumaFixCheckBox.Name = "LumaFixCheckBox";
            this.LumaFixCheckBox.Size = new System.Drawing.Size(68, 17);
            this.LumaFixCheckBox.TabIndex = 16;
            this.LumaFixCheckBox.Text = "Fix Luma";
            this.LumaFixCheckBox.UseVisualStyleBackColor = false;
            this.LumaFixCheckBox.CheckedChanged += new System.EventHandler(this.LumaFixCheckBox_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::DrawBot.Properties.Resources.background_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(188, 446);
            this.Controls.Add(this.LumaFixCheckBox);
            this.Controls.Add(this.DrawMethodLabel);
            this.Controls.Add(this.DrawMethodComboBox);
            this.Controls.Add(this.SidebarPanel);
            this.Controls.Add(this.TitlebarPanel);
            this.Controls.Add(this.PaletteLabel);
            this.Controls.Add(this.UrlNoticeLabel);
            this.Controls.Add(this.LoadURLImageBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.LoadPresetLabel);
            this.Controls.Add(this.CreatePresetLabel);
            this.Controls.Add(this.DeletePaletteButton);
            this.Controls.Add(this.ColorIndexLabel);
            this.Controls.Add(this.ColorSquare);
            this.Controls.Add(this.ColorRGBLabel);
            this.Controls.Add(this.UndoColorButton);
            this.Controls.Add(this.PaletteListBox);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.QualityBar);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityTextBox);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.LoadPaletteButton);
            this.Controls.Add(this.PaletteNameTextBox);
            this.Controls.Add(this.SavePaletteButton);
            this.Controls.Add(this.RegisterColorButton);
            this.Controls.Add(this.CanvasLabel);
            this.Controls.Add(this.BoundsLabel);
            this.Controls.Add(this.Pos2Label);
            this.Controls.Add(this.Pos1Label);
            this.Controls.Add(this.RegionEndButton);
            this.Controls.Add(this.RegionStartButton);
            this.Controls.Add(this.StartButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "DrawBot";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseEnter += new System.EventHandler(this.MainMenu_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.QualityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RegionStartButton;
        private System.Windows.Forms.Button RegionEndButton;
        private System.Windows.Forms.Label Pos1Label;
        private System.Windows.Forms.Label Pos2Label;
        private System.Windows.Forms.Label BoundsLabel;
        private System.Windows.Forms.Label CanvasLabel;
        private System.Windows.Forms.Button RegisterColorButton;
        private System.Windows.Forms.Button SavePaletteButton;
        private System.Windows.Forms.TextBox PaletteNameTextBox;
        private System.Windows.Forms.Button LoadPaletteButton;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.TextBox QualityTextBox;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TrackBar QualityBar;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.ListBox PaletteListBox;
        private System.Windows.Forms.Button UndoColorButton;
        private System.Windows.Forms.Label ColorRGBLabel;
        private System.Windows.Forms.Panel ColorSquare;
        private System.Windows.Forms.Label ColorIndexLabel;
        private System.Windows.Forms.Button DeletePaletteButton;
        private System.Windows.Forms.Label CreatePresetLabel;
        private System.Windows.Forms.Label LoadPresetLabel;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox LoadURLImageBox;
        private System.Windows.Forms.Label UrlNoticeLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label PaletteLabel;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Label TitlebarLabel;
        private System.Windows.Forms.ComboBox DrawMethodComboBox;
        private System.Windows.Forms.Label DrawMethodLabel;
        private System.Windows.Forms.CheckBox LumaFixCheckBox;
    }
}

