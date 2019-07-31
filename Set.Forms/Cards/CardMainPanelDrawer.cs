using System.Windows.Forms;
using System.Drawing;
using Set.Core;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Set.Forms
{
    public class MainPanelDrawer
    {
        private const int cardsPerRow = 3;
        private const int padding = 24;
       
        private readonly Panel mainPanel;
        private readonly Action onCardClicked;
        private readonly CardDrawer cardDrawer;
        private int x;
        private int y;
        private int helpCount;

        public bool IsTrioSelected => mainPanel.Controls.OfType<CardPanel>().Count(x => x.Seleccionada) == 3;
        public CardTrio SelectedTrio => new CardTrio(mainPanel.Controls.OfType<CardPanel>().Where(x => x.Seleccionada).Select(x => x.Card));

        public MainPanelDrawer(Panel mainPanel, Action onCardClicked)
        {
            this.mainPanel = mainPanel;
            this.onCardClicked = onCardClicked;
            cardDrawer = new CardDrawer();
        }

        internal void Draw(IEnumerable<ICard> cardList)
        {
            helpCount = 0;
            x = y = 0;
            mainPanel.Controls.Clear();
            foreach (var card in cardList)
            {
                CardPanel cardPanel = CreateCardPanel(x, y, card);
                mainPanel.Controls.Add(cardPanel);
                x++;
                if (x > cardsPerRow)
                {
                    x = 0;
                    y++;
                }
            }
        }

        private CardPanel CreateCardPanel(int x, int y, ICard card)
        {
            var cardPanel = cardDrawer.Draw(card);
            cardPanel.Location = new Point(padding + (padding + cardPanel.Width) * x, padding + (padding + cardPanel.Height) * y);
            cardPanel.Click += (sender, e) =>
            {
                var selectedCard = (sender as CardPanel);
                selectedCard.Seleccionar(!cardPanel.Seleccionada);
                onCardClicked.Invoke();
            };
            return cardPanel;
        }

        public void ShowHelp()
        {
            var cards = mainPanel.Controls.OfType<CardPanel>().Select(panel => panel.Card);
            var sets = new SetFinder(cards).Find();
            var selectedSet = sets.ElementAt(helpCount);

            DeselectAll();
            SelectCardTrio(selectedSet);
            helpCount = helpCount + 1 < sets.Count() ? helpCount + 1 : 0;
        }

        private void DeselectAll()
        {
            foreach (var cardPanel in mainPanel.Controls.OfType<CardPanel>().Where(x => x.Seleccionada))
                cardPanel.Seleccionar(false);
        }

        private void SelectCardTrio(CardTrio cardTrio)
        {
            var cardPanels = mainPanel.Controls.OfType<CardPanel>().Where(x => cardTrio.Contains(x.Card));
            foreach (var panel in cardPanels)
                panel.Seleccionar(true);
        }
    }
}