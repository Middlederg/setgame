using Set.Core.Enums;
using Set.Core.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core.Model
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int NumSets { get; set; }
        public int Fallos { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Reset();
        }

        public void Reset()
        {
            NumSets = 0;
            Fallos = 0;
        }
    }

    public class Juego
    {
        public int NumCartasVisibles { get; set; }
        public List<Carta> Mazo { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public Dificultad DificultadJuego { get; set; }
        public List<string> Log { get; set; }
        public DateTime ComienzoJuego { get; set; }
        public Jugador ElTurno(int indx) => Jugadores[indx];

        public Juego(int numCartas, Dificultad dificultad, IEnumerable<string> nombres)
	    {
            DificultadJuego = dificultad;
		    Log = new List<string>() { "Comienza la partida"};
            Jugadores = new List<Jugador>();
            foreach (var item in nombres)
                Jugadores.Add(new Jugador(item));
            Reset(numCartas);
	    }

	    public void Reset(int numCartas)
	    {
            if (Log.Count > 1) Log.Add("Partida reiniciada");
            if (numCartas < 12)
                throw new ArgumentOutOfRangeException(numCartas.ToString());
            Mazo = GameHelper.GetCartas(DificultadJuego.Equals(Dificultad.Tutorial)).Take(numCartas).ToList();
            ComienzoJuego = DateTime.Now;
            Jugadores.ForEach(x => x.Reset());
            NumCartasVisibles = 12;
	    }

        /// <summary>
        /// Comprueba si es un set, y devuelve true cuando finalice el juego
        /// </summary>
        /// <param name="cartas"></param>
        /// <returns></returns>
	    public bool ComprobarSet(List<Carta> cartas, int turno)
	    {
		    if (cartas.EsSet())
		    {
			    ElTurno(turno).NumSets++;
                Log.Add((string.IsNullOrWhiteSpace(ElTurno(turno).Nombre) ? "¡Consigues Set! " : ElTurno(turno).Nombre + " consigue Set - ") + string.Join(", ", cartas.Select(x=> x.ToString())));
                foreach (var c in cartas)
                    Mazo.Remove(c);
                if (NumCartasVisibles == 15)
                    NumCartasVisibles = 12;
		    }
		    else
		    {
			    Log.Add("Fallo. No es un Set");
                ElTurno(turno).Fallos++;
		    }
            return false; //seguimos jugando
	    }

        /// <summary>
        /// Comprueba si no hay ningún set posible, y devuelve true cuando finalice el juego
        /// </summary>
        /// <returns></returns>
        public bool NoHayNingunSet()
        {
            int num = BuscarSets().Count();

            //Si no hay ningún ser y no quedan cartas, termina la partida
            if(num == 0 && Mazo.Count < NumCartasVisibles)
            {
                Log.Add("No hay ningún set más y no quedan cartas. Termina la partida");
                return true;
            }

            switch (num)
            {
                case 0:
                    //Esto es muy dificil que pase (Que no haya un set con 15 cartas visibles)
                    if (NumCartasVisibles == 15)
                    {
                        //Renovamos tres cartas del mazo, y seguimos viendo 15 cartas en la mesa
                        for (int i = 0; i < 3; i++)
                            Mazo.Remove(Mazo.First());
                    }
                    else
                    {
                        //Dejamos 15 cartas visibles
                        NumCartasVisibles = 15; 
                    }
                    break;
                case 1:
                    Log.Add("Echa un vistazo. Hay 1");
                    break;
                case 2:
                    Log.Add("Pues hay 2, así que...");
                    break;
                case 3:
                    Log.Add("Tronco, hay 3 sets por lo menos.");
                    break;
                default:
                    Log.Add($"Hay un montón. Concretamente {num}. Mira bien.");
                    break;
            }
            return false;
        }

        /// <summary>
        /// Devuelve cartas boca arriba sobre las mesa
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Carta> CartasVisibles() => Mazo.Take(Math.Min(NumCartasVisibles, Mazo.Count));

        /// <summary>
        /// Devuelve array con lista de sets
        /// </summary>
        /// <returns></returns>
        public IEnumerable<List<Carta>> BuscarSets()
	    {
            var cartasVisibles = Mazo.Take(Math.Min(NumCartasVisibles, Mazo.Count));

            //Recojo todas las posibilidades de 
            var listaCartas = new List<List<Carta>>();
            foreach (var c1 in cartasVisibles)
                foreach (var c2 in cartasVisibles)
                    foreach (var c3 in cartasVisibles)
                        if (!c1.Equals(c2) && !c1.Equals(c3) && !c2.Equals(c3))
                            listaCartas.Add(new List<Carta> { c1, c2, c3 });

            //Ordeno cada trio de cartas recogido
            listaCartas.ToList().ForEach(x => x.OrderBy(c => c.Id()));

            //Para cada trío distinto que haya, miro si es un set, y lo devuelvo
            return listaCartas.GroupBy(x => x.Sum(c => c.Id())).Select(x=> x.First()).Where(x => x.EsSet());
	    }
    }
}
