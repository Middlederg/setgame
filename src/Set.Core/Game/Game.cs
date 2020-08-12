using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    public class Game
    {
        public const int VisibleCardNumberDefault = 12;

        private readonly IMessengerLogger log;
        public string GetLastMessage() => log.GetLastEntry();
        private int visibleCardsCount;

        public List<ICard> Deck { get; private set; }
        public IEnumerable<ICard> AvaliableCardList => Deck.Take(Math.Min(visibleCardsCount, Deck.Count)).ToList();

        public List<Player> Players { get; private set; }
        public int TotalSets => Players.Sum(x => x.SetCount);
        public int TotalMistakes => Players.Sum(x => x.MistakeCount);
        public bool IsOnePlayerMode => Players.Count == 1;
        public IEnumerable<Record> PlayerPositions() => Players.Select(player => player.GetRecord()).OrderByDescending(x => x.Points());
        public IEnumerable<Player> Ranking() => Players.OrderByDescending(x => x.Score.Points());

        public GameMode GameMode { get; set; }

        public Game(GameOptions options, IMessengerLogger log)
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

            while (!AreAvaliableSets)
            {
                PrepareAvaliableCards();
            }
        }

        public bool Check(CardTrio cardTrio, Player player)
	    {
		    if (cardTrio.IsSet())
            {
                player.AddSet();
                string playerName = IsOnePlayerMode ? "¡Consigues Set!" : $"{player} consigue Set";
                log.Info($"{playerName} {cardTrio}");
                return true;
            }

            log.Info("Fallo. No es un Set");
            player.AddMistake();
            return false;
	    }

        public void RefreshCards(CardTrio cardTrio)
        {
            do
            {
                RemoveCardsFromDeck(cardTrio);
                PrepareAvaliableCards();
            }
            while (!AreAvaliableSets);
        }

        private void PrepareAvaliableCards()
        {
            visibleCardsCount = VisibleCardNumberDefault;

            if (AreAvaliableSets)
                return;

            visibleCardsCount += 3;

            if (AreAvaliableSets)
                return;

            RemoveCardsFromDeck(new CardTrio(Deck[0], Deck[1], Deck[2]));
        }

        private void RemoveCardsFromDeck(CardTrio cardTrio)
        {
            foreach (var card in cardTrio.Cards)
                Deck.Remove(card);
        }

        public IEnumerable<CardTrio> FindSets() => new SetFinder(AvaliableCardList).Find();
        public async Task<IEnumerable<CardTrio>> FindSetsAsync() => await new SetFinder(AvaliableCardList).FindAsync();
        public bool AreAvaliableSets => FindSets().Any();
        public bool LevelCompleted() => !FindSets().Any() && Deck.Count <= visibleCardsCount;
        
        public async Task<string> SetCountHelp()
        {
            var setList = await FindSetsAsync();
            int num = setList.Count();
            switch (num)
            {
                case 0: return "Esto no estaba previsto. No hay ningún Set :(";
                case 1: return "Solo hay un set, echa un vistazo. Si te fijas lo encontrarás.";
                case 2: return "Hay dos sets posibles, así que tienes dos opciones";
                case 3:
                case 4:
                    return $"Hay {num} sets posibles, intenta descubrir alguno de ellos.";
                case 5:
                case 6:
                    return $"Tienes {num} sets posibles, seguro que puedes adivinar alguno.";
                default: return $"Hay un montón de Sets posibles. Concretamente {num}.";
            }
        }
    }
}
