using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : BaseCardDistribution, INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            cardDistribution(a_player, a_deck, true);

            cardDistribution(a_dealer, a_deck, true);

            cardDistribution(a_player, a_deck, true);

            cardDistribution(a_dealer, a_deck, false);

            return true;
        }
    }
}
