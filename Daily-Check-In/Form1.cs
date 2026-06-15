using System.Text.Json;

namespace Daily_Check_In
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AppData appData = new AppData();

        private System.Windows.Forms.Timer fiveSecondTimer;

        public bool isSettingsOpen = false;

        private Form2 form2;


        // Constant values
        private string dataPath = "data.json";

        Color checkedColor = ColorTranslator.FromHtml("#f57538"); //orange
        Color darkBackColor = ColorTranslator.FromHtml("#292c45"); //dark grey blue

        // Internal variables
        Color backColor = SystemColors.Control;
        Color foreColor = SystemColors.ControlText;

        int days = 0, totalDays = 0, pauseCount = 0;
        int[] weekStat = { 0, 0, 0, 0, 0 }; // 0:null 1:check 2:pause
        bool isChecked = false;

        public void LoadData()
        {
            try
            {
                if (File.Exists(dataPath))
                {
                    string jsonString = File.ReadAllText(dataPath);
                    appData = JsonSerializer.Deserialize<AppData>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                appData = new AppData();
            }

            days = appData.days;
            totalDays = appData.totalDays;
            pauseCount = appData.pauseCount;
            weekStat = appData.weekStat;
            isChecked = appData.isChecked;
        }

        public void SaveData()
        {
            try
            {
                // data
                appData.days = days;
                appData.totalDays = totalDays;
                appData.pauseCount = pauseCount;
                appData.weekStat = weekStat;
                appData.isChecked = isChecked;

                //appData.date = DateTime.Today;

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(appData, options);
                File.WriteAllText(dataPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // form load //////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            if (totalDays == 0)
            {
                pauseButton.Enabled = false;
            }

            if (isChecked)
            {
                checkInButton.Enabled = false;
                pauseButton.Enabled = false;
            }

            CheckDate(sender,e);

            fiveSecondTimer = new System.Windows.Forms.Timer();
            fiveSecondTimer.Interval = 5000;
            fiveSecondTimer.Tick += CheckDate;
            fiveSecondTimer.Start();

            UpdateScreen();
            UpdateAppearance();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            days++;

            for (int i = 0; i < 5; i++)
            {
                if (weekStat[i] == 0)
                {
                    weekStat[i] = 1;
                    break;
                }
            }

            pauseCount = 0;

            isChecked = true;
            streakDays.ForeColor = checkedColor;

            appData.date = DateTime.Today;

            SaveData();
            UpdateScreen();
            UpdateAppearance();
            checkInButton.Enabled = false;
            pauseButton.Enabled = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (weekStat[i] == 0)
                {
                    weekStat[i] = 2;
                    break;
                }
            }

            pauseCount++;

            if (pauseCount == appData.maxPauseDays + 1)
            {
                ResetStreak();
                return;
            }

            isChecked = true;
            streakDays.ForeColor = checkedColor;

            appData.date = DateTime.Today;

            SaveData();
            UpdateScreen();
            UpdateAppearance();
            checkInButton.Enabled = false;
            pauseButton.Enabled = false;
        }

        private void CheckDate(object sender, EventArgs e)
        {
            if(DateTime.Today.Day > appData.date.Day)
            {
                int daysPassed = DateTime.Today.Day - appData.date.Day;

                for (int i = 0; i < daysPassed; i++)
                {
                    NextDay();
                }
            }
        }

        private void NextDay()
        {
            if (weekStat[0] == 0)
                return;

            totalDays++;

            if (!isChecked)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (weekStat[i] == 0)
                    {
                        weekStat[i] = 2; // pause
                        pauseCount++;
                        break;
                    }
                }
            }

            // push list backward
            if (totalDays >= 5)
            {
                for (int i = 0; i < 4; i++)
                    weekStat[i] = (weekStat[i + 1]);
                weekStat[4] = 0;
            }

            if (pauseCount == appData.maxPauseDays + 1)
            {
                ResetStreak();
                return;
            }

            isChecked = false;

            appData.date = DateTime.Today;

            SaveData();
            UpdateScreen();
            UpdateAppearance();
            checkInButton.Enabled = true;
            pauseButton.Enabled = true;
        }

        public void ResetStreak()
        {
            days = totalDays = pauseCount = 0;
            weekStat = [0, 0, 0, 0, 0];
            isChecked = false;

            SaveData();
            UpdateScreen();
            UpdateAppearance();
            checkInButton.Enabled = true;
            pauseButton.Enabled = false;
        }

        public void UpdateScreen()
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            streakDays.Text = $"{days}";

            for (int i = 0; i < 5; i++)
            {
                if (weekStat[i] == 1) pictureBoxes[i].Image = Properties.Resources.check;
                else if (weekStat[i] == 2) pictureBoxes[i].Image = Properties.Resources.pause;
                else 
                {
                    if (appData.isDarkMode)
                    {
                        pictureBoxes[i].Image = Properties.Resources.white_blank___Copy;
                    }
                    else
                    {
                        pictureBoxes[i].Image = Properties.Resources.black_blank___Copy;
                    }
                }

            }
        }

        public void UpdateAppearance()
        {
            titleName.Text = appData.title;
            titleName.Location = new Point((this.ClientSize.Width - titleName.Width) / 2, 40);
            streakDays.Location = new Point((this.ClientSize.Width - streakDays.Width) / 2, 95);
            label1.Location = new Point(((this.ClientSize.Width) / 2 + (streakDays.Width) / 2) - 25, 153);

            if (appData.isDarkMode)
            {
                backColor = darkBackColor;
                foreColor = Color.White;
            }
            else
            {
                backColor = SystemColors.Control;
                foreColor = SystemColors.ControlText;
            }

            if (isChecked)
                streakDays.ForeColor = checkedColor;
            else
                streakDays.ForeColor = foreColor;

            this.BackColor = backColor;
            this.ForeColor = foreColor;
        }

        public void LoadConfig()
        {
            LoadData();
            UpdateAppearance();
            UpdateScreen();

            if (weekStat[0] == 0)
            {
                checkInButton.Enabled = true;
                pauseButton.Enabled = false;
            }
            else
            {
                if (isChecked)
                {
                    checkInButton.Enabled = false;
                    pauseButton.Enabled= false;
                }
                else
                {
                    checkInButton.Enabled = true;
                    pauseButton.Enabled = true;
                }
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (isSettingsOpen)
            {
                form2.Close();
                return;
            }

            form2 = new Form2();
            form2.form1 = this;

            isSettingsOpen = true;
            form2.Show(this);
        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.gears_hover;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.gears;
        }


        // Debug features /////////////////

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12) // Debug
            {
                debug_tomorrowButton.Visible = true;
                debug_appearanceButton.Visible = true;
                debug_screenButton.Visible = true;
                debug_saveButton.Visible = true;
                debug_loadButton.Visible = true;
            }
        }

        private void debug_tomorrowButton_Click(object sender, EventArgs e)
        {
            NextDay();
        }

        private void debug_appearanceButton_Click(object sender, EventArgs e)
        {
            UpdateAppearance();
        }

        private void debug_screenButton_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void debug_saveButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void debug_loadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
