using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Set.Core
{
    public class SetFinder
    {
        private readonly IEnumerable<ICard> cards;
        private IEnumerable<CardTrio> GetAllPosibleCombinations()
        {
            foreach (var position1 in cards)
                foreach (var position2 in cards)
                    foreach (var position3 in cards)
                        if (!position1.Equals(position2) && !position1.Equals(position3) && !position2.Equals(position3))
                             yield return new CardTrio(position1, position2, position3);
        }

        public SetFinder(IEnumerable<ICard> cards)
        {
            this.cards = cards;
        }

        public IEnumerable<CardTrio> Find() => GetAllPosibleCombinations().Distinct().Where(x => x.IsSet());
        public async Task<IEnumerable<CardTrio>> FindAsync()
        {
            var combinations = GetAllPosibleCombinations().ToList();
            var results = await Task.Run(() => combinations.Distinct().Where(x => x.IsSet()).ToList());
            return results;
        }
    }
}