using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDelegatesBlackJackData
{
    public class NewGameDataEventArgs:EventArgs
    {
        public int Decks { get; }
        public int Players { get; }
        public NewGameDataEventArgs(int _decks, int _players)
        {
            Decks = _decks;
            Players = _players;
        }
    }
}
