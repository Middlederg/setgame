using System.Collections;
using System.Collections.Generic;

namespace Set.xTest
{
    public class NoSetGeneratorData : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] { CardFactory.OneBlueDiamond, CardFactory.TwoBlueOval, CardFactory.OneBlueSquiggle },
            new object[] { CardFactory.OneRedOval, CardFactory.TwoBlueOval, CardFactory.ThreeBlueOval },
            new object[] { CardFactory.OneBlueDiamond, CardFactory.ThreeBlueOval, CardFactory.OneYellowOval },
            new object[] { CardFactory.OneBlueDiamond, CardFactory.OneBlueOval, CardFactory.OneYellowOval },
        };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
