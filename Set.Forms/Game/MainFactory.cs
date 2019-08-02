using Newtonsoft.Json;
using Set.Core;
using Set.Forms.Views;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Set.Forms
{
    public class FileRepository : IRepository
    {
        private const string fileName = "records.dat";

        public List<Record> GetBestRecords()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\{fileName}";
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Record> recordList = (List<Record>)serializer.Deserialize(file, typeof(List<Record>));
                return recordList;
            }
        }

        public void SaveRecord(Record record)
        {
            var recordList = GetBestRecords();
            recordList.Add(record);

        }

        public void SaveRecord(IEnumerable<Record> records)
        {
            var recordList = GetBestRecords();
            recordList.AddRange(records);
        }
    }
    public static class MainFactory
    {
        public static IDemandPlayer DemandPlayer(Game game, Point parentLocation, int parentWidth)
        {
            if (game.IsOnePlayerMode)
                return new OnePlayerDemand(game);

            return new MultiplayerDemand(game, new PlayersView() { Location = new Point(parentLocation.X + parentWidth, parentLocation.Y) });
        }

        public static IEndGame EndGame(Game game)
        {
            if (game.IsOnePlayerMode)
                return new OnePlayerEndGame(game, new InputNameView(), new FileRepository());

            return new MultiplayerEndGame(game, new FileRepository());
        }
    }
}