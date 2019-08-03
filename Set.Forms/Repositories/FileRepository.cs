using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Set.Core;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Set.Forms
{
    public class FileRepository : IRepository
    {
        private const string fileName = "records.dat";
        private readonly string filePath = $@"{Directory.GetCurrentDirectory()}\{fileName}";

        public List<Record> GetBestRecords()
        {
            if (!File.Exists(filePath))
                return Enumerable.Empty<Record>().ToList();

            using (StreamReader stream = File.OpenText(filePath))
            {
                string json = stream.ReadToEnd();
                IEnumerable<FileEntry> fileEntries = JsonConvert.DeserializeObject<IEnumerable<FileEntry>>(json);
                return fileEntries.Select(fileEntry => Record.FromFile(fileEntry)).ToList();
            }
        }

        public void SaveRecord(Record record)
        {
            var recordList = GetBestRecords();
            recordList.Add(record);
            WriteToFile(recordList);

        }

        public void SaveRecord(IEnumerable<Record> records)
        {
            var recordList = GetBestRecords();
            recordList.AddRange(records);
            WriteToFile(recordList);
        }

        private void WriteToFile(IEnumerable<Record> records)
        {
            var fileEntries = records.OrderByDescending(x => x.Points()).Select(record => new FileEntry(record)).ToList();
            using (StreamWriter stream = new StreamWriter(filePath))
            {
                string json = JsonConvert.SerializeObject(fileEntries);
                stream.Write(json);
            }
        }

        public void Reset()
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}