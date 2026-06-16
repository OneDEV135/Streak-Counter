using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Check_In
{
    public class AppData
    {
        // data
        public int days { get; set; } = 0;
        public int totalDays { get; set; } = 0;
        public int pauseCount { get; set; } = 0;
        public int[] weekStat { get; set; } = { 0, 0, 0, 0, 0 };
        public bool isChecked { get; set; } = false;
        public DateTime date { get; set; } = DateTime.MinValue;

        // settings
        public string title { get; set; } = "Title here";
        public int maxPauseDays { get; set; } = 0;
        public bool isDarkMode { get; set; } = true;
    }
}
