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
using TheDelegatesBlackJackData;


namespace TheDelegatesBlackJack
{
    /// <summary>
    /// Interaction logic for PlayerController.xaml
    /// </summary>
    public partial class PlayerController : UserControl
    {
        public string PlayerName { get; private set; }      
        public int PlayerScore { get; set; }
        public PlayerController()
        {                   
            InitializeComponent();
            PlayerNameOutput.Text = "Name Default";
            PlayerScoreOutput.Text = "PlayerScore Default";          
        }
        /// <summary>
        /// Updates all of the playerinformation of teh PLayerController with the information from the player, which is passed in the PassPlayerEventArgs.
        /// *Originally i had this setup in anotherway that didn't expose a player object. But I find this way to be a lot cleaner
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        public void UpdatePlayerInfo(object source, PassPlayerEventArgs args)
        {
            PlayerNameOutput.Text = args.Player.Name.ToString();

            PlayerCardOutput.Text = "";
            for (int i = 0; i < args.Player.Cards.Count; i++)
            {
                PlayerCardOutput.Text += args.Player.Cards[i].Value + " of " + args.Player.Cards[i].Suit + " " + args.Player.Cards[i].type + "\n";
            }

            PlayerScoreOutput.Text = args.Player.Score.ToString();

            if (args.Player.HasLost)
                Message("Loser");
            else if (args.Player.IsWinner)
                Message("Winner");
            else
                Message(null);
        }

        void Message(string value)
        {
            if (value != null)
                PlayerCardOutput.Text = value;
        }
    }
}
