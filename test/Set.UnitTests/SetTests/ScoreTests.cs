using Set.Core;
using System.Collections.Generic;
using Xunit;

namespace Set.xTest
{
    public class ScoreTests
    {
        [Fact]
        public void Should_calculate_ascendent_points()
        {
            //Arrange
            var ascendingValues = new List<Score>()
            {
                new Score(sets: 1, mistakes: 3, help: 2, surrender: 3),
                new Score(sets: 3, mistakes: 2, help: 1, surrender: 0),
                new Score(sets: 3, mistakes: 2, help: 0, surrender: 0),
                new Score(sets: 4, mistakes: 3, help: 0, surrender: 0),
                new Score(sets: 6, mistakes: 10, help: 0, surrender: 0),
                new Score(sets: 5, mistakes: 0, help: 0, surrender: 0),
                new Score(sets: 10, mistakes: 4, help: 2, surrender: 0),
                new Score(sets: 9, mistakes: 0, help: 0, surrender: 0),
                new Score(sets: 15, mistakes: 20, help: 0, surrender: 0),
            };

            //Act and assert
            int lastScore = -1;
            foreach (var value in ascendingValues)
            {
                var score = value.Points();
                Assert.True(score > lastScore);
                lastScore = score;
            }
        }
    }
}
