using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Game : IObservable
    {
        private List<INewCardListener> m_listener;
        private model.Dealer m_dealer;
        private model.Player m_player;

        public Game()
        {
            m_dealer = new Dealer(new rules.RulesFactory());
            m_player = new Player();
            m_listener = new List<INewCardListener>();
        }

        public bool IsGameOver()
        {
            return m_dealer.IsGameOver();
        }

        public bool IsDealerWinner()
        {
            return m_dealer.IsDealerWinner(m_player);
        }

        public bool NewGame()
        {
            var newGame = m_dealer.NewGame(m_player);
            NotifyController();
            return newGame;
        }

        public bool Hit()
        {
            var hit = m_dealer.Hit(m_player);
            NotifyController();
            return hit;
        }

        public bool Stand()
        {
            m_dealer.Stand();
            NotifyController();
            return true;
        }

        public IEnumerable<Card> GetDealerHand()
        {
            return m_dealer.GetHand();
        }

        public IEnumerable<Card> GetPlayerHand()
        {
            return m_player.GetHand();
        }

        public int GetDealerScore()
        {
            return m_dealer.CalcScore();
        }

        public int GetPlayerScore()
        {
            return m_player.CalcScore();
        }

        public void NotifyController()
        {
            foreach (var listener in m_listener)
            {
                listener.CardDealed();
            }
        }

        public void AddCardListener(INewCardListener listener)
        {
            m_listener.Add(listener);
        }
    }
}

   