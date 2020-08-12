using System;
using System.Collections.Generic;
using System.Linq;

namespace Set.Core
{
    public class TimeStep
    {
        public int Seconds { get; }
        public int SecondIncrementPerStep { get; }

        public TimeStep(int seconds, int secondIncrementPerStep)
        {
            Seconds = seconds;
            SecondIncrementPerStep = secondIncrementPerStep;
        }

        public Time GetTime(int step) => new Time(Seconds + step * SecondIncrementPerStep);
    }

    public sealed class ChallengeOptions
    {
        public TimeStep TimeStep { get; }
        public bool AccumulateTime { get; }

        public ChallengeOptions(TimeStep timeStep, bool accumulateTime)
        {
            TimeStep = timeStep;
            AccumulateTime = accumulateTime;
        }
    }
    public class Challenge
    {
        private Guid id;

        private readonly string name;

        public TimeStep TimeStep { get; }
        public bool AccumulateTime { get; }

        private int stepIndex;
        public IEnumerable<Step> Steps { get; private set; }
        public Step ActiveStep => Steps.ElementAt(stepIndex);
        public void Nextstep() => stepIndex++;
        public bool IsFinished => Steps.Count() >= stepIndex;

        public Challenge(string name,  params int[] steps)
        {
            id = Guid.NewGuid();
            this.name = name;
            Steps = steps.Select(x => new Step(x));
            stepIndex = 0;
        }

        public override string ToString() => $"{name} ({Steps.Count()} steps)";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var other = obj as Challenge;
            return (other.id.Equals(id));
        }

        public override int GetHashCode() => id.GetHashCode();
    }
}
