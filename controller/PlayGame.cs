using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Blackjack.view.ActionView;

namespace BlackJack.controller
{
    class PlayGame : model.INewCardListener
    {
        private model.Game a_game;
        private view.IView a_view;

        public PlayGame(model.Game game, view.IView view)
        {
            a_game = game;
            a_view = view;
            a_view.DisplayWelcomeMessage();
        }

        public bool Play()
        {
            ActionEnum action = a_view.GetInput();

            if (action == ActionEnum.Play)
            {
                a_game.NewGame();
            }
            else if (action == ActionEnum.Hit)
            {
                a_game.Hit();
            }
            else if (action == ActionEnum.Stand)
            {
                a_game.Stand();
            }

            return action != ActionEnum.Quit;
        }

        public void CardDealed()
        {
            a_view.DisplayWelcomeMessage();
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }
        }
    }
}
