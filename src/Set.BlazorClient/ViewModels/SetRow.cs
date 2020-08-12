using Set.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set.BlazorClient
{
    public class SetRowViewModel
    {
        public int Position { get; set; }
        public CardTrio Trio { get; set; }
        public string Text { get; set; }
        public TimeSpan Time { get; set; }

        public SetRowViewModel(int position, CardTrio trio, string text, TimeSpan time)
        {
            Position = position;
            Trio = trio;
            Text = text;
            Time = time;
        }
    }
}
