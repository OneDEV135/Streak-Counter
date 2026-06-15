using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Daily_Check_In
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        private AppData appData = new AppData();

        private string dataPath = "data.json";

        private void LoadData()
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


            titleInput.Text = appData.title;
            maxPauseInput.Value = appData.maxPauseDays;

            darkCheck.Checked = appData.isDarkMode;
        }

        private void SaveData()
        {
            try
            {
                appData.title = titleInput.Text;
                appData.maxPauseDays = (int)maxPauseInput.Value;

                appData.isDarkMode = darkCheck.Checked;

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(appData, options);
                File.WriteAllText(dataPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            SaveData();

            if (this.Owner is Form1 parent)
            {
                parent.LoadData();
                parent.UpdateAppearance();
                parent.UpdateScreen();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            form1.isSettingsOpen = false;
            this.Dispose();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveData();

            if (this.Owner is Form1 parent)
            {
                parent.LoadData();
                parent.UpdateAppearance();
                parent.UpdateScreen();
            }

            form1.isSettingsOpen = false;
            this.Dispose();
        }

        private void darkCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            msgboxInfo("We recommend exporting the data first as a backup. ");

            string filename;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                try
                {
                    File.Copy(filename, dataPath, true);

                    if (this.Owner is Form1 parent)
                    {
                        parent.LoadConfig();
                    }

                    this.Dispose();

                    msgboxInfo("Data successfully imported. ");
                }
                catch (IOException ex)
                {
                    msgboxErr(ex.Message);
                }
                catch (Exception ex)
                {
                    msgboxErr(ex.Message);
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveData();

            string filename;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;

                try
                {
                    File.Copy(dataPath, filename, true);
                    msgboxInfo("Data successfully exported. ");
                }
                catch (IOException ex)
                {
                    msgboxErr(ex.Message);
                }
                catch (Exception ex)
                {
                    msgboxErr(ex.Message);
                }
            }
        }

        private void resetStreakButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset streak? ", "Streak Counter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.Owner is Form1 parent)
                {
                    parent.ResetStreak();
                }

                this.Close();

                msgboxInfo("Streak has been reset. ");
            }
        }

        private void resetSettingsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the settings? ", "Streak Counter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                titleInput.Text = "Title here";
                maxPauseInput.Value = 2;
                darkCheck.Checked = false;
                SaveData();

                if (this.Owner is Form1 parent)
                {
                    parent.LoadData();
                    parent.UpdateAppearance();
                    parent.UpdateScreen();
                }

                this.Close();

                msgboxInfo("Settings have been reset. ");
            }
        }

        private void resetDataButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the application? ", "Streak Counter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                titleInput.Text = "Title here";
                maxPauseInput.Value = 2;
                darkCheck.Checked = false;
                SaveData();

                if (this.Owner is Form1 parent)
                {
                    parent.LoadData();
                    parent.UpdateAppearance();
                    parent.UpdateScreen();
                }

                if (this.Owner is Form1 _parent)
                {
                    _parent.ResetStreak();
                }

                this.Close();

                msgboxInfo("The application has been reset. ");
            }
        }

        private void msgboxInfo(string msg)
        {
            MessageBox.Show(msg, "Streak Counter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void msgboxErr(string msg)
        {
            MessageBox.Show(msg, "Streak Counter", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.isSettingsOpen = false;
        }
    }
}
