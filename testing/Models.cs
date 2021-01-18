using System;
using System.Collections.Generic;

namespace testing
{
    class WorkReport
    {
        public WorkReport()
        {
        }
        public DateTime Date { get; set; }
        public string EmployeeId { get; set; }
        public List<Activity> Activities {get; set;}
    }
    class Activity
    {
        public Activity(TimeSpan startTime,TimeSpan endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            TotalTime = EndTime - StartTime;
        }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string TotalTime { get; set; }
        public string Notes { get; set; }
    }
}