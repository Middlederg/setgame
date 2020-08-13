using System;
using System.Linq;
using System.Threading.Tasks;

namespace Set.Core
{
    public class OnePlayerGame : Game
    {
        public OnePlayerGame(GameOptions options, Guid id, string name) : base(options, (id, name))
        {

        }

        //public bool Check(CardTrio cardTrio, Time currentTime)
        //{
        //    return Check(cardTrio, Players.First().Id,currentTime);
        //}

        //public async Task<string> SetCountHelp()
        //{
        //    return await SetCountHelp(Players.First().Id);
        //}
    }
}
