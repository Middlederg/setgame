using System.Collections;
using System.Collections.Generic;

namespace Set.xTest
{
    public class SetGeneratorData : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] { CardFactory.OneBlueDiamond, CardFactory.OneBlueOval, CardFactory.OneBlueSquiggle },
            new object[] { CardFactory.OneBlueOval, CardFactory.TwoBlueOval, CardFactory.ThreeBlueOval },
            new object[] { CardFactory.OneBlueOval, CardFactory.OneRedOval, CardFactory.OneYellowOval }
        };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
