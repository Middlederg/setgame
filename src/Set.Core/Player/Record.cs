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

        public static Record FromFile(FileEntry fileEntry)
        {
            return new Record(fileEntry.Name, Score.Create(fileEntry.SetCount, fileEntry.MistakeCount), new Time(fileEntry.Seconds), fileEntry.Date);
        }

        public Record(string name, Score score, Time time, DateTime? date = null)
        {
            Name = name;
            Date = date ?? DateTime.Now;
            Score = score;
            Time = time;
        }

        public int Points() => Score.Points(Time);
        public override string ToString() => $"{Name} ({Score.Points(Time)})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Record)obj;
            return other.Date.Equals(Date) && other.Name == Name && other.Score.SetCount == Score.SetCount && other.Score.MistakeCount == Score.MistakeCount && other.Time.Equals(Time);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
