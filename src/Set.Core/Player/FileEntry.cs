using System;

namespace Set.Core
{
    public class FileEntry
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int SetCount { get; set; }
        public int MistakeCount { get; set; }
        public int HelpCount { get; set; }
        public int SurrenderCount { get; set; }

        public FileEntry() { }
        public FileEntry(Record record)
        {
            Name = record.Name;
            Date = record.Date;
            SetCount = record.Score.SetCount;
            MistakeCount = record.Score.MistakeCount;
            HelpCount = record.Score.HelpCount;
            SurrenderCount = record.Score.SurrenderCount;
        }
    }
}
