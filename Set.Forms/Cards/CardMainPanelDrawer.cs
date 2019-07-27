using System.Windows.Forms;
using System.Drawing;
using Set.Core;
using System.Collections.Generic;

namespace Set.Forms
{
    public class CardMainPanelDrawer
    {
        private readonly IEnumerable<ICard> cardList;
        private readonly Panel mainPanel;
        private readonly CardDrawer cardDrawer;

        public CardMainPanelDrawer(IEnumerable<ICard> cardList, Panel mainPanel)
        {
            this.cardList = cardList;
            this.mainPanel = mainPanel;
            cardDrawer = new CardDrawer();
        }

        internal void Draw()
        {
            mainPanel.Controls.Clear();

            int x = 0; int y = 0;
            int padding = 24;
            foreach (var card in cardList)
            {
                var cardPanel = cardDrawer.Draw(card);
                cardPanel.Location = new Point(padding + (padding + cardPanel.Width) * x, padding + (padding + cardPanel.Height) * y);
                cardPanel.Click += ClickCard;
                pCartas.Controls.Add(cardPanel);
                x++;
                if (x > 3) { x = 0; y++; }
            }
        }
    }
}