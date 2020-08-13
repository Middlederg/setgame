using System;

namespace Set.Core
{
    public class DiscoveredSet
    {
        public CardTrio Trio { get; set; }
        public string Text { get; set; }
        public TimeSpan Time { get; set; }

        public DiscoveredSet(CardTrio trio, string text, TimeSpan time)
        {
            Trio = trio;
            Text = text;
            Time = time;
        }
    }
}
