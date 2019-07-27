using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    public class Record
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public Score Score { get; private set; }
        public Time Time { get; private set; }

        internal static Record FromFile(string name, int sets, int mistakes, int seconds)
        {
            return new Record(name, Score.Create(sets, mistakes), seconds);
        }

        public Record(string name, Score score, int seconds)
        {
            Name = name;
            Date = DateTime.Now;
            Score = score;
            Time = new Time(seconds);
        }

        public int Points() => Score.Points(Time);
        public override string ToString() => $"Name ({Score.Points(Time)})";
    }
}
