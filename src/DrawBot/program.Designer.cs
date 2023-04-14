namespace DrawBot
{
    partial class program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program));
            this.startButton = new System.Windows.Forms.Button();
            this.regionStartButton = new System.Windows.Forms.Button();
            this.regionEndButton = new System.Windows.Forms.Button();
            this.pos1Label = new System.Windows.Forms.Label();
            this.pos2Label = new System.Windows.Forms.Label();
            this.boundsLabel = new System.Windows.Forms.Label();
            this.configureImageLabel = new System.Windows.Forms.Label();
            this.registerColorButton = new System.Windows.Forms.Button();
            this.finalizeColorsButton = new System.Windows.Forms.Button();
            this.finalizeColorsBox = new System.Windows.Forms.TextBox();
            this.loadColorsButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.qualityBox = new System.Windows.Forms.TextBox();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.qualityBar = new System.Windows.Forms.TrackBar();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.colorsList = new System.Windows.Forms.ListBox();
            this.undoColorButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorSquare = new System.Windows.Forms.Panel();
            this.colorIndexLabel = new System.Windows.Forms.Label();
            this.deleteColorsButton = new System.Windows.Forms.Button();
            this.createPresetLabel = new System.Windows.Forms.Label();
            this.loadPresetLabel = new System.Windows.Forms.Label();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.loadURLImageBox = new System.Windows.Forms.TextBox();
            this.urlNoticeLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.colorsLabel = new System.Windows.Forms.Label();
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.titlebarLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.luminanceFixCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.titlebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.startButton.Location = new System.Drawing.Point(16, 376);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(159, 50);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "Draw";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // regionStartButton
            // 
            this.regionStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.regionStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regionStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.regionStartButton.Location = new System.Drawing.Point(104, 41);
            this.regionStartButton.Name = "regionStartButton";
            this.regionStartButton.Size = new System.Drawing.Size(20, 20);
            this.regionStartButton.TabIndex = 3;
            this.regionStartButton.Text = "A";
            this.regionStartButton.UseVisualStyleBackColor = false;
            this.regionStartButton.Click += new System.EventHandler(this.regionStartButton_Click);
            // 
            // regionEndButton
            // 
            this.regionEndButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.regionEndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regionEndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionEndButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.regionEndButton.Location = new System.Drawing.Point(104, 60);
            this.regionEndButton.Name = "regionEndButton";
            this.regionEndButton.Size = new System.Drawing.Size(20, 20);
            this.regionEndButton.TabIndex = 4;
            this.regionEndButton.Text = "B";
            this.regionEndButton.UseVisualStyleBackColor = false;
            this.regionEndButton.Click += new System.EventHandler(this.regionEndButton_Click);
            // 
            // pos1Label
            // 
            this.pos1Label.AutoSize = true;
            this.pos1Label.BackColor = System.Drawing.Color.Transparent;
            this.pos1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.pos1Label.Location = new System.Drawing.Point(124, 44);
            this.pos1Label.Name = "pos1Label";
            this.pos1Label.Size = new System.Drawing.Size(26, 12);
            this.pos1Label.TabIndex = 0;
            this.pos1Label.Text = "(0, 0)";
            // 
            // pos2Label
            // 
            this.pos2Label.AutoSize = true;
            this.pos2Label.BackColor = System.Drawing.Color.Transparent;
            this.pos2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.pos2Label.Location = new System.Drawing.Point(124, 63);
            this.pos2Label.Name = "pos2Label";
            this.pos2Label.Size = new System.Drawing.Size(26, 12);
            this.pos2Label.TabIndex = 0;
            this.pos2Label.Text = "(0, 0)";
            // 
            // boundsLabel
            // 
            this.boundsLabel.AutoSize = true;
            this.boundsLabel.BackColor = System.Drawing.Color.Transparent;
            this.boundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.boundsLabel.Location = new System.Drawing.Point(123, 80);
            this.boundsLabel.Name = "boundsLabel";
            this.boundsLabel.Size = new System.Drawing.Size(32, 12);
            this.boundsLabel.TabIndex = 0;
            this.boundsLabel.Text = "(0, 0)";
            // 
            // configureImageLabel
            // 
            this.configureImageLabel.AutoSize = true;
            this.configureImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.configureImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configureImageLabel.ForeColor = System.Drawing.Color.White;
            this.configureImageLabel.Location = new System.Drawing.Point(12, 25);
            this.configureImageLabel.Name = "configureImageLabel";
            this.configureImageLabel.Size = new System.Drawing.Size(129, 16);
            this.configureImageLabel.TabIndex = 0;
            this.configureImageLabel.Text = "Configure Canvas";
            // 
            // registerColorButton
            // 
            this.registerColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.registerColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.registerColorButton.Location = new System.Drawing.Point(16, 118);
            this.registerColorButton.Name = "registerColorButton";
            this.registerColorButton.Size = new System.Drawing.Size(23, 23);
            this.registerColorButton.TabIndex = 5;
            this.registerColorButton.Text = "+";
            this.registerColorButton.UseVisualStyleBackColor = false;
            this.registerColorButton.Click += new System.EventHandler(this.registerColorButton_Click);
            // 
            // finalizeColorsButton
            // 
            this.finalizeColorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.finalizeColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizeColorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.finalizeColorsButton.Location = new System.Drawing.Point(85, 138);
            this.finalizeColorsButton.Name = "finalizeColorsButton";
            this.finalizeColorsButton.Size = new System.Drawing.Size(90, 26);
            this.finalizeColorsButton.TabIndex = 8;
            this.finalizeColorsButton.Text = "Save";
            this.finalizeColorsButton.UseVisualStyleBackColor = false;
            this.finalizeColorsButton.Click += new System.EventHandler(this.finalizeColorsButton_Click);
            // 
            // finalizeColorsBox
            // 
            this.finalizeColorsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.finalizeColorsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalizeColorsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.finalizeColorsBox.Location = new System.Drawing.Point(85, 118);
            this.finalizeColorsBox.Name = "finalizeColorsBox";
            this.finalizeColorsBox.Size = new System.Drawing.Size(90, 20);
            this.finalizeColorsBox.TabIndex = 7;
            this.finalizeColorsBox.Tag = "";
            // 
            // loadColorsButton
            // 
            this.loadColorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.loadColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadColorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.loadColorsButton.Location = new System.Drawing.Point(16, 340);
            this.loadColorsButton.Name = "loadColorsButton";
            this.loadColorsButton.Size = new System.Drawing.Size(44, 21);
            this.loadColorsButton.TabIndex = 10;
            this.loadColorsButton.Text = "Load";
            this.loadColorsButton.UseVisualStyleBackColor = false;
            this.loadColorsButton.Click += new System.EventHandler(this.loadColorsButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.speedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.speedBox.Location = new System.Drawing.Point(147, 208);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(28, 20);
            this.speedBox.TabIndex = 14;
            this.speedBox.Text = "50";
            this.speedBox.TextChanged += new System.EventHandler(this.speedBox_TextChanged);
            // 
            // qualityBox
            // 
            this.qualityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.qualityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qualityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.qualityBox.Location = new System.Drawing.Point(112, 208);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(28, 20);
            this.qualityBox.TabIndex = 12;
            this.qualityBox.Text = "50";
            this.qualityBox.TextChanged += new System.EventHandler(this.qualityBox_TextChanged);
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.BackColor = System.Drawing.Color.Transparent;
            this.qualityLabel.ForeColor = System.Drawing.Color.White;
            this.qualityLabel.Location = new System.Drawing.Point(108, 194);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(39, 13);
            this.qualityLabel.TabIndex = 0;
            this.qualityLabel.Text = "Quality";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(143, 194);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Speed";
            // 
            // qualityBar
            // 
            this.qualityBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.qualityBar.Location = new System.Drawing.Point(110, 228);
            this.qualityBar.Maximum = 100;
            this.qualityBar.Name = "qualityBar";
            this.qualityBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.qualityBar.Size = new System.Drawing.Size(45, 90);
            this.qualityBar.TabIndex = 13;
            this.qualityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.qualityBar.Value = 50;
            this.qualityBar.Scroll += new System.EventHandler(this.qualityBar_Scroll);
            // 
            // speedBar
            // 
            this.speedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.speedBar.Location = new System.Drawing.Point(145, 228);
            this.speedBar.Maximum = 100;
            this.speedBar.Name = "speedBar";
            this.speedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speedBar.Size = new System.Drawing.Size(45, 90);
            this.speedBar.TabIndex = 15;
            this.speedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedBar.Value = 50;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // colorsList
            // 
            this.colorsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.colorsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.colorsList.FormattingEnabled = true;
            this.colorsList.Location = new System.Drawing.Point(16, 208);
            this.colorsList.Name = "colorsList";
            this.colorsList.Size = new System.Drawing.Size(92, 132);
            this.colorsList.TabIndex = 9;
            // 
            // undoColorButton
            // 
            this.undoColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.undoColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.undoColorButton.Location = new System.Drawing.Point(16, 141);
            this.undoColorButton.Name = "undoColorButton";
            this.undoColorButton.Size = new System.Drawing.Size(23, 23);
            this.undoColorButton.TabIndex = 6;
            this.undoColorButton.Text = "x";
            this.undoColorButton.UseVisualStyleBackColor = false;
            this.undoColorButton.Click += new System.EventHandler(this.undoColorButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.colorLabel.Location = new System.Drawing.Point(36, 173);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(36, 12);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "(0, 0, 0)";
            // 
            // colorSquare
            // 
            this.colorSquare.BackColor = System.Drawing.Color.Black;
            this.colorSquare.Location = new System.Drawing.Point(39, 118);
            this.colorSquare.Name = "colorSquare";
            this.colorSquare.Size = new System.Drawing.Size(46, 46);
            this.colorSquare.TabIndex = 0;
            // 
            // colorIndexLabel
            // 
            this.colorIndexLabel.AutoSize = true;
            this.colorIndexLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorIndexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.colorIndexLabel.Location = new System.Drawing.Point(36, 164);
            this.colorIndexLabel.Name = "colorIndexLabel";
            this.colorIndexLabel.Size = new System.Drawing.Size(34, 12);
            this.colorIndexLabel.TabIndex = 0;
            this.colorIndexLabel.Text = "Color 0";
            // 
            // deleteColorsButton
            // 
            this.deleteColorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.deleteColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteColorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.deleteColorsButton.Location = new System.Drawing.Point(60, 340);
            this.deleteColorsButton.Name = "deleteColorsButton";
            this.deleteColorsButton.Size = new System.Drawing.Size(48, 21);
            this.deleteColorsButton.TabIndex = 11;
            this.deleteColorsButton.Text = "Delete";
            this.deleteColorsButton.UseVisualStyleBackColor = false;
            this.deleteColorsButton.Click += new System.EventHandler(this.deleteColorsButton_Click);
            // 
            // createPresetLabel
            // 
            this.createPresetLabel.AutoSize = true;
            this.createPresetLabel.BackColor = System.Drawing.Color.Transparent;
            this.createPresetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPresetLabel.ForeColor = System.Drawing.Color.White;
            this.createPresetLabel.Location = new System.Drawing.Point(12, 101);
            this.createPresetLabel.Name = "createPresetLabel";
            this.createPresetLabel.Size = new System.Drawing.Size(102, 16);
            this.createPresetLabel.TabIndex = 0;
            this.createPresetLabel.Text = "Create Preset";
            // 
            // loadPresetLabel
            // 
            this.loadPresetLabel.AutoSize = true;
            this.loadPresetLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadPresetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPresetLabel.ForeColor = System.Drawing.Color.White;
            this.loadPresetLabel.Location = new System.Drawing.Point(12, 192);
            this.loadPresetLabel.Name = "loadPresetLabel";
            this.loadPresetLabel.Size = new System.Drawing.Size(91, 16);
            this.loadPresetLabel.TabIndex = 0;
            this.loadPresetLabel.Text = "Load Preset";
            // 
            // loadImageButton
            // 
            this.loadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.loadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.loadImageButton.Location = new System.Drawing.Point(16, 41);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(44, 20);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "Select";
            this.loadImageButton.UseVisualStyleBackColor = false;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "Image";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.imageLabel.Location = new System.Drawing.Point(13, 80);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(37, 12);
            this.imageLabel.TabIndex = 0;
            this.imageLabel.Text = "IMAGE";
            this.imageLabel.TextChanged += new System.EventHandler(this.imageLabel_TextChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.infoLabel.Location = new System.Drawing.Point(32, 428);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(121, 12);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "DrawBot v0.0.0 by o7q";
            // 
            // loadURLImageBox
            // 
            this.loadURLImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.loadURLImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadURLImageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.loadURLImageBox.Location = new System.Drawing.Point(16, 61);
            this.loadURLImageBox.Name = "loadURLImageBox";
            this.loadURLImageBox.Size = new System.Drawing.Size(83, 20);
            this.loadURLImageBox.TabIndex = 2;
            this.loadURLImageBox.TextChanged += new System.EventHandler(this.loadURLImageBox_TextChanged);
            // 
            // urlNoticeLabel
            // 
            this.urlNoticeLabel.AutoSize = true;
            this.urlNoticeLabel.BackColor = System.Drawing.Color.Transparent;
            this.urlNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlNoticeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.urlNoticeLabel.Location = new System.Drawing.Point(61, 47);
            this.urlNoticeLabel.Name = "urlNoticeLabel";
            this.urlNoticeLabel.Size = new System.Drawing.Size(37, 12);
            this.urlNoticeLabel.TabIndex = 0;
            this.urlNoticeLabel.Text = "or URL:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.BackColor = System.Drawing.Color.Transparent;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.areaLabel.Location = new System.Drawing.Point(97, 80);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(26, 12);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Size:";
            // 
            // colorsLabel
            // 
            this.colorsLabel.AutoSize = true;
            this.colorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            this.colorsLabel.Location = new System.Drawing.Point(13, 361);
            this.colorsLabel.Name = "colorsLabel";
            this.colorsLabel.Size = new System.Drawing.Size(41, 12);
            this.colorsLabel.TabIndex = 0;
            this.colorsLabel.Text = "PRESET";
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.titlebarPanel.Controls.Add(this.titlebarLabel);
            this.titlebarPanel.Controls.Add(this.closeButton);
            this.titlebarPanel.Location = new System.Drawing.Point(-4, -3);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(194, 20);
            this.titlebarPanel.TabIndex = 0;
            this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPanel_MouseDown);
            // 
            // titlebarLabel
            // 
            this.titlebarLabel.AutoSize = true;
            this.titlebarLabel.BackColor = System.Drawing.Color.Transparent;
            this.titlebarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.titlebarLabel.Location = new System.Drawing.Point(9, 5);
            this.titlebarLabel.Name = "titlebarLabel";
            this.titlebarLabel.Size = new System.Drawing.Size(95, 13);
            this.titlebarLabel.TabIndex = 0;
            this.titlebarLabel.Text = "DrawBot v0.0.0";
            this.titlebarLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarLabel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.closeButton.Location = new System.Drawing.Point(176, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.sidebarPanel.Location = new System.Drawing.Point(-4, -4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(7, 452);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidebarPanel_MouseDown);
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.algorithmComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algorithmComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Items.AddRange(new object[] {
            "Strips (quality)",
            "Blobs (fast)"});
            this.algorithmComboBox.Location = new System.Drawing.Point(108, 340);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(67, 20);
            this.algorithmComboBox.TabIndex = 17;
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.BackColor = System.Drawing.Color.Transparent;
            this.algorithmLabel.ForeColor = System.Drawing.Color.White;
            this.algorithmLabel.Location = new System.Drawing.Point(108, 327);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(71, 13);
            this.algorithmLabel.TabIndex = 0;
            this.algorithmLabel.Text = "Draw Method";
            // 
            // luminanceFixCheckBox
            // 
            this.luminanceFixCheckBox.AutoSize = true;
            this.luminanceFixCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.luminanceFixCheckBox.Checked = true;
            this.luminanceFixCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.luminanceFixCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.luminanceFixCheckBox.Location = new System.Drawing.Point(112, 312);
            this.luminanceFixCheckBox.Name = "luminanceFixCheckBox";
            this.luminanceFixCheckBox.Size = new System.Drawing.Size(68, 17);
            this.luminanceFixCheckBox.TabIndex = 16;
            this.luminanceFixCheckBox.Text = "Fix Luma";
            this.luminanceFixCheckBox.UseVisualStyleBackColor = false;
            this.luminanceFixCheckBox.CheckedChanged += new System.EventHandler(this.luminanceFixCheckBox_CheckedChanged_1);
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::DrawBot.Properties.Resources.background_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(188, 446);
            this.Controls.Add(this.luminanceFixCheckBox);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.algorithmComboBox);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.titlebarPanel);
            this.Controls.Add(this.colorsLabel);
            this.Controls.Add(this.urlNoticeLabel);
            this.Controls.Add(this.loadURLImageBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.loadPresetLabel);
            this.Controls.Add(this.createPresetLabel);
            this.Controls.Add(this.deleteColorsButton);
            this.Controls.Add(this.colorIndexLabel);
            this.Controls.Add(this.colorSquare);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.undoColorButton);
            this.Controls.Add(this.colorsList);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.qualityBar);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.qualityBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.loadColorsButton);
            this.Controls.Add(this.finalizeColorsBox);
            this.Controls.Add(this.finalizeColorsButton);
            this.Controls.Add(this.registerColorButton);
            this.Controls.Add(this.configureImageLabel);
            this.Controls.Add(this.boundsLabel);
            this.Controls.Add(this.pos2Label);
            this.Controls.Add(this.pos1Label);
            this.Controls.Add(this.regionEndButton);
            this.Controls.Add(this.regionStartButton);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "program";
            this.Text = "DrawBot";
            this.Load += new System.EventHandler(this.program_Load);
            this.MouseEnter += new System.EventHandler(this.program_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button regionStartButton;
        private System.Windows.Forms.Button regionEndButton;
        private System.Windows.Forms.Label pos1Label;
        private System.Windows.Forms.Label pos2Label;
        private System.Windows.Forms.Label boundsLabel;
        private System.Windows.Forms.Label configureImageLabel;
        private System.Windows.Forms.Button registerColorButton;
        private System.Windows.Forms.Button finalizeColorsButton;
        private System.Windows.Forms.TextBox finalizeColorsBox;
        private System.Windows.Forms.Button loadColorsButton;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox qualityBox;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TrackBar qualityBar;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.ListBox colorsList;
        private System.Windows.Forms.Button undoColorButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Panel colorSquare;
        private System.Windows.Forms.Label colorIndexLabel;
        private System.Windows.Forms.Button deleteColorsButton;
        private System.Windows.Forms.Label createPresetLabel;
        private System.Windows.Forms.Label loadPresetLabel;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox loadURLImageBox;
        private System.Windows.Forms.Label urlNoticeLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label colorsLabel;
        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label titlebarLabel;
        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.CheckBox luminanceFixCheckBox;
    }
}

