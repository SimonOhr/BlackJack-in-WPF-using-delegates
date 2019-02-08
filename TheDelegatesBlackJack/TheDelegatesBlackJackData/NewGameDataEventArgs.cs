using System;

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
