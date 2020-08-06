using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set.Core
{
    public class Time
    {
        public int Seconds { get; private set; }
        public void AddScecond() => Seconds++;

        public Time(int segundos = 0)
        {
            Seconds = segundos;
        }

        public override string ToString() => TimeSpan.FromSeconds(Seconds).ToString(@"mm\:ss");

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Time)obj;
            return other.Seconds == Seconds;
        }

        public override int GetHashCode() => Seconds.GetHashCode();
    }
}
