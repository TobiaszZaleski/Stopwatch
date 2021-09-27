using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; set; }
        public TimeSpan NextTime { get; set; }

        public Stopwatch()
        {
            StartTime = DateTime.Now;
        }
        public void Start()
        {
            NextTime = DateTime.Now - StartTime;
        }
        public double Stop
        {
            get 
            {
                var timeSpan = DateTime.Now - StartTime - NextTime;
                return timeSpan.TotalSeconds;
            }
        }
    }
}
