namespace Engine
{
    /// <summary>
    /// Kelas ini merepresentasikan seorang Player
    /// </summary>
    public class Player
    {
        private int position;
        private string name;
        private bool isComp;
        private int diceNum;

        //Dice akan disimpan di class Game.cs / Board.cs.

        //Player tidak menyimpan Board.cs.

        private bool win;

        /// <summary>
        /// Konstraktor
        /// </summary>
        /// <param name="position"> posisi pemain</param>
        /// <param name="name"> nama pemain</param>
        /// <param name="isComp"> pemain merupakan komputer atau bukan</param>
        public Player(int position, string name, bool isComp)
        {
            this.position = -1;
            this.name = name;
            this.win = false;
            this.isComp = isComp;
        }

        /// <summary>
        /// Setter atribut position
        /// </summary>
        /// <param name="position"> posisi pemain yang baru</param>
        public void SetPosition(int position)
        {
            this.position = position;
        }

        /// <summary>
        /// Getter atribut name
        /// </summary>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Method untuk menjalankan pemain
        /// </summary>
        /// <param name="d"> Objek dice</param>
        public void Move(Dice d)
        {
            int steps = d.RollDice();
            diceNum = steps;
            position = position + steps;
            if (this.position > 99)
            {
                //jika melebihi dari finish
                int pos = this.position - 99;
                this.position = 99 - pos;
            }

        }

        /// <summary>
        /// Method untuk mengembalikan nilai kocokan dadu
        /// </summary>
        /// <returns>Hasil kocokan dadu</returns>
        public int GetDiceNum()
        {
            return this.diceNum;
        }

        /// <summary>
        /// Getter atribut position
        /// </summary>
        public int GetPosition()
        {
            return this.position;
        }

        /// <summary>
        /// Mengembalikan nilai atribut win
        /// </summary>
        public bool IsWin()
        {
            if (this.position == 99)
            {
                //pas finish
                this.win = true;
            }
            return this.win;
        }

        /// <summary>
        /// Mengembalikan nilai atribut isComp
        /// </summary>
        public bool IsCompPlayer()
        {
            return isComp;
        }
    }
}
