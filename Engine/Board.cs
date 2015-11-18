namespace Engine
{
  class Board
  {
    private Tile[] tiles;

    public Board(){
       this.tile = new Tile[100];
       for(int i=0;i<tiles.length;i++){
          tiles[i]=new Tile(i);
       }
      generateBoard();
    }

    public void generateBoard(){
      Random r = new Random();
      int count = 0;
      int start = 0;
      int end = 0;
      while(count<8){
        start = r.nextInt(98)+1;
        end = r.nextInt(98)+1;
        if((start<end)&&isValidSnakeLadder(tiles[start],tiles[end])){
        //tiles[start].setSnake(true);
        tiles[start].SetIsSnake(new Snake(start,end));
        tiles[end].SetIsSnake(new Snake(start,end));
        }
      }
      count=start=end=0;
      while(count<8){
        start=r.nextInt(98)+1;
        end=r.nextInt(98)+1;
        if((start>end)&&isValidSnakeLadder(tiles[start],tiles[end])){
          //tiles[start].setSnake(true);
          tiles[start].SetIsLadder(new Ladder(start,end));
          tiles[end].SetIsLadder(new Ladder(start,end));
          count++;
      }
    }
      private boolean isValidSnakeLadder(Tile t1,Tile t2){
        if(t1.getSnakeLadder()!=null||t2.getSnakeLadder()!=null){
            return false;
        }
        else{
            return true;
        }
    }

    public Tile[] getTiles() {
        return tiles.GetNumber;
    }
  }
}
