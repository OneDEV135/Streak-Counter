namespace Daily_Check_In
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            titleInput = new TextBox();
            label1 = new Label();
            maxPauseInput = new NumericUpDown();
            applyButton = new Button();
            okButton = new Button();
            cancelButton = new Button();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            resetDataButton = new Button();
            resetSettingsButton = new Button();
            label6 = new Label();
            label5 = new Label();
            resetStreakButton = new Button();
            exportButton = new Button();
            importButton = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            darkCheck = new CheckBox();
            tabPage3 = new TabPage();
            label9 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)maxPauseInput).BeginInit();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleInput
            // 
            titleInput.Location = new Point(6, 60);
            titleInput.MaxLength = 20;
            titleInput.Name = "titleInput";
            titleInput.PlaceholderText = "Title here";
            titleInput.Size = new Size(294, 23);
            titleInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(297, 30);
            label1.TabIndex = 2;
            label1.Text = "Enter how many days paused/missed before the streak \r\nresets. ";
            // 
            // maxPauseInput
            // 
            maxPauseInput.Location = new Point(50, 66);
            maxPauseInput.Name = "maxPauseInput";
            maxPauseInput.Size = new Size(98, 23);
            maxPauseInput.TabIndex = 3;
            maxPauseInput.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // applyButton
            // 
            applyButton.Location = new Point(263, 372);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 7;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(101, 372);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 8;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(182, 372);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(318, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Streak";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(maxPauseInput);
            groupBox2.Location = new Point(6, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 127);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Max pause days";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Days: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(titleInput);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 89);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(213, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter a new title for the streak counter. ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(326, 354);
            tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(318, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Application";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(resetDataButton);
            groupBox4.Controls.Add(resetSettingsButton);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(resetStreakButton);
            groupBox4.Controls.Add(exportButton);
            groupBox4.Controls.Add(importButton);
            groupBox4.Location = new Point(6, 112);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(306, 152);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "System";
            // 
            // resetDataButton
            // 
            resetDataButton.ForeColor = Color.Red;
            resetDataButton.Location = new Point(206, 102);
            resetDataButton.Name = "resetDataButton";
            resetDataButton.Size = new Size(93, 23);
            resetDataButton.TabIndex = 15;
            resetDataButton.Text = "Reset data";
            resetDataButton.UseVisualStyleBackColor = true;
            resetDataButton.Click += resetDataButton_Click;
            // 
            // resetSettingsButton
            // 
            resetSettingsButton.ForeColor = Color.Red;
            resetSettingsButton.Location = new Point(107, 102);
            resetSettingsButton.Name = "resetSettingsButton";
            resetSettingsButton.Size = new Size(93, 23);
            resetSettingsButton.TabIndex = 14;
            resetSettingsButton.Text = "Reset settings";
            resetSettingsButton.UseVisualStyleBackColor = true;
            resetSettingsButton.Click += resetSettingsButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 80);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 13;
            label6.Text = "Reset data or settings. ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(192, 15);
            label5.TabIndex = 12;
            label5.Text = "Import or export data and settings. ";
            // 
            // resetStreakButton
            // 
            resetStreakButton.ForeColor = Color.Red;
            resetStreakButton.Location = new Point(6, 102);
            resetStreakButton.Name = "resetStreakButton";
            resetStreakButton.Size = new Size(95, 23);
            resetStreakButton.TabIndex = 11;
            resetStreakButton.Text = "Reset streak";
            resetStreakButton.UseVisualStyleBackColor = true;
            resetStreakButton.Click += resetStreakButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(87, 42);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 10;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(6, 42);
            importButton.Name = "importButton";
            importButton.Size = new Size(75, 23);
            importButton.TabIndex = 9;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(darkCheck);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 100);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Appearance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(234, 15);
            label4.TabIndex = 9;
            label4.Text = "Change the appearance of the application. ";
            // 
            // darkCheck
            // 
            darkCheck.AutoSize = true;
            darkCheck.Location = new Point(8, 44);
            darkCheck.Name = "darkCheck";
            darkCheck.Size = new Size(84, 19);
            darkCheck.TabIndex = 8;
            darkCheck.Text = "Dark mode";
            darkCheck.UseVisualStyleBackColor = true;
            darkCheck.CheckedChanged += darkCheck_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(linkLabel2);
            tabPage3.Controls.Add(linkLabel1);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(pictureBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(318, 326);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "About";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 100);
            label9.Name = "label9";
            label9.Size = new Size(300, 15);
            label9.TabIndex = 5;
            label9.Text = "Icons and images from Microsoft Windows 11 emoji set";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(6, 159);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(160, 15);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://onedev135.github.io/";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(6, 130);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(265, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/OneDEV135/Streak-Counter/";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 301);
            label8.Name = "label8";
            label8.Size = new Size(176, 15);
            label8.TabIndex = 2;
            label8.Text = "Made with ❤️ in Taiwan by 嘻嘻";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 17);
            label7.Name = "label7";
            label7.Size = new Size(85, 30);
            label7.TabIndex = 1;
            label7.Text = "Streak Counter\r\nv.1.0.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fire;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "data.json";
            openFileDialog1.Filter = "JSON File | .json";
            openFileDialog1.Title = "Import data";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "data.json";
            saveFileDialog1.Filter = "JSON File | .json";
            saveFileDialog1.Title = "Export data";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 407);
            Controls.Add(tabControl1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(applyButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Streak Counter Settings";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)maxPauseInput).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox titleInput;
        private Label label1;
        private NumericUpDown maxPauseInput;
        private Button applyButton;
        private Button okButton;
        private Button cancelButton;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TabPage tabPage2;
        private Button resetStreakButton;
        private Button importButton;
        private CheckBox darkCheck;
        private Button exportButton;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox4;
        private Label label5;
        private GroupBox groupBox3;
        private Label label4;
        private Button resetSettingsButton;
        private Label label6;
        private TabPage tabPage3;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label9;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label8;
        private Button resetDataButton;
    }
}