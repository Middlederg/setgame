using System;

namespace Set.Core
{
    public class Score
    {
        public const int SetValue = 10;
        public const int MistakeValue = 2;
        public const int HelpValue = 5;
        public const int SurrenderValue = 25;

        public int Sets { get; private set; }
        public int Mistakes { get; private set; }
        public int Help { get; private set; }
        public int Surrender { get; private set; }

        public Score(int sets, int mistakes, int help, int surrender)
        {
            Sets = sets;
            Mistakes = mistakes;
            Help = help;
            Surrender = surrender;
        }

        public int Points()
        {
            var positivePoints = Sets * SetValue;
            var negativePoints = (Mistakes * MistakeValue) + (Help * HelpValue) + (Surrender * SurrenderValue);
            return Math.Max(0, positivePoints - negativePoints);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Score)obj;

            return other.Points() == Points();
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
