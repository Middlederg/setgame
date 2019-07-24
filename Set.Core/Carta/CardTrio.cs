using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Set.Core.Negocio
{
    public class CardTrio
    {
        private readonly IEnumerable<ICard> cards;

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
    }
}