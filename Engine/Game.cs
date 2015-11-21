using System;
namespace Engine
{
    ///<summary>
    ///kelas controller.
    /// yang menjalankan semua proses yang diperlukan untuk menjalankan game ini.
    ///</summary>
    public class Game
    {
        private const int GAME_TYPE1 = 1;//permainan untuk manusia vs manusia

        private const int GAME_TYPE2 = 2;//permainan untuk manusia vs komputer

        private int playingTurn;//penanda giliran pemain

        ///<summary>
        /// Atribut yang menyimpan board.
        ///</summary>
        private Board papan;

        ///<summary>
        /// Atribut yang menyimpan banyak player yang ada didalam game.
        ///</summary>
        private Player[] players;

        ///<summary>
        /// Atribut yang menyimpan object player yang menang.
        ///</summary>
        private Player winner;

        ///<summary>
        /// Atribut yang menyimpan object Dice.
        ///</summary>
        private Dice dice;

        ///<summary>
        /// Atribut yang menyimpan int banyak player.
        ///</summary>
        private int totalPlayer;

        ///<summary>
        /// Konstruktor.
        ///</summary>
        public Game(Board b, Dice d,int gameType)
        {
            this.dice = d;
            this.papan = b;
            if (gameType == GAME_TYPE1)
            {
                players = new Player[] { new Player(0, "Player 1", false), new Player(0, "Player 2", false) };
            }
            else
            {
                players = new Player[] { new Player(0, "Player 1", false), new Player(0, "Computer", true) };
            }
            this.winner = null;
            this.totalPlayer = players.Length;
            this.playingTurn = 0;
        }

        ///<summary>
        /// Method untuk menjalankan permainan ular tangga.
        ///</summary>
        public void RunTheGame()
        {
            //suruh player gerak dengan mengocok dadu
            //dan mentukan posisi barunya.
            players[playingTurn].Move(this.dice);
            int pos = players[playingTurn].GetPosition();
            Console.WriteLine("{0}'s current position: {1}", players[playingTurn].GetName(), pos);
            //apakah player pada posisi tersebut
            //menemukan tangga atau ular.
            Teleporter snakeLadder = papan.GetTile(pos).GetSnakeLadder();
            if (snakeLadder != null)
            {
                snakeLadder.MovePlayer(players[playingTurn]);
                Console.WriteLine("{0}'s current position: {1}", players[playingTurn].GetName(), pos);
            }
            /*
            int newPos = papan.getIntoTile();
            players[turn].setPosition(newPos);
            */
            //setiap pergerakan player,
            //lakukan pengecekan apakah dia sudah mencapai finish
            if (players[playingTurn].IsWin())
            {
                SetWinner(players[playingTurn]);
                Console.WriteLine("Winner: {0}", GetWinnerInformation());
            }

            //giliran player lain.
            playingTurn = playingTurn + 1;
            //setelah semua telah mendapat giliran bermain,
            //dikembalikan ke giliran pertama.
            if (playingTurn == this.totalPlayer)
            {
                playingTurn = 0;
            }            
        }        
        
        ///<summary>
        /// Method untuk menentukan pemenang.
        ///</summary>
        public void SetWinner(Player p)
        {
            this.winner = p;
        }

        ///<summary>
        ///Getter untuk atribut winner
        ///Mengembalikan Player yang menang
        ///</summary>
        public Player GetWinner()
        {
            return winner;
        }

        ///<summary>
        ///Mengembalikan Player yang sedang bermain sekarang
        ///</summary>
        public Player GetCurrentPlayer()
        {
            return players[playingTurn];
        }

        ///<summary>
        ///Mengembalikan informasi nama pemenang.
        ///</summary>
        public string GetWinnerInformation()
        {
            return this.winner.GetName();
        }
    }

}
