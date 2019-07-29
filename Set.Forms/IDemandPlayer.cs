using Set.Core;
using Set.Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set.Forms
{
    public interface IDemandPlayer
    {
        Player GetPlayer();
    }

    public class OnePlayerDemand : IDemandPlayer
    {
        public Player GetPlayer()
        {
            throw new NotImplementedException();
        }
    }

    public class MultiplayerDemand : IDemandPlayer
    {
        public Player GetPlayer()
        {
            throw new NotImplementedException();
        }
    }

    public interface IEndGame
    {
        void Process();
    }

    public class OnePlayerEndGame : IEndGame
    {
        IPlayerNameViewModel view;

        public void Process(Time time)
        {
            new FrmInputName(game.ElTurno(0).NumSets, game.ElTurno(0).Fallos, (int)(DateTime.Now.Subtract(game.ComienzoJuego).TotalSeconds)).ShowDialog();
        }
    }

    public class MultiplayerEndGame : IEndGame
    {
        private Game game;

        public void Process(Time time, )
        {
            foreach (var player in game.Players)
            {
                var record = new Record(player.ToString(), player.Score, time);
                Files.GuardarPuntuacion(record);
            }
        }
    }
}
