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
                Score.Create(sets: 1, mistakes: 3, help: 2, surrender: 3),
                Score.Create(sets: 3, mistakes: 6, help: 1, surrender: 1),
                Score.Create(sets: 3, mistakes: 5, help: 0, surrender: 0),
                Score.Create(sets: 4, mistakes: 7, help: 0, surrender: 0),
                Score.Create(sets: 6, mistakes: 10, help: 0, surrender: 0),
                Score.Create(sets: 5, mistakes: 0, help: 0, surrender: 0),
                Score.Create(sets: 10, mistakes: 3, help: 0, surrender: 0),
                Score.Create(sets: 9, mistakes: 2, help: 0, surrender: 0),
                Score.Create(sets: 15, mistakes: 20, help: 0, surrender: 0),
            };

            //Act and assert
            int lastScore = 0;
            foreach (var value in ascendingValues)
            {
                var score = value.Points();
                Assert.True(score > lastScore);
                lastScore = score;
            }
        }
    }
}
