using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    public class Game
    {
        private readonly ILogger log;
        private int visibleCardsCount;

        public List<ICard> Deck { get; private set; }
        public IEnumerable<ICard> AvaliableCardList => Deck.Take(Math.Min(visibleCardsCount, Deck.Count));

        public List<Player> Players { get; private set; }
        public GameMode GameMode { get; set; }
        public Player PlayerTurn(int indx) => Players[indx];

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
            visibleCardsCount = 12;
        }

        public void RestartGame()
        {
            log.Info(MessageFactory.RestartGame);
            foreach (var player in Players)
                player.Reset();
            visibleCardsCount = 12;
        }

        /// <summary>
        /// Comprueba si es un set, y devuelve true cuando finalice el juego
        /// </summary>
        /// <param name="cartas"></param>
        /// <returns></returns>
	    public bool ComprobarSet(List<Card> cartas, int turno)
	    {
		    if (new CardTrio(cartas).IsSet())
		    {
			    PlayerTurn(turno).AddSet();
                log.Info((string.IsNullOrWhiteSpace(PlayerTurn(turno).ToString()) ? "¡Consigues Set! " : PlayerTurn(turno).ToString() + " consigue Set - ") + string.Join(", ", cartas.Select(x=> x.ToString())));
                foreach (var c in cartas)
                    Deck.Remove(c);
                if (visibleCardsCount == 15)
                    visibleCardsCount = 12;
		    }
		    else
		    {
			    log.Info("Fallo. No es un Set");
                PlayerTurn(turno).AddMistake();
		    }
            return false; //seguimos jugando
	    }

        /// <summary>
        /// Comprueba si no hay ningún set posible, y devuelve true cuando finalice el juego
        /// </summary>
        /// <returns></returns>
        public bool NoHayNingunSet()
        {
            int num = FindSets().Count();

            //Si no hay ningún set y no quedan cartas, termina la partida
            if(num == 0 && Deck.Count < visibleCardsCount)
            {
                log.Info("No hay ningún set más y no quedan cartas. Termina la partida");
                return true;
            }

            switch (num)
            {
                case 0:
                    //Esto es muy dificil que pase (Que no haya un set con 15 cartas visibles)
                    if (visibleCardsCount == 15)
                    {
                        //Renovamos tres cartas del mazo, y seguimos viendo 15 cartas en la mesa
                        for (int i = 0; i < 3; i++)
                            Deck.Remove(Deck.First());
                    }
                    else
                    {
                        //Dejamos 15 cartas visibles
                        visibleCardsCount = 15; 
                    }
                    break;
                case 1:
                    log.Info("Echa un vistazo. Hay 1");
                    break;
                case 2:
                    log.Info("Pues hay 2, así que...");
                    break;
                case 3:
                    log.Info("Tronco, hay 3 sets por lo menos.");
                    break;
                default:
                    log.Info($"Hay un montón. Concretamente {num}. Mira bien.");
                    break;
            }
            return false;
        }

        public IEnumerable<CardTrio> FindSets() => new SetFinder(AvaliableCardList).Find();
    }
}
