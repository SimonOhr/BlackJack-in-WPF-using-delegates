using System;
using System.Windows;
using TheDelegatesBlackJackData;


namespace TheDelegatesBlackJack
{
    /// <summary>
    /// Interaction logic for New_Game_Window.xaml
    /// </summary>
    public partial class New_Game_Window : Window
    {
        public delegate void GetNewGameVariablesEventhandler(object sender, NewGameDataEventArgs args);
        public event GetNewGameVariablesEventhandler OnNewGame;
        MainWindow main;

        public New_Game_Window(MainWindow _main)
        {
            InitializeComponent();
            main = _main;
        }
        /// <summary>
        /// triggers an initiate function in GameMangaer and then calls the main window to inform it, it's done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OnNewGame != null)
                    OnNewGame(this, new NewGameDataEventArgs(Int32.Parse(DeckInput.Text.ToString()), Int32.Parse(PlayerInput.Text.ToString())));
                main.NewGameStarted();
            }
            catch (Exception)
            {

                PlayerInput.Text = "Please only insert numbers here";
                DeckInput.Text = "Please only insert numbers here";
            }

            this.Close();
        }
    }
}
