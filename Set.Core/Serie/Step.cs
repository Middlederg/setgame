using System;
using System.Text;

namespace Set.Core
{
    public class Step
    {
        public const int MaxCardNumber = 40;

        public int CardNumber { get; }

        public Step(int cardNumber)
        {
            if (CardNumber < 0) throw new ArgumentOutOfRangeException("Imposible crear un paso negativo");
            if (CardNumber > MaxCardNumber) throw new ArgumentOutOfRangeException($"{nameof(CardNumber)}:{CardNumber} es mayor que el limite máximo {MaxCardNumber}");

            CardNumber = cardNumber;
        }

        public override string ToString() => $"Nº cartas: {CardNumber}";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var other = obj as Step;
            return (other.CardNumber == CardNumber);
        }

        public override int GetHashCode() => CardNumber.GetHashCode();
    }
}
