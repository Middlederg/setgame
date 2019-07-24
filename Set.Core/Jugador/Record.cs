using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core
{
    [Serializable]
    public class Record
    {
        private string nombreJugador;
        public string NombreJugador
        {
            get { return nombreJugador; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(value);
                nombreJugador = value.Trim().Replace(";", "");
            }
        }

        public int NumSets { get; set; }
        public int Fallos { get; set; }
        public DateTime Fecha { get; set; }
        public Tiempo Tiempo { get; set; }

        /// <summary>
        /// Construir nuevo record
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="puntos"></param>
        public Record(int numsets, int fallos, int segundos)
        {
            NumSets = numsets;
            Fallos = fallos;
            Tiempo = new Tiempo(segundos);
            Fecha = DateTime.Now;
        }

        public int Puntuacion() => (NumSets * 5 - Fallos + (NumSets - (Tiempo.Segundos / 30)));
        public override string ToString() => NombreJugador + " (" + Puntuacion() + ")";
    }
}
