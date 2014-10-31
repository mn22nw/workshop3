using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    public interface IObservable
    {
        void AddCardListener(INewCardListener listener);
    }
}
