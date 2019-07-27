using Set.Core;

namespace Set.xTest
{
    public static class CardFactory
    {
        public static ICard OneBlueOval => new SimpleCard(1, Background.Blue, Shape.Ovals);
        public static ICard TwoBlueOval => new SimpleCard(2, Background.Blue, Shape.Ovals);
        public static ICard ThreeBlueOval => new SimpleCard(3, Background.Blue, Shape.Ovals);
        public static ICard OneRedOval => new SimpleCard(1, Background.Red, Shape.Ovals);
        public static ICard OneYellowOval => new SimpleCard(1, Background.Yellow, Shape.Ovals);
        public static ICard OneBlueSquiggle => new SimpleCard(1, Background.Blue, Shape.Squiggles);
        public static ICard OneBlueDiamond => new SimpleCard(1, Background.Blue, Shape.Diamonds);
    }
}
