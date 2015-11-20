namespace Engine
{
    public class Player
    {
        private int position;
        private string name;
        private bool isComp;

        //Dice akan disimpan di class Game.cs / Board.cs.

        //Player tidak menyimpan Board.cs.

        private bool win;

        public Player(int position, string name, bool isComp)
        {
            this.position = 0;
            this.name = name;
            this.win = false;
            this.isComp = isComp;
        }

        public void SetPosition(int position)
        {
            this.position = position;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Move(Dice d)
        {
            int steps = d.RollDice();
            position = position + steps;
            if (this.position > 99)
            {
                //jika melebihi dari finish
                int pos = this.position - 99;
                this.position = 99 - pos;
            }

        }

        public int GetPosition()
        {
            return this.position;
        }

        public bool IsWin()
        {
            if (this.position == 99)
            {
                //pas finish
                this.win = true;
            }
            return this.win;
        }

        public bool IsCompPlayer()
        {
            return isComp;
        }
    }
}
