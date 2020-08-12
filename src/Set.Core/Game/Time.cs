using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set.Core
{
    public class Time
    {
        public TimeSpan TimeSpan { get; private set; }
        public void RemoveSecond() => TimeSpan = TimeSpan.Subtract(new TimeSpan(0, 0, 1));
        public bool IsUp() => TimeSpan.TotalSeconds <= 0;

        public Time(int seconds = 50)
        {
            TimeSpan = new TimeSpan(0, 0, seconds);
        }

        public Time(TimeSpan timespan)
        {
            TimeSpan = timespan;
        }

        public override string ToString() => TimeSpan.ToString();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Time)obj;
            return other.TimeSpan.Equals(TimeSpan);
        }

        public override int GetHashCode() => TimeSpan.GetHashCode();
    }
}
