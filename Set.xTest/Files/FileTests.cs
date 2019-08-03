using Newtonsoft.Json;
using Set.Core;
using Set.Forms;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Set.xTest
{
    public class FileTests
    {
        private IRepository repository;
        public FileTests()
        {
            
            repository = new FileRepository();
            repository.Reset();
        }

        [Fact]
        public void Should_deserialize_a_file()
        {
            //Arrange
            string jsonString = "[{\"Name\":\"nombre\",\"Date\":\"2019-08-03T09:56:20.2569523+02:00\",\"SetCount\":1,\"MistakeCount\":4,\"Seconds\":30}]";

            //Act
            var fileEntries = JsonConvert.DeserializeObject<IEnumerable<FileEntry>>(jsonString);

            //Assert
            Assert.NotNull(fileEntries);
            Assert.IsAssignableFrom<IEnumerable<FileEntry>>(fileEntries);
            var list = (fileEntries as IEnumerable<FileEntry>);
            Assert.True(list.Count() == 1);
        }

        [Fact]
        public void Should_serialize_a_file()
        {
            //Arrange
            var record = new Core.Record("nombre", Score.Create(1, 4), new Time(30));
            
            //Act
            repository.SaveRecord(record);
            var recordList = repository.GetBestRecords();

            //Assert
            Assert.Contains(record, recordList);
        }
    }
}
