namespace Daily_Check_In
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titleName = new Label();
            streakDays = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            checkInButton = new Button();
            pauseButton = new Button();
            label1 = new Label();
            settingsButton = new PictureBox();
            debug_tomorrowButton = new Button();
            debug_appearanceButton = new Button();
            debug_screenButton = new Button();
            debug_saveButton = new Button();
            debug_loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsButton).BeginInit();
            SuspendLayout();
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.Font = new Font("Century Gothic", 26F);
            titleName.Location = new Point(303, 40);
            titleName.Name = "titleName";
            titleName.Size = new Size(169, 42);
            titleName.TabIndex = 0;
            titleName.Text = "Title here";
            // 
            // streakDays
            // 
            streakDays.AutoSize = true;
            streakDays.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            streakDays.Location = new Point(334, 95);
            streakDays.Name = "streakDays";
            streakDays.Size = new Size(101, 112);
            streakDays.TabIndex = 1;
            streakDays.Text = "0";
            streakDays.TextAlign = ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.black_blank;
            pictureBox1.Location = new Point(198, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.black_blank;
            pictureBox2.Location = new Point(282, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.black_blank;
            pictureBox3.Location = new Point(366, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.black_blank;
            pictureBox4.Location = new Point(450, 235);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 72);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.black_blank;
            pictureBox5.Location = new Point(534, 235);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(72, 72);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // checkInButton
            // 
            checkInButton.Cursor = Cursors.Hand;
            checkInButton.FlatAppearance.BorderColor = Color.Gray;
            checkInButton.FlatStyle = FlatStyle.Flat;
            checkInButton.Font = new Font("Century Gothic", 14F);
            checkInButton.Location = new Point(198, 368);
            checkInButton.Name = "checkInButton";
            checkInButton.Size = new Size(156, 57);
            checkInButton.TabIndex = 7;
            checkInButton.Text = "Check-in";
            checkInButton.UseVisualStyleBackColor = true;
            checkInButton.Click += checkInButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Cursor = Cursors.Hand;
            pauseButton.FlatAppearance.BorderColor = Color.Gray;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Font = new Font("Century Gothic", 14F);
            pauseButton.Location = new Point(450, 368);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(156, 57);
            pauseButton.TabIndex = 8;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 153);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 10;
            label1.Text = "Days";
            // 
            // settingsButton
            // 
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.Image = Properties.Resources.gears;
            settingsButton.Location = new Point(720, 429);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(38, 39);
            settingsButton.SizeMode = PictureBoxSizeMode.Zoom;
            settingsButton.TabIndex = 11;
            settingsButton.TabStop = false;
            settingsButton.Click += settingsButton_Click;
            settingsButton.MouseEnter += settingsButton_MouseEnter;
            settingsButton.MouseLeave += settingsButton_MouseLeave;
            // 
            // debug_tomorrowButton
            // 
            debug_tomorrowButton.ForeColor = Color.Black;
            debug_tomorrowButton.Location = new Point(1, 469);
            debug_tomorrowButton.Name = "debug_tomorrowButton";
            debug_tomorrowButton.Size = new Size(114, 23);
            debug_tomorrowButton.TabIndex = 12;
            debug_tomorrowButton.Text = "[Debug] tomorrow";
            debug_tomorrowButton.UseVisualStyleBackColor = true;
            debug_tomorrowButton.Visible = false;
            debug_tomorrowButton.Click += debug_tomorrowButton_Click;
            // 
            // debug_appearanceButton
            // 
            debug_appearanceButton.ForeColor = Color.Black;
            debug_appearanceButton.Location = new Point(108, 469);
            debug_appearanceButton.Name = "debug_appearanceButton";
            debug_appearanceButton.Size = new Size(162, 23);
            debug_appearanceButton.TabIndex = 13;
            debug_appearanceButton.Text = "[Debug] update appearance";
            debug_appearanceButton.UseVisualStyleBackColor = true;
            debug_appearanceButton.Visible = false;
            debug_appearanceButton.Click += debug_appearanceButton_Click;
            // 
            // debug_screenButton
            // 
            debug_screenButton.ForeColor = Color.Black;
            debug_screenButton.Location = new Point(267, 469);
            debug_screenButton.Name = "debug_screenButton";
            debug_screenButton.Size = new Size(137, 23);
            debug_screenButton.TabIndex = 14;
            debug_screenButton.Text = "[Debug] update screen";
            debug_screenButton.UseVisualStyleBackColor = true;
            debug_screenButton.Visible = false;
            debug_screenButton.Click += debug_screenButton_Click;
            // 
            // debug_saveButton
            // 
            debug_saveButton.ForeColor = Color.Black;
            debug_saveButton.Location = new Point(399, 469);
            debug_saveButton.Name = "debug_saveButton";
            debug_saveButton.Size = new Size(111, 23);
            debug_saveButton.TabIndex = 15;
            debug_saveButton.Text = "[Debug] save data";
            debug_saveButton.UseVisualStyleBackColor = true;
            debug_saveButton.Visible = false;
            debug_saveButton.Click += debug_saveButton_Click;
            // 
            // debug_loadButton
            // 
            debug_loadButton.ForeColor = Color.Black;
            debug_loadButton.Location = new Point(506, 469);
            debug_loadButton.Name = "debug_loadButton";
            debug_loadButton.Size = new Size(111, 23);
            debug_loadButton.TabIndex = 16;
            debug_loadButton.Text = "[Debug] load data";
            debug_loadButton.UseVisualStyleBackColor = true;
            debug_loadButton.Visible = false;
            debug_loadButton.Click += debug_loadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(debug_loadButton);
            Controls.Add(debug_saveButton);
            Controls.Add(debug_screenButton);
            Controls.Add(debug_appearanceButton);
            Controls.Add(debug_tomorrowButton);
            Controls.Add(settingsButton);
            Controls.Add(label1);
            Controls.Add(titleName);
            Controls.Add(pauseButton);
            Controls.Add(checkInButton);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(streakDays);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Streak Counter";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleName;
        private Label streakDays;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button checkInButton;
        private Button pauseButton;
        private Label label1;
        private PictureBox settingsButton;
        private Button debug_tomorrowButton;
        private Button debug_appearanceButton;
        private Button debug_screenButton;
        private Button debug_saveButton;
        private Button debug_loadButton;
    }
}
