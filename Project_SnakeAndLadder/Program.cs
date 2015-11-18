using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

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
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            Board b = new Board();
            Player[] players = { new Player(0, "Player 1"), new Player(0, "Player 2") };
            Dice d = new Dice();
            Game g = new Game(b, players, d);
            g.RunTheGame();
        }
    }
}
