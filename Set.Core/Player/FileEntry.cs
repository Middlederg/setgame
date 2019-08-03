using System;

namespace Set.Core
{
    public class FileEntry
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int SetCount { get; set; }
        public int MistakeCount { get; set; }
        public int Seconds { get; set; }

        public FileEntry() { }
        public FileEntry(Record record)
        {
            Name = record.Name;
            Date = record.Date;
            SetCount = record.Score.SetCount;
            MistakeCount = record.Score.MistakeCount;
            Seconds = record.Time.Seconds;
        }
    }
}
