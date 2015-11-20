namespace Engine
{
    ///<summary>
    ///Kelas yang merepresentasikan sebuah petak pada papan permainan
    ///</summary>
    public class Tile
    {
        private int number; //nomor Tile
        private Teleporter isSnake, isLadder;

        ///<summary>
        ///Constructor kelas Tile
        ///</summary>
        /// <param name="num">Indeks petak</param>
        public Tile(int num)
        {
            this.number = num;
            this.isSnake = this.isLadder = null;
        }

        ///<summary>
        ///Method untuk mengganti nomor indeks petak
        ///</summary>
        /// <param name="num">Indeks petak yang baru</param>
        public void SetNumber(int num)
        {
            this.number = num;
        }

        ///<summary>
        ///
        ///</summary>
        public void SetIsSnake(Teleporter isSnake)
        {
            this.isSnake = isSnake;
        }

        public void SetIsLadder(Teleporter isLadder)
        {
            this.isLadder = isLadder;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public Teleporter IsSnake()
        {
            return this.isSnake;
        }

        public Teleporter IsLadder()
        {
            return this.isLadder;
        }

        public Teleporter GetSnakeLadder()
        {
            if (isSnake != null)
            {
                return isSnake;
            }
            else if (isLadder != null)
            {
                return isLadder;
            }
            else
            {
                return null;
            }
        }
    }
}
