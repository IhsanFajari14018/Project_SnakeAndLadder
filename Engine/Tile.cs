namespace Engine
{
    ///<summary>
    ///Kelas yang merepresentasikan sebuah petak pada papan permainan
    ///</summary>
    public class Tile
    {
        private int number; //nomor Tile
        private Teleporter isSnake, isLadder;

        /// <summary>
        /// Constructor kelas Tile
        /// </summary>
        /// <param name="num">Indeks petak</param>
        public Tile(int num)
        {
            this.number = num;
            this.isSnake = this.isLadder = null;
        }

        /// <summary>
        /// Method untuk mengganti nomor indeks petak
        /// </summary>
        /// <param name="num">Indeks petak yang baru</param>
        public void SetNumber(int num)
        {
            this.number = num;
        }

        /// <summary>
        /// Method untuk mengganti teleporter ular yang ada pada petak
        /// </summary>
        /// <param name="isSnake">Teleporter ular yang baru</param>
        public void SetIsSnake(Teleporter isSnake)
        {
            this.isSnake = isSnake;
        }

        /// <summary>
        /// Method untuk mengganti teleporter tangga yang ada pada petak
        /// </summary>
        /// <param name="isLadder">Teleporter tangga yang baru</param>
        public void SetIsLadder(Teleporter isLadder)
        {
            this.isLadder = isLadder;
        }

        /// <summary>
        /// Method untuk mengembalikan indeks petak
        /// </summary>
        /// <returns>number tile</returns>
        public int GetNumber()
        {
            return this.number;
        }

        /// <summary>
        /// Method untuk mengembalikan teleporter ular yang ada
        /// </summary>
        /// <returns>teleporter ular</returns>
        public Teleporter IsSnake()
        {
            return this.isSnake;
        }

        /// <summary>
        /// Method untuk mengembalikan teleporter tangga yang ada
        /// </summary>
        /// <returns>teleporter ladder</returns>
        public Teleporter IsLadder()
        {
            return this.isLadder;
        }

        /// <summary>
        /// Method untuk mengembalikan teleporter yang ada
        /// </summary>
        /// <returns>teleporter</returns>
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
