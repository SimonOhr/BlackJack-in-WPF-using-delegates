using System;

namespace TheDelegatesBlackJackData
{
    public class AddCardEventArgs : EventArgs
    {
        public Card Card { get; }
        public AddCardEventArgs(Card _card) => Card = _card;       
    }
}
