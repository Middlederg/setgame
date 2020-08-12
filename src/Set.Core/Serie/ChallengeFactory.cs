namespace Set.Core
{
    public static class ChallengeFactory
    {
        public static Challenge CampeonatoIndautxu => new Challenge("Campeonato de Indautxu", 6, 7, 8, 10, 12, 15);
        public static Challenge RetoBizkaino => new Challenge("Reto vizcaíno", 4, 6, 8, 10, 12, 15);
        public static Challenge Superliga => new Challenge("Superliga", 8, 12, 14, 12, 15, 18, 12, 30);
    }
}
