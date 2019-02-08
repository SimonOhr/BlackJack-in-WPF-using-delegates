using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDelegatesBlackJackData
{
    public class AddCardEventArgs : EventArgs
    {
        public Card Card { get; }
        public AddCardEventArgs(Card _card)
        {
            Card = _card;
        }
    }
}
