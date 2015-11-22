using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Project_SnakeAndLadder
{
    public partial class MainForm : Form
    {
        private Game game;
        private Board b;
        private Snake[] snakes;
        private Ladder[] ladders;
        private Bitmap[] playerAvatars;

        public MainForm(int gameType)
        {
            InitializeComponent();
            b = new Board();
            snakes = b.Snakes;
            ladders = b.Ladders;
            game = new Game(b, new Dice(), gameType);
            if (gameType == 1)
            {
                playerAvatars = new Bitmap[] { new Bitmap(Properties.Resources.player1), new Bitmap(Properties.Resources.player2) };
            }
            else
            {
                playerAvatars = new Bitmap[] { new Bitmap(Properties.Resources.player1), new Bitmap(Properties.Resources.playerComp) };
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap tile = new Bitmap(Properties.Resources.tile);
            Bitmap finishTile = new Bitmap(Properties.Resources.finish);
            Bitmap snakeHead = new Bitmap(Properties.Resources.blackHole);
            Bitmap snakeTail = new Bitmap(Properties.Resources.whiteHole);
            Bitmap ladderHead = new Bitmap(Properties.Resources.planet);
            Bitmap ladderTail = new Bitmap(Properties.Resources.rocket);
            Graphics g = e.Graphics;
            SolidBrush tileNum = new SolidBrush(Color.Brown);
            SolidBrush snakeNum = new SolidBrush(Color.Red);
            SolidBrush ladderNum = new SolidBrush(Color.Blue);
        }
    }
}
