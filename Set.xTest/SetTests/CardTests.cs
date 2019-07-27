using Xunit;

namespace Set.xTest
{
    public class CardTests
    {
        [Fact]
        public void Should_be_same_card()
        {
            //Arrange
            var card1 = CardFactory.OneBlueDiamond;
            var card2 = CardFactory.OneBlueDiamond;

            //Act
            var result = card1.Equals(card2);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Should_be_different_card()
        {
            //Arrange
            var card1 = CardFactory.OneBlueDiamond;
            var card2 = CardFactory.OneBlueOval;

            //Act
            var result = card1.Equals(card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Should_give_card_name()
        {
            //Arrange
            var card = CardFactory.OneBlueDiamond;

            //Act
            var result = card.ToString();

            //Assert
            Assert.Equal("1 Blue Diamonds", result);
        }
    }
}
