namespace Set.Core
{
    public class Score
    {
        public const int PositiveModifier = 10;
        public const int NegativeModifier = 2;

        public int SetCount { get; private set; }
        internal void AddSet() => SetCount++;

        public int MistakeCount { get; private set; }
        internal void AddMistake() => MistakeCount++;

        public static Score Create(int sets, int mistakes)
        {
            return new Score() { SetCount = sets, MistakeCount = mistakes };
        }

        public Score()
        {
            SetCount = 0;
            MistakeCount = 0;
        }

        public int Points(Time time)
        {
            var positivePoints = SetCount * PositiveModifier;
            var negativePoints = (MistakeCount * NegativeModifier) + (time.Seconds) - 20;
            return positivePoints - negativePoints;
        }
    }
}
