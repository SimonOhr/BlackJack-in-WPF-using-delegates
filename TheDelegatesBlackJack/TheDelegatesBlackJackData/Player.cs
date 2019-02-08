using System.Collections.Generic;

namespace TheDelegatesBlackJackData
{
    public class Player
    {
        public int Name { get; private set; }
        public List<Card> Cards { get; private set; }
        /// <summary>
        /// returns the score of the player
        /// </summary>
        public int Score
        {
            get
            {
                return CalcScore();
            }
        }
        public bool IsDealer { get; private set; }
        public bool HasHeld { get; set; }
        public bool HasLost { get; set; }
        public bool IsWinner { get; set; }
        public Player(int _name, bool isDealer = false)
        {
            Name = _name;
            IsDealer = isDealer;
            Cards = new List<Card>();
        }
        /// <summary>
        /// adds a card to teh player
        /// </summary>
        /// <param name="_card"></param>
        public void DrawCard(Card _card) => Cards.Add(_card);
       
        /// <summary>
        /// calculates the score of the player
        /// </summary>
        /// <returns></returns>
        int CalcScore()
        {
            var temp = 0;
            foreach (Card item in Cards)            
                temp += item.Value;
            
            if (temp > 21)
                HasLost = true;
            return temp;
        }
    }
}
