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

        public static Record FromFile(FileEntry fileEntry)
        {
            return new Record(fileEntry.Name, Score.Create(fileEntry.SetCount, fileEntry.MistakeCount,  fileEntry.HelpCount, fileEntry.SurrenderCount), fileEntry.Date);
        }

        public Record(string name, Score score, DateTime? date = null)
        {
            Name = name;
            Date = date ?? DateTime.Now;
            Score = score;
        }

        public int Points() => Score.Points();
        public override string ToString() => $"{Name} ({Score.Points()})";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Record)obj;
            return other.Date.Equals(Date) && other.Name == Name && other.Score.Equals(Score);
        }

        public override int GetHashCode() => Date.GetHashCode();
    }
}
