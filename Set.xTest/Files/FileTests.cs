using Set.Core;
using Set.Forms;
using Xunit;

namespace Set.xTest
{
    public class FileTests
    {
        public FileTests()
        {
            //string json = @"{
            //  CPU: 'Intel',
            //  Drives: [
            //    'DVD read/writer',
            //    '500 gigabyte hard drive'
            //  ]
            //}";
        }

        [Fact]
        public void Should_deserialize_a_file()
        {

        }

        [Fact]
        public void Should_serialize_a_file()
        {
            //Arrange
            var record = new Core.Record("nombre", Score.Create(1, 4), new Time(30));
            var repository = new FileRepository();

            //Act
            repository.SaveRecord(record);
            var recordList = repository.GetBestRecords();

            //Assert
            Assert.Contains(record, recordList);
        }
    }
}
