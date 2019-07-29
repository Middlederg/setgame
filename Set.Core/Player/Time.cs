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
    }
}
