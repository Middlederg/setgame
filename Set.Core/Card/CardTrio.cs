using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Set.Core
{
    public class CardTrio
    {
        private readonly IEnumerable<ICard> cards;
        public ICard First => cards.ElementAt(0);
        public ICard Second => cards.ElementAt(1);
        public ICard Third => cards.ElementAt(2);

        public CardTrio(params ICard[] cards) : this(cards.ToList()) { }

        public CardTrio(IEnumerable<ICard> cards)
        {
            if (cards == null || cards.Count() != 3)
                throw new ArgumentNullException("Deben pasarse 3 cartas como parámetro");

            this.cards = cards;
        }

        public bool IsSet()
        {
            if (!Same(x => x.Number) && !Different(x => x.Number))
               return false;

            if (!Same(x => x.Background) && !Different(x => x.Background))
               return false;

            if (!Same(x => x.Shape) && !Different(x => x.Shape))
               return false;

            if (!Same(x => x.Shading) && !Different(x => x.Shading))
               return false;

            return true;
        }

        /// <summary>
        /// Devuelve si el trío tiene esa propiedad igual
        /// </summary>
        /// <typeparam name="T">tipo de la propiedad (se puede inferir)</typeparam>
        /// <param name="conditionLambda">select</param>
        /// <returns></returns>
        private bool Same<T>(Expression<Func<ICard, T>> conditionLambda)
            => cards.AsQueryable().Select(conditionLambda).Distinct().Count() == 1;

        /// <summary>
        /// Devuelve si el trío tiene esa propiedad distinta
        /// </summary>
        /// <typeparam name="T">tipo de la propiedad (se puede inferir)</typeparam>
        /// <param name="conditionLambda">select</param>
        /// <returns></returns>
        public bool Different<T>(Expression<Func<ICard, T>> conditionLambda)
            => cards.AsQueryable().Select(conditionLambda).Distinct().Count() == cards.Count();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otherTrio = (CardTrio)obj;
            return cards.Contains(otherTrio.First) && cards.Contains(otherTrio.Second) && cards.Contains(otherTrio.Third);
        }

        public override int GetHashCode() => First.GetHashCode() * Second.GetHashCode() * Third.GetHashCode();
        
    }
}