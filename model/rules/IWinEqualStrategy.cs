using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IWinEqualStrategy
    {
        bool Equal(Player a_dealer, Player a_player, int maxScore);
    }
}
