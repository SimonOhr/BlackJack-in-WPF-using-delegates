using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheDelegatesBlackJackLogic;
using TheDelegatesBlackJackData;

namespace TheDelegatesBlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public delegate void AddCardEventHandler(object source, EventArgs args);
        public event AddCardEventHandler AddCard;

        public delegate void NextPlayerEventHandler(object source, EventArgs args);
        public event NextPlayerEventHandler Next;

        public delegate void PassPlayerEventHandler(object source, PassPlayerEventArgs args);
        public event PassPlayerEventHandler UpdatePlayer;

        New_Game_Window newGameWin;
        GameManager gm;

        /// <summary>
        /// Creates the GmaeManager and immidietly subsribes gm.OnHit adn gm.OnNewPlayer to AddCard and NExt events.
        /// ALso initiates the game with disabled buttons which would otherwise cause exceptions if pressed.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            gm = new GameManager();

            AddCard += gm.OnHit;
            Next += gm.OnNewPlayer;

            ViewNextBtn.IsEnabled = false;
            HitBtn.IsEnabled = false;
            HoldBtn.IsEnabled = false;
            ShuffleBtn.IsEnabled = false;
        }
        /// <summary>
        /// Initiates a new xaml window for inputting start values.
        /// Also subscribes the gm.Init function wich gets triggered by said xaml window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameClick(object sender, RoutedEventArgs e)
        {
            try
            {
                newGameWin = new New_Game_Window(this);
                newGameWin.InitializeComponent();
                newGameWin.OnNewGame += gm.Init;
                newGameWin.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());               
            }
        }
        /// <summary>
        /// gets called when the player has given an input to
        /// </summary>
        public void NewGameStarted()
        {
            OnPlayerUpdate(gm.CurrentPlayer);
            OnPlayerUpdate(gm.Dealer);

            ViewNextBtn.IsEnabled = true;
            HitBtn.IsEnabled = true;
            HoldBtn.IsEnabled = true;
            ShuffleBtn.IsEnabled = true;
        }
        /// <summary>
        /// Cycles through to teh next player. If last, begins again at 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewNextClick(object sender, RoutedEventArgs e)
        {
            try
            {
                gm.ViewNext();
                OnPlayerUpdate(gm.ViewPlayer);
                OnPlayerUpdate(gm.Dealer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// Triggers the AddCard event if the current player "is alive"
        /// Adds a new card to the current player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HitClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!gm.CurrentPlayer.HasHeld 
                    && !gm.CurrentPlayer.HasLost
                    && !gm.CurrentPlayer.IsWinner)
                    if (AddCard != null)
                        AddCard(this, EventArgs.Empty);

                OnPlayerUpdate(gm.CurrentPlayer);
                OnPlayerUpdate(gm.Dealer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        /// <summary>
        /// Triggers the Next event, switching to another player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!gm.CurrentPlayer.IsDealer)
                    if (Next != null)
                        Next(this, EventArgs.Empty);

                OnPlayerUpdate(gm.CurrentPlayer);
                OnPlayerUpdate(gm.Dealer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// Forces a reshuffle of the discarded cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShuffleClick(object sender, RoutedEventArgs e)
        {
            try
            {
                gm.CheckCards(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Updates the playercontroller.
        /// </summary>
        /// <param name="player"></param>
        private void OnPlayerUpdate(Player player)
        {
            UpdatePlayer = null;
            gm.Eval();
            if (player.IsDealer)
                UpdatePlayer += DealerController.UpdatePlayerInfo;
            else
                UpdatePlayer += PlayerController.UpdatePlayerInfo;
            if (UpdatePlayer != null)
                UpdatePlayer(this, new PassPlayerEventArgs(player));
        }
    }
}
