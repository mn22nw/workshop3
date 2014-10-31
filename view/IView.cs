using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blackjack.view.ActionView;

namespace BlackJack.view
{
    interface IView
    {
        void DisplayWelcomeMessage();
        ActionEnum GetInput();
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
    }
}
