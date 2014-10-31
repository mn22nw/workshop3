using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
   abstract class BaseCardDistribution
    {
        public void cardDistribution(Player p, Deck d , bool showBool)
        {
            Card c;
             c = d.GetCard();
             c.Show(showBool);
             p.DealCard(c);
        }
    }
}
