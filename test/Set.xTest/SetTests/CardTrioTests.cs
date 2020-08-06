using Set.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Set.xTest
{
    public class SetTests
    {
        [Theory, ClassData(typeof(SetGeneratorData))]
        public void Should_be_a_Set(ICard card1, ICard card2, ICard card3)
        {
            //Arrange
            var trio = new CardTrio(card1, card2, card3);

            //Act
            var result = trio.IsSet();

            //Assert
            Assert.True(result);
        }

        [Theory, ClassData(typeof(NoSetGeneratorData))]
        public void Should_not_be_a_Set(ICard card1, ICard card2, ICard card3)
        {
            //Arrange
            var trio = new CardTrio(card1, card2, card3);

            //Act
            var result = trio.IsSet();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_find_several_sets()
        {
            //Arrange
            var finder = new SetFinder(new List<ICard> {
                CardFactory.OneBlueDiamond, CardFactory.OneBlueOval, CardFactory.OneBlueSquiggle, CardFactory.OneRedOval,
                CardFactory.OneYellowOval, CardFactory.ThreeBlueOval, CardFactory.TwoBlueOval
            });

            //Act
            var setsFound = finder.Find();

            //Assert
            foreach (var trio in setsFound)
                Assert.True(trio.IsSet());

            Assert.Equal(3, setsFound.Count());

            Assert.Contains(new CardTrio(CardFactory.OneBlueDiamond, CardFactory.OneBlueOval, CardFactory.OneBlueSquiggle), setsFound);
            Assert.Contains(new CardTrio(CardFactory.OneBlueOval, CardFactory.TwoBlueOval, CardFactory.ThreeBlueOval), setsFound);
            Assert.Contains(new CardTrio(CardFactory.OneBlueOval, CardFactory.OneRedOval, CardFactory.OneYellowOval), setsFound);
        }
    }
}
