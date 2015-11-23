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
        private Converter convert;

        public MainForm(int gameType)
        {
            InitializeComponent();
            b = new Board();
            snakes = b.Snakes;
            ladders = b.Ladders;
            convert = new Converter();
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
            Bitmap snakeHead = new Bitmap(Properties.Resources.whiteHole);
            Bitmap snakeTail = new Bitmap(Properties.Resources.blackHole);
            Bitmap ladderHead = new Bitmap(Properties.Resources.rocket);
            Bitmap ladderTail = new Bitmap(Properties.Resources.planet);
            Graphics g = e.Graphics;
            SolidBrush tileNum = new SolidBrush(Color.Brown);
            SolidBrush snakeNum = new SolidBrush(Color.Red);
            SolidBrush ladderNum = new SolidBrush(Color.White);
            
            for(int i = 0; i < 500; i += 50)
            {
                for(int j = 0; j < 500; j += 50)
                {
                    g.DrawImage(tile, i, j, 50, 50);
                }
            }

            for(int i = 0; i < snakes.Length; i++)
            {
                int head = snakes[i].Head;
                int tail = snakes[i].Tail;
                convert.Convert(head);
                int headX = (convert.GetX() * 50)+5;
                int headY = 455 - (convert.GetY() * 50);

                convert.Convert(tail);
                int tailX = (convert.GetX() * 50) + 5;
                int tailY = 455 - (convert.GetY() * 50);

                g.DrawImage(snakeHead, headX, headY, 40, 40);
                g.DrawImage(snakeTail, tailX, tailY, 40, 40);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), snakeNum, headX+30, headY+30);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), snakeNum, tailX+30, tailY+30);
            }

            for(int i = 0; i < ladders.Length; i++)
            {
                int head = ladders[i].Head;
                int tail = ladders[i].Tail;
                convert.Convert(head);
                int headX = (convert.GetX() * 50) + 5;
                int headY = 455 - (convert.GetY() * 50);

                convert.Convert(tail);
                int tailX = (convert.GetX() * 50) + 5;
                int tailY = 455 - (convert.GetY() * 50);

                g.DrawImage(ladderHead, headX, headY, 40, 40);
                g.DrawImage(ladderTail, tailX, tailY, 40, 40);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), ladderNum, headX + 30, headY + 30);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), ladderNum, tailX + 30, tailY + 30);
            }

            for (int i = 100; i > 0; i--)
            {
                convert.Convert(i);
                int x = (convert.GetX() * 50);
                int y = (convert.GetY() * 50);
                g.DrawString((i+""), new Font("Comic Sans MS", 10), tileNum, x, y);
            }
        }
    }
}
