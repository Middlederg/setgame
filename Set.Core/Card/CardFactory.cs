using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public static class CardFactory
    {
        public static IEnumerable<ICard> CreateDeck(GameMode gameMode) => GetCards(gameMode).ToList().RandomizeList();
        private static IEnumerable<ICard> GetCards(GameMode gameMode)
        {
            foreach (int numero in Enumerable.Range(1, 3))
            { 
                foreach (int color in Enumerable.Range(0, 3))
                {
                    foreach (int forma in Enumerable.Range(0, 3))
                    {
                        if (gameMode.IsTutorial)
                            yield return new SimpleCard(numero, (Background)color, (Shape)forma);
                        else
                        {
                            foreach (int relleno in Enumerable.Range(0, 3))
                                yield return new Card(numero, (Background)color, (Shape)forma, (Shading)relleno);
                        }
                    }
                }
            }
        }
    }
}