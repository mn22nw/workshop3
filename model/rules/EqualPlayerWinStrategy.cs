using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class EqualPlayerWinStrategy : IWinEqualStrategy
    {
        //false = spelarn vinner. 
        bool IWinEqualStrategy.Equal(Player a_dealer, Player a_player, int maxScore)
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
            else if(playerScore > dealerScore && playerScore <= maxScore)
            {
                return false;
            }
            else if (dealerScore == playerScore)
            {
                return false; 
            }
         
            return true;
        }
    }
}
