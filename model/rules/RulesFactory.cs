﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            //return new BasicHitStrategy();
            return new BasicHitAndSoftStrategy();  
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public  IWinEqualStrategy GetWinnerEqual()
        {
            //return new EqualPlayerWinStrategy();
            return new EqualDealerWinStrategy();
        }

    }
}
