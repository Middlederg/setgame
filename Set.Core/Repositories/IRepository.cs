using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Set.Core
{
    public interface IRepository
    {
        void SaveRecord(Record record);
        void SaveRecord(IEnumerable<Record> records);
        List<Record> GetBestRecords();
        void Reset();
    }
}