﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    public class Game
    {
        public const int VisibleCardNumberDefault = 12;

        private readonly ILogger log;
        private int visibleCardsCount;

        public List<ICard> Deck { get; private set; }
        public IEnumerable<ICard> AvaliableCardList => Deck.Take(Math.Min(visibleCardsCount, Deck.Count)).ToList();

        public List<Player> Players { get; private set; }
        public int TotalSets => Players.Sum(x => x.SetCount);
        public int TotalMistakes => Players.Sum(x => x.MistakeCount);
        public bool IsOnePlayerMode => Players.Count == 1;
        public IEnumerable<Record> PlayerPositions(Time time) => Players.Select(player => player.GetRecord(time)).OrderByDescending(x => x.Points());

        public GameMode GameMode { get; set; }

        public Game(GameOptions options, ILogger log)
	    {
            this.log = log;
            GameMode = options.GameMode;
            Deck = CardFactory.CreateDeck(options.GameMode).ToList();
            Players = Player.CreatePlayers(options.PlayerNames).ToList();
        }

        public void StartGame()
        {
            log.Info(MessageFactory.StartGame);
            visibleCardsCount = VisibleCardNumberDefault;
        }

        public void RestartGame()
        {
            log.Info(MessageFactory.RestartGame);
            foreach (var player in Players)
                player.Reset();
            visibleCardsCount = VisibleCardNumberDefault;
        }

	    public bool Check(CardTrio cardTrio, Player player)
	    {
		    if (cardTrio.IsSet())
            {
                player.AddSet();
                string playerName = IsOnePlayerMode ? "¡Consigues Set!" : $"{player.ToString()} consigue Set";
                log.Info($"{playerName} {cardTrio.ToString()}");
                return true;
            }

            log.Info("Fallo. No es un Set");
            player.AddMistake();
            return false;
	    }

        public bool TryToRefreshCards(CardTrio cardTrio)
        {
            visibleCardsCount = VisibleCardNumberDefault;

            foreach (var card in cardTrio.Cards)
                Deck.Remove(card);

            if (IsGameEnd())
                return false;

            if (!FindSets().Any())
            {
                visibleCardsCount = VisibleCardNumberDefault + 3;
                if (IsGameEnd())
                    return false;
            }
            return true;
        }

        public IEnumerable<CardTrio> FindSets() => new SetFinder(AvaliableCardList).Find();

        public bool IsGameEnd() => !FindSets().Any() && Deck.Count <= visibleCardsCount;
        
        public string SetCountHelp()
        {
            int num = FindSets().Count();
            switch (num)
            {
                case 0: return "Esto no estaba previsto. No hay ningún Set :(";
                case 1: return "Echa un vistazo. Hay 1";
                case 2: return "Pues hay 2, así que...";
                case 3: return "Colega, hay 3 sets por lo menos.";
                default: return $"Hay un montón. Concretamente {num}. Mira bien.";
            }
        }
    }
}
