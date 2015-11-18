using System;
namespace Engine { 

  class Dice
{
    private int sides;
    public Dice(int sides) {
        this.sides = sides;
    }
    //constructor tanpa parameter
    public Dice() {
        this.sides = 6;
    }
    // random dari 1-6
    public int RollDice() {
        Random r = new Random();
        int dices = r.Next(1, 7);
        return dices;
    }
}
}
