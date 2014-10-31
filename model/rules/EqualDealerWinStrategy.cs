using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class EqualDealerWinStrategy : IWinEqualStrategy
    {
        public bool Equal(Player a_dealer, Player a_player, int maxScore)
        {
            int dealerScore = a_dealer.CalcScore(); 
            int playerScore = a_player.CalcScore();

            if (playerScore > maxScore)
            {
                return true;
            }
            else if (dealerScore > maxScore)
            {
                return false;
            }
            else if (dealerScore > playerScore && dealerScore <= maxScore)
            {
                return true;
            }
            else if (dealerScore == playerScore)
            {
                return true;
            }
           
            return false;
        }
    }
}
