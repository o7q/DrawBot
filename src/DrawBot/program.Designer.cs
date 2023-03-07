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
            this.resetColorsButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(6, 291);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 50);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Draw";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // regionStartButton
            // 
            this.regionStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionStartButton.Location = new System.Drawing.Point(95, 25);
            this.regionStartButton.Name = "regionStartButton";
            this.regionStartButton.Size = new System.Drawing.Size(24, 20);
            this.regionStartButton.TabIndex = 2;
            this.regionStartButton.Text = "P1";
            this.regionStartButton.UseVisualStyleBackColor = true;
            this.regionStartButton.Click += new System.EventHandler(this.regionStartButton_Click);
            // 
            // regionEndButton
            // 
            this.regionEndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionEndButton.Location = new System.Drawing.Point(95, 44);
            this.regionEndButton.Name = "regionEndButton";
            this.regionEndButton.Size = new System.Drawing.Size(24, 20);
            this.regionEndButton.TabIndex = 3;
            this.regionEndButton.Text = "P2";
            this.regionEndButton.UseVisualStyleBackColor = true;
            this.regionEndButton.Click += new System.EventHandler(this.regionEndButton_Click);
            // 
            // pos1Label
            // 
            this.pos1Label.AutoSize = true;
            this.pos1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos1Label.Location = new System.Drawing.Point(118, 28);
            this.pos1Label.Name = "pos1Label";
            this.pos1Label.Size = new System.Drawing.Size(26, 12);
            this.pos1Label.TabIndex = 0;
            this.pos1Label.Text = "(0, 0)";
            // 
            // pos2Label
            // 
            this.pos2Label.AutoSize = true;
            this.pos2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos2Label.Location = new System.Drawing.Point(118, 47);
            this.pos2Label.Name = "pos2Label";
            this.pos2Label.Size = new System.Drawing.Size(26, 12);
            this.pos2Label.TabIndex = 0;
            this.pos2Label.Text = "(0, 0)";
            // 
            // boundsLabel
            // 
            this.boundsLabel.AutoSize = true;
            this.boundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundsLabel.Location = new System.Drawing.Point(117, 64);
            this.boundsLabel.Name = "boundsLabel";
            this.boundsLabel.Size = new System.Drawing.Size(32, 12);
            this.boundsLabel.TabIndex = 0;
            this.boundsLabel.Text = "(0, 0)";
            // 
            // configureImageLabel
            // 
            this.configureImageLabel.AutoSize = true;
            this.configureImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configureImageLabel.Location = new System.Drawing.Point(3, 9);
            this.configureImageLabel.Name = "configureImageLabel";
            this.configureImageLabel.Size = new System.Drawing.Size(129, 16);
            this.configureImageLabel.TabIndex = 0;
            this.configureImageLabel.Text = "Configure Canvas";
            // 
            // registerColorButton
            // 
            this.registerColorButton.Location = new System.Drawing.Point(6, 101);
            this.registerColorButton.Name = "registerColorButton";
            this.registerColorButton.Size = new System.Drawing.Size(69, 26);
            this.registerColorButton.TabIndex = 4;
            this.registerColorButton.Text = "Add Color";
            this.registerColorButton.UseVisualStyleBackColor = true;
            this.registerColorButton.Click += new System.EventHandler(this.registerColorButton_Click);
            // 
            // finalizeColorsButton
            // 
            this.finalizeColorsButton.Location = new System.Drawing.Point(74, 127);
            this.finalizeColorsButton.Name = "finalizeColorsButton";
            this.finalizeColorsButton.Size = new System.Drawing.Size(43, 22);
            this.finalizeColorsButton.TabIndex = 7;
            this.finalizeColorsButton.Text = "Save";
            this.finalizeColorsButton.UseVisualStyleBackColor = true;
            this.finalizeColorsButton.Click += new System.EventHandler(this.finalizeColorsButton_Click);
            // 
            // finalizeColorsBox
            // 
            this.finalizeColorsBox.Location = new System.Drawing.Point(7, 128);
            this.finalizeColorsBox.Name = "finalizeColorsBox";
            this.finalizeColorsBox.Size = new System.Drawing.Size(67, 20);
            this.finalizeColorsBox.TabIndex = 6;
            this.finalizeColorsBox.Tag = "";
            // 
            // loadColorsButton
            // 
            this.loadColorsButton.Location = new System.Drawing.Point(6, 264);
            this.loadColorsButton.Name = "loadColorsButton";
            this.loadColorsButton.Size = new System.Drawing.Size(40, 21);
            this.loadColorsButton.TabIndex = 11;
            this.loadColorsButton.Text = "Load";
            this.loadColorsButton.UseVisualStyleBackColor = true;
            this.loadColorsButton.Click += new System.EventHandler(this.loadColorsButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(131, 169);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(32, 20);
            this.speedBox.TabIndex = 15;
            this.speedBox.Text = "50";
            this.speedBox.TextChanged += new System.EventHandler(this.speedBox_TextChanged);
            // 
            // qualityBox
            // 
            this.qualityBox.Location = new System.Drawing.Point(95, 169);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(32, 20);
            this.qualityBox.TabIndex = 13;
            this.qualityBox.Text = "50";
            this.qualityBox.TextChanged += new System.EventHandler(this.qualityBox_TextChanged);
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(91, 155);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(39, 13);
            this.qualityLabel.TabIndex = 0;
            this.qualityLabel.Text = "Quality";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(127, 155);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Speed";
            // 
            // qualityBar
            // 
            this.qualityBar.Location = new System.Drawing.Point(93, 189);
            this.qualityBar.Maximum = 100;
            this.qualityBar.Name = "qualityBar";
            this.qualityBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.qualityBar.Size = new System.Drawing.Size(45, 100);
            this.qualityBar.TabIndex = 14;
            this.qualityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.qualityBar.Value = 50;
            this.qualityBar.Scroll += new System.EventHandler(this.qualityBar_Scroll);
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(129, 189);
            this.speedBar.Maximum = 100;
            this.speedBar.Name = "speedBar";
            this.speedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speedBar.Size = new System.Drawing.Size(45, 100);
            this.speedBar.TabIndex = 16;
            this.speedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedBar.Value = 50;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // colorsList
            // 
            this.colorsList.FormattingEnabled = true;
            this.colorsList.Location = new System.Drawing.Point(7, 169);
            this.colorsList.Name = "colorsList";
            this.colorsList.Size = new System.Drawing.Size(83, 95);
            this.colorsList.TabIndex = 10;
            // 
            // resetColorsButton
            // 
            this.resetColorsButton.Location = new System.Drawing.Point(74, 101);
            this.resetColorsButton.Name = "resetColorsButton";
            this.resetColorsButton.Size = new System.Drawing.Size(43, 26);
            this.resetColorsButton.TabIndex = 5;
            this.resetColorsButton.Text = "Reset";
            this.resetColorsButton.UseVisualStyleBackColor = true;
            this.resetColorsButton.Click += new System.EventHandler(this.resetColorsButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(115, 89);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(36, 12);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "(0, 0, 0)";
            // 
            // colorSquare
            // 
            this.colorSquare.BackColor = System.Drawing.Color.Black;
            this.colorSquare.Location = new System.Drawing.Point(117, 102);
            this.colorSquare.Name = "colorSquare";
            this.colorSquare.Size = new System.Drawing.Size(46, 46);
            this.colorSquare.TabIndex = 0;
            // 
            // colorIndexLabel
            // 
            this.colorIndexLabel.AutoSize = true;
            this.colorIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorIndexLabel.Location = new System.Drawing.Point(115, 80);
            this.colorIndexLabel.Name = "colorIndexLabel";
            this.colorIndexLabel.Size = new System.Drawing.Size(34, 12);
            this.colorIndexLabel.TabIndex = 0;
            this.colorIndexLabel.Text = "Color 0";
            // 
            // deleteColorsButton
            // 
            this.deleteColorsButton.Location = new System.Drawing.Point(45, 264);
            this.deleteColorsButton.Name = "deleteColorsButton";
            this.deleteColorsButton.Size = new System.Drawing.Size(46, 21);
            this.deleteColorsButton.TabIndex = 12;
            this.deleteColorsButton.Text = "Delete";
            this.deleteColorsButton.UseVisualStyleBackColor = true;
            this.deleteColorsButton.Click += new System.EventHandler(this.deleteColorsButton_Click);
            // 
            // createPresetLabel
            // 
            this.createPresetLabel.AutoSize = true;
            this.createPresetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPresetLabel.Location = new System.Drawing.Point(4, 86);
            this.createPresetLabel.Name = "createPresetLabel";
            this.createPresetLabel.Size = new System.Drawing.Size(102, 16);
            this.createPresetLabel.TabIndex = 0;
            this.createPresetLabel.Text = "Create Preset";
            // 
            // loadPresetLabel
            // 
            this.loadPresetLabel.AutoSize = true;
            this.loadPresetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPresetLabel.Location = new System.Drawing.Point(3, 153);
            this.loadPresetLabel.Name = "loadPresetLabel";
            this.loadPresetLabel.Size = new System.Drawing.Size(91, 16);
            this.loadPresetLabel.TabIndex = 0;
            this.loadPresetLabel.Text = "Load Preset";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(6, 25);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(46, 20);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Select";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "Image";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.Location = new System.Drawing.Point(4, 64);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(37, 12);
            this.imageLabel.TabIndex = 0;
            this.imageLabel.Text = "IMAGE";
            this.imageLabel.TextChanged += new System.EventHandler(this.imageLabel_TextChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.infoLabel.Location = new System.Drawing.Point(23, 340);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(121, 12);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "DrawBot v0.0.0 by o7q";
            // 
            // loadURLImageBox
            // 
            this.loadURLImageBox.Location = new System.Drawing.Point(7, 45);
            this.loadURLImageBox.Name = "loadURLImageBox";
            this.loadURLImageBox.Size = new System.Drawing.Size(83, 20);
            this.loadURLImageBox.TabIndex = 1;
            this.loadURLImageBox.TextChanged += new System.EventHandler(this.loadURLImageBox_TextChanged);
            // 
            // urlNoticeLabel
            // 
            this.urlNoticeLabel.AutoSize = true;
            this.urlNoticeLabel.Location = new System.Drawing.Point(51, 31);
            this.urlNoticeLabel.Name = "urlNoticeLabel";
            this.urlNoticeLabel.Size = new System.Drawing.Size(44, 13);
            this.urlNoticeLabel.TabIndex = 0;
            this.urlNoticeLabel.Text = "or URL:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(91, 64);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(26, 12);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Size:";
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 357);
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
            this.Controls.Add(this.resetColorsButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "program";
            this.Text = "DrawBot";
            this.Load += new System.EventHandler(this.program_Load);
            this.MouseEnter += new System.EventHandler(this.program_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
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
        private System.Windows.Forms.Button resetColorsButton;
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
    }
}

