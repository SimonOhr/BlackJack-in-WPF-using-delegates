using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDelegatesBlackJackData;

namespace TheDelegatesBlackJackLogic
{
    class DeckBuilder
    {
        int count;
        Dictionary<int, string> suits = new Dictionary<int, string>();       
        List<Card> decks = new List<Card>();
        public DeckBuilder(int _count)
        {
            count = _count;
            SetupDictionary();
        }
        /// <summary>
        /// returns a list of decks
        /// </summary>
        /// <returns></returns>
        public List<Card> ReturnListDecks()
        {
            for (int i = 0; i < count; i++)
            {
                decks.AddRange(ConstructDeck());
            }
            return decks;
        }
        /// <summary>
        /// returns a stack of decks
        /// </summary>
        /// <returns></returns>
        public Stack<Card> ReturnStackDecks()
        {
            for (int i = 0; i < count; i++)
            {
                decks.AddRange(ConstructDeck());
            }
            return ListToStackConversion<Card>.ListToStack(decks); ;
        }
        /// <summary>
        /// Cunstructs a deck
        /// </summary>
        /// <returns></returns>
        List<Card> ConstructDeck()
        {
            List<Card> deck = new List<Card>(52);
            for (int i = 0; i < 4; i++)
            {
                var currentSuit = suits[i];
                for (int j = 2; j < 15; j++)
                {
                    if (j < 11)
                        deck.Add(new Card(currentSuit, j, CardType.Numerical));
                    else if (j == 11)
                        deck.Add(new Card(currentSuit, j, CardType.Jack));
                    else if (j == 12)
                        deck.Add(new Card(currentSuit, j, CardType.Queen));
                    else if (j == 13)
                        deck.Add(new Card(currentSuit, j, CardType.King));
                    else
                        deck.Add(new Card(currentSuit, j, CardType.Ace));
                }
            }
            return deck;
        }
        /// <summary>
        /// initiates adictionary, so that the deck gets the appropriate suits
        /// </summary>
        void SetupDictionary()
        {
            suits.Add(0, "Hearts");
            suits.Add(1, "Spades");
            suits.Add(2, "Clubs");
            suits.Add(3, "Diamonds");
        }        
    }
}
