using System;
namespace Engine
{
    class Board
    {
        private Tile[] tiles;

        public Board()
        {
            this.tiles = new Tile[100];
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new Tile(i);
            }
            GenerateBoard();
        }

        public void GenerateBoard()
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
                    //tiles[start].setSnake(true);
                    tiles[start].SetIsSnake(new Ladder(end, start));
                    tiles[end].SetIsSnake(new Ladder(end, start));
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
                    //tiles[start].setSnake(true);
                    tiles[start].SetIsLadder(new Snake(start, end));
                    tiles[end].SetIsLadder(new Snake(start, end));
                    count++;
                }
            }
        }
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

        public Tile[] GetTiles()
        {
            return tiles;
        }

        public Tile GetTile(int num)
        {
            return tiles[num];
        }
    }
}
