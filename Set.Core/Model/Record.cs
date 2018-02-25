using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Core.Model
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
        public int Segundos { get; set; }
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Construir nuevo record
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="puntos"></param>
        public Record(int numsets, int fallos, int segundos)
        {
            NumSets = numsets;
            Fallos = fallos;
            Segundos = segundos;
            Fecha = DateTime.Now;
        }

        /// <summary>
        /// Deconstruir desde linea del csv
        /// </summary>
        /// <param name="fila"></param>
        public Record(string fila)
        {
            NombreJugador = fila.Split(';')[0];
            NumSets = Int32.Parse(fila.Split(';')[1]);
            Fallos = Int32.Parse(fila.Split(';')[2]);
            Segundos = Int32.Parse(fila.Split(';')[3]);
            Fecha = DateTime.Parse(fila.Split(';')[4]);
        }

        public int Puntuacion() => (NumSets * 5 - Fallos + (NumSets - (Segundos / 30)));
        public override string ToString() => NombreJugador + " (" + Puntuacion() + ")";

        public string Tiempo() => TimeSpan.FromSeconds(Segundos).ToString(@"mm\:ss");
        
    }
}
