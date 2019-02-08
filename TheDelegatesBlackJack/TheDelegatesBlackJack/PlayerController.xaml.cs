using System.Windows.Controls;
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
            var playerState = "";
            if (args.Player.HasLost)
                playerState = "Loser";
            else if (args.Player.IsWinner)
                playerState = "Winner";
            else
                playerState = "";

            if (playerState != "")
                Message(playerState);
        }
        /// <summary>
        /// User feedback, win, lose or not
        /// </summary>
        /// <param name="value"></param>
        void Message(string value) => PlayerCardOutput.Text = value;
    }
}
