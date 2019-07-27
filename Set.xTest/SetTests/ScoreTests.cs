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
            var ascendingValues = new List<(Score score, int seconds)>
            {
                (Score.Create(sets: 1, mistakes: 3), 20),
                (Score.Create(sets: 3, mistakes: 6), 30),
                (Score.Create(sets: 3, mistakes: 5), 30),
                (Score.Create(sets: 4, mistakes: 7), 30),
                (Score.Create(sets: 6, mistakes: 10), 40),
                (Score.Create(sets: 5, mistakes: 0), 30),
                (Score.Create(sets: 10, mistakes: 3), 60),
                (Score.Create(sets: 9, mistakes: 2), 40),
                (Score.Create(sets: 15, mistakes: 20), 60),
            };

            //Act and assert
            int lastScore = 0;
            foreach (var value in ascendingValues)
            {
                var score = value.score.Points(new Time(value.seconds));
                Assert.True(score > lastScore);
                lastScore = score;
            }
        }
    }
}
