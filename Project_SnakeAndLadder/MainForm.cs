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
            this.DoubleBuffered = true;
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
            Random r = new Random();
            Bitmap background = new Bitmap(Properties.Resources.space);
            Bitmap tile = new Bitmap(Properties.Resources.tile);
            Bitmap finishTile = new Bitmap(Properties.Resources.finish);
            Bitmap snakeHead = new Bitmap(Properties.Resources.blackHole);
            Bitmap snakeTail = new Bitmap(Properties.Resources.whiteHole);
            Bitmap ladderHead = new Bitmap(Properties.Resources.planet);
            Bitmap ladderTail = new Bitmap(Properties.Resources.rocket);
            Graphics g = e.Graphics;
            SolidBrush tileNum = new SolidBrush(Color.Brown);
            SolidBrush snakeNum = new SolidBrush(Color.Red);
            SolidBrush ladderNum = new SolidBrush(Color.White);

            for(int i = 0; i < 500; i += 50)
            {
                g.DrawImage(background, i, 0);
            }

            for(int i = 1; i <= 500; i++)
            {
                g.FillEllipse(ladderNum, r.Next(1, i), r.Next(1, i), 2, 2);
            }

            for (int i = 0; i < 500; i += 50)
            {
                for(int j = 0; j < 500; j += 50)
                {
                    g.DrawImage(tile, i, j, 50, 50);
                }
            }
            g.DrawImage(finishTile, 0, 0, 50, 50);
            for(int i = 0; i < snakes.Length; i++)
            {
                int head = snakes[i].Head;
                int tail = snakes[i].Tail;
                convert.Convert(head+1);
                int headX = (convert.GetX() * 50)+5;
                int headY = 5 + (convert.GetY() * 50);

                convert.Convert(tail+1);
                int tailX = (convert.GetX() * 50) + 5;
                int tailY = 5 + (convert.GetY() * 50);

                g.DrawImage(snakeHead, headX, headY, 40, 40);
                g.DrawImage(snakeTail, tailX, tailY, 40, 40);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), snakeNum, headX+30, headY+30);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), snakeNum, tailX+30, tailY+30);
            }

            for(int i = 0; i < ladders.Length; i++)
            {
                int head = ladders[i].Head;
                int tail = ladders[i].Tail;
                convert.Convert(head+1);
                int headX = (convert.GetX() * 50) + 5;
                int headY = 5 + (convert.GetY() * 50);

                convert.Convert(tail+1);
                int tailX = (convert.GetX() * 50) + 5;
                int tailY = 5 + (convert.GetY() * 50);

                g.DrawImage(ladderHead, headX, headY, 40, 40);
                g.DrawImage(ladderTail, tailX, tailY, 40, 40);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), ladderNum, headX + 30, headY + 30);
                g.DrawString((i + 1 + ""), new Font("Comic Sans MS", 7), ladderNum, tailX + 30, tailY + 30);
            }

            for (int i = 100; i > 0; i--)
            {
                convert.Convert(i);
                int xPos = (convert.GetX() * 50);
                int yPos = (convert.GetY() * 50);
                g.DrawString((i+""), new Font("Comic Sans MS", 10), tileNum, xPos, yPos);
            }
            convert.Convert(game.GetPlayerAtTurn(0).GetPosition()+1);
            int x = convert.GetX()*50;
            int y = convert.GetY()*50;
            g.DrawImage(playerAvatars[0], x, y, 50, 50);

            convert.Convert(game.GetPlayerAtTurn(1).GetPosition() + 1);
            x = convert.GetX() * 50;
            y = convert.GetY() * 50;
            g.DrawImage(playerAvatars[1], x, y, 50, 50);
        }

        private void buttonKocok_Click(object sender, EventArgs e)
        {
            if (game.GetCurrentTurn() % 2 == 0)
            {
                Player currentPlayer = game.GetCurrentPlayer();
                game.RunTheGame();
                if (!game.GetPlayerAtTurn(1).IsCompPlayer()&&game.GetCurrentTurn()%2==1) buttonKocok.Enabled = false;
                int dice = currentPlayer.GetDiceNum();
                labelDice1.Text = "Keluaran\n"+ currentPlayer.GetName() + ":\n" + dice;
                Invalidate();
                if (game.GetWinner() != null)
                {
                    MessageBox.Show(game.GetWinnerInformation() + " menang!", "Message");
                    buttonKocok.Enabled = false;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.R)&&(game.GetCurrentTurn()%2==1)&&game.GetWinner()==null)
            {
                Player currentPlayer = game.GetCurrentPlayer();
                game.RunTheGame();
                if(game.GetCurrentTurn()%2==0) buttonKocok.Enabled = true;
                int dice = currentPlayer.GetDiceNum();
                labelDice2.Text = "Keluaran\n" + currentPlayer.GetName() + ":\n" + dice;
                Invalidate();
                if (game.GetWinner() != null)
                {
                    MessageBox.Show(game.GetWinnerInformation() + " menang!", "Message");
                    buttonKocok.Enabled = false;
                }
            }
        }
    }
}
