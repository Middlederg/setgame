namespace Set.Core
{
    public static class SerieFactory
    {
        public static Serie CampeonatoIndautxu() => new Serie("Campeonato de Indautxu", 6, 7, 8, 10, 12, 15);
        public static Serie RetoBizkaino => new Serie("Reto vizcaíno", 4, 6, 8, 10, 12, 15);
        public static Serie Superliga => new Serie("Superliga", 8, 12, 14, 12, 15, 18, 12, 30);
    }
}
