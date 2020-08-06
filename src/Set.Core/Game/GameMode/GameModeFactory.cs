namespace Set.Core
{
    public static class GameModeFactory
    {
        public static GameMode Tutorial => new Tutorial();
        public static GameMode Easy => new Easy();
        public static GameMode Regular => new Regular();
    }
}
