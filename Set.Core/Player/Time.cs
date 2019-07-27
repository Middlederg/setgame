using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set.Core
{
    public class Time
    {
        public int Seconds { get; }

        public Time(int segundos)
        {
            Seconds = segundos;
        }

        public override string ToString() => TimeSpan.FromSeconds(Seconds).ToString(@"mm\:ss");
    }
}
