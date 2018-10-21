using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set.Core.Model
{
    [Serializable]
    public class Tiempo
    {
        public int Segundos { get; }

        public Tiempo(int segundos)
        {
            Segundos = segundos;
        }

        public override string ToString() => TimeSpan.FromSeconds(Segundos).ToString(@"mm\:ss");
    }
}
