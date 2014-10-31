using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class BasicHitAndSoftStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            int scoreCards = a_dealer.CalcScore();

            if (scoreCards == g_hitLimit)
            {
                int count = 0; 
                foreach (Card c in a_dealer.GetHand()) {
                    if(c.GetValueHidden() == Card.Value.Ace) {
                        count += 1;
                    }

                    if(c.GetValueHidden() == Card.Value.Six)
                    {
                        count += 1;
                    }
                }

                // får ta ett till kort vid 17 poäng om korten är ett ess och en sexa.
                if (count == 2)
                {
                    return scoreCards <= g_hitLimit;
                }
                else
                {
                    return scoreCards < g_hitLimit;
                }
            }
            else
            {
                return scoreCards < g_hitLimit;
            }
        }
    }
}