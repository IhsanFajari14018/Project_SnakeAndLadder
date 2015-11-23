using System;
namespace Engine
{
    ///<summary>
    ///Kelas yang merepresentasikan sebuah dadu.
    ///</summary>
    public class Dice
    {
        private int sides;
        
        ///<summary>
        ///Constructor kelas Dice dengan parameter.
        ///</summary>
        /// <param name="sides">Banyaknya sisi pada dadu</param>
        public Dice(int sides)
        {
            this.sides = sides;
        }
        
        ///<summary>
        ///Constructor kelas Dice tanpa parameter.
        ///</summary>
        public Dice()
        {
            this.sides = 6;
        }
        
        /// <summary>
        /// Method untuk mengocok dan mengembalikan nilai dadu.
        /// </summary>
        /// <returns>nilai dadu yang telah dikocok</returns>
        public int RollDice()
        {
            Random r = new Random();
            int dices = r.Next(1, 7);
            return dices;
        }
    }
}
