using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Set.Core;

namespace Set.Web.Pages
{
    public class IndexModel : PageModel, IMessengerLogger
    {
        public string Message { get; set; }

        public Game Game { get; private set; }

        public IndexModel()
        {
            var options = new GameOptions(GameOptions.DefaultMaxCardnumber, GameModeFactory.Easy, "Mike");
            var logger = new MessengerLogger(this);
            Game = new Game(options, logger); 
            Game.StartGame();
        }


        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
