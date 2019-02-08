using System;

namespace TheDelegatesBlackJackData
{
    /// <summary>
    /// The only EventArgs extension which relies on an object 
    /// </summary>
    public class PassPlayerEventArgs : EventArgs
    {
        public Player Player { get; }
        public PassPlayerEventArgs(Player _player) => Player = _player;      
    }
}
