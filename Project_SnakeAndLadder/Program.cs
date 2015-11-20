using System;
using Engine;
using System.Windows.Forms;

namespace Project_SnakeAndLadder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
            /*Board b = new Board();
            Player[] players = { new Player(0, "Player 1", false), new Player(0, "Player 2", true) };
            Dice d = new Dice();
            Game g = new Game(b, players, d);
            while (g.GetWinner() == null)
            {
                Player current = g.GetCurrentPlayer();
                if (!current.IsCompPlayer())
                {
                    Console.Write("{0}'s turn to move: ", current.GetName());
                    Console.ReadLine();
                }
                g.RunTheGame();
            }*/
        }
    }
}
