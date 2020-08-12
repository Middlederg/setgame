using System;

namespace Set.Core
{
    public class Score
    {
        public const int SetValue = 10;
        public const int MistakeValue = 2;
        public const int HelpValue = 5;
        public const int SurrenderValue = 25;

        public int SetCount { get; private set; }
        internal void AddSet() => SetCount++;

        public int MistakeCount { get; private set; }
        internal void AddMistake() => MistakeCount++;

        public int HelpCount { get; private set; }
        internal void AddHelp() => HelpCount++;

        public int SurrenderCount { get; private set; }
        internal void AddSurrender() => SurrenderCount++;

        public static Score Create(int sets, int mistakes, int help, int surrender)
        {
            return new Score() { SetCount = sets, MistakeCount = mistakes, HelpCount = help, SurrenderCount = surrender  };
        }

        public Score()
        {
            SetCount = 0;
            MistakeCount = 0;
            HelpCount = 0;
            SurrenderCount = 0;
        }

        public int Points()
        {
            var positivePoints = SetCount * SetValue;
            var negativePoints = (MistakeCount * MistakeValue) + (HelpCount * HelpValue) + (SurrenderCount + SurrenderValue);
            return Math.Max(0, positivePoints - negativePoints);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Score)obj;

            return other.SetCount == SetCount &&
                other.MistakeCount == MistakeCount &&
                other.HelpCount == HelpCount &&
                other.SurrenderCount == SurrenderCount;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
