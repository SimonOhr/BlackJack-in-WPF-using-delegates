using System;
using System.Collections.Generic;
using System.Linq;
using TheDelegatesBlackJackData;

namespace TheDelegatesBlackJackLogic
{
    public class GameManager
    {
        Stack<Card> activeCards = new Stack<Card>();
        List<Card> nonActiveCards = new List<Card>();
        List<Player> players = new List<Player>();
        public Player CurrentPlayer { get; private set; }
        public Player ViewPlayer { get; set; }
        public Player Dealer { get; private set; }
        int viewNextIterator = 0;
        int originDeckSize;
        public GameManager() { }

        /// <summary>
        /// Clears any previous game session.
        /// Sets up the game with the values passed by the new game window in the NewGameEventArgs.
        /// Sets the currentplayer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Init(object sender, NewGameDataEventArgs args)
        {
            activeCards.Clear();
            players.Clear();
            viewNextIterator = 0;

            originDeckSize = args.Decks;         
            SetupDecks(args.Decks);
            SetupPlayers(args.Players);
            SetupDealer();           
            
            CurrentPlayer = players.First();
        }
        /// <summary>
        /// Gets the Decks from the DeckBuilder
        /// </summary>
        /// <param name="_amount"></param>
        void SetupDecks(int _amount)
        {
            List<Card> temp = new DeckBuilder(_amount).ReturnListDecks();
            temp.Shuffle();
            foreach (Card item in temp)            
                activeCards.Push(item);
            
        }
        /// <summary>
        /// initiates, and adds teh players
        /// all players start with 2 cards
        /// </summary>
        /// <param name="_amount"></param>
        void SetupPlayers(int _amount)
        {
            Card poppedCard;

            for (int i = 0; i < _amount; i++)            
                players.Add(new Player(i));
            

            foreach (Player item in players)
            {
                item.DrawCard(poppedCard = activeCards.Pop());
                nonActiveCards.Add(poppedCard);
                item.DrawCard(poppedCard = activeCards.Pop());
                nonActiveCards.Add(poppedCard);
            }
        }
        /// <summary>
        /// initiates the dealer.
        /// dealer start with 1 card
        /// </summary>
        void SetupDealer()
        {
            Card poppedCard;

            Dealer = new Player(0, true);
            Dealer.DrawCard(poppedCard = activeCards.Pop());
            nonActiveCards.Add(poppedCard);
        }
        /// <summary>
        /// Eval determine if the player or dealer has won, lost or if their at max Score in which case they hold automatically.
        /// </summary>
        public void Eval()
        {
            if (CurrentPlayer.Score == 21)
                CurrentPlayer.HasHeld = true;
            else if (CurrentPlayer.Score > 21)
                CurrentPlayer.HasLost = true;

            if (CurrentPlayer.IsDealer)
            {
                List<Player> temp = players.FindAll(x => x.Score <= Dealer.Score && Dealer.Score <= 21);

                if (temp.Count >= 1)
                    foreach (Player item in temp)
                        item.HasLost = true;

                if (temp.Count == players.Count)
                    Dealer.IsWinner = true;
            }
            if (Dealer.HasLost)
                foreach (Player item in players)
                    if (!item.HasLost)
                        item.IsWinner = true;
        }     
      /// <summary>
      /// Cehcks if it is necessary to reshuffle the deck. It is possible to force a reshuffle.
      /// </summary>
      /// <param name="force"></param>
        public void CheckCards(bool force)
        {
            if (activeCards.Count < 10 || force)
            {
                for (int i = 0; i < activeCards.Count; i++)                
                    nonActiveCards.Add(activeCards.Pop());
                
                nonActiveCards.Shuffle();

                for (int i = 0; i < nonActiveCards.Count; i++)                
                    activeCards.Push(nonActiveCards[i]);                
            }
        }
        /// <summary>
        /// Cycles through all players
        /// *Note, not synced with current player which is why sometimes you need to press the viewplayers button a few times
        /// before it switches player (if current player is player 0 then the first press on viewplayers won't switch player) This can be fixed but it didn't feel important for teh assignment
        /// </summary>
        public void ViewNext()
        {
            if (viewNextIterator < players.Count - 1)
                viewNextIterator++;
            else
                viewNextIterator = 0;
            ViewPlayer = players[viewNextIterator];
        }
        /// <summary>
        /// Adds a card to teh currentplayer. then does an auomatic check to see if the deck needs to be reshuffled
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        public void OnHit(object source, EventArgs args)
        {
            if (!CurrentPlayer.HasLost)
            {
                Card poppedCard;
                CurrentPlayer.DrawCard(poppedCard = activeCards.Pop());
                nonActiveCards.Add(poppedCard);
            }
            //Eval();
            CheckCards(false);
        }
        /// <summary>
        /// siwtches to teh next player which is still in play
        /// if no "alive" players can be found it switches to the dealers turn.
        /// if all players have lost it immidietly declares teh dealer a winner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnNewPlayer(object sender, EventArgs args)
        {
            CurrentPlayer.HasHeld = true;
            if (players.Exists(x => !x.HasHeld && !x.HasLost))
                CurrentPlayer = players.Find(x => !x.HasHeld && !x.HasLost);
            else if (players.Exists(x => !x.HasLost))
                CurrentPlayer = Dealer;
            else
            {               
                CurrentPlayer = Dealer;
                Dealer.IsWinner = true;
            }              
        }
    }
}
