using System;
namespace Engine
{
    /// <summary>
    /// Kelas yang merepresentasikan sebuah papan permainan.
    /// </summary>
    public class Board
    {
        private Tile[] tiles;
        private Snake[] snakeSet;
        private Ladder[] ladderSet;

        /// <summary>
        /// Field untuk menyimpan dan mengembalikan semua snake
        /// </summary>
        public Snake[] Snakes
        {
            get
            {
                return snakeSet;
            }
            set
            {
                snakeSet = value;
            }
        }

        /// <summary>
        /// Field untuk menyimpan dan mengembalikan semua ladder
        /// </summary>
        public Ladder[] Ladders
        {
            get
            {
                return ladderSet;
            }
            set
            {
                ladderSet = value;
            }
        }

        ///<summary>
        ///Constructor kelas Board.
        ///</summary>
        public Board()
        {
            this.tiles = new Tile[100];
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new Tile(i);
            }
            snakeSet = new Snake[8];
            ladderSet = new Ladder[8];
            GenerateBoard();
        }

        /// <summary>
        /// Method untuk meng-generate board
        /// Method ini menentukan posisi snake dan ladder di Tile
        /// </summary>
        private void GenerateBoard()
        {
            Random r = new Random();
            int count = 0;
            int start = 0;
            int end = 0;
            while (count < 8)
            {
                start = r.Next(2, 99);
                end = r.Next(2, 99);
                if ((start < end) && IsValidSnakeLadder(tiles[start], tiles[end]))
                {
                    Ladder l = new Ladder(end, start);
                    tiles[start].SetIsLadder(l);
                    tiles[end].SetIsLadder(l);
                    ladderSet[count] = l;
                    count++;
                }
            }
            count = start = end = 0;
            while (count < 8)
            {
                start = r.Next(2, 99);
                end = r.Next(2, 99);
                if ((start > end) && IsValidSnakeLadder(tiles[start], tiles[end]))
                {
                    Snake s = new Snake(start, end);
                    tiles[start].SetIsSnake(s);
                    tiles[end].SetIsSnake(s);
                    snakeSet[count] = s;
                    count++;
                }
            }
        }

        /// <summary>
        /// Method ini mengembalikan true bila snake atau ladder belum ada di t1 dan t2
        /// false bila snake atau ladder sudah ada di t1 dan t2
        /// </summary>
        /// <param name="t1"> tile yang ingin diperiksa</param>
        /// <param name="t2"> tile yang ingin diperiksa</param>
        /// <returns>true bila tidak ada snake atau ladder, false jika ada snake atau ladder</returns>
        private bool IsValidSnakeLadder(Tile t1, Tile t2)
        {
            if (t1.GetSnakeLadder() != null || t2.GetSnakeLadder() != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method untuk mendapatkan semua petak pada papan.
        /// </summary>
        /// <returns>Semua kotak/tile</returns>
        public Tile[] GetTiles()
        {
            return tiles;
        }

        /// <summary>
        /// Method untuk mendapatkan petak dengan nomor tertentu
        /// </summary>
        /// <param name="num">Indeks petak yang akan dikembalikan</param>
        /// <returns>petak dengan nomor tertentu</returns>
        public Tile GetTile(int num)
        {
            return tiles[num];
        }
    }
}
