using Set.Core;
using System.Linq;
using Xunit;

namespace Set.xTest
{
    public class OnePlayerEasyGameTests : GameTests
    {
        public OnePlayerEasyGameTests() : base(27, GameModeFactory.Easy, 1)
        {
            game.StartGame();
        }

        [Fact]
        public void Should_be_one_Set_at_the_begining()
        {
            var sets = game.FindSets().ToList();

            Assert.True(sets.Any());
        }

        [Fact]
        public void Should_not_allow_any_help()
        {
            ////Arrange
            //var game = new Game();
            //var card1 = CardFactory.OneBlueDiamond;
            //var card2 = CardFactory.OneBlueDiamond;

            ////Act
            //var result = card1.Equals(card2);

            ////Assert
            //Assert.True(result);
        }
    }
}
