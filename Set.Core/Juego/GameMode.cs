namespace Set.Core
{
    public abstract class GameMode
    {
        protected abstract string Name { get; }
        public abstract string Description { get; }
        public virtual int MaxCardNumber => GameOptions.DefaultMaxCardnumber;

        internal GameMode() { }
        public override string ToString() => Name;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var gameMode = obj as GameMode;
            return (gameMode.Name.Equals(ToString()));
        }

        public override int GetHashCode() => Name.GetHashCode();

        public bool IsTutorial => GetType().Equals(typeof(Tutorial));
    }
}
