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
}
