using System;
namespace Engine{

  /// <summary>
  /// Kelas ini digunakan untuk meng-convert posisi pemain ke x dan y
  /// </summary>
  public class Converter{
    private int position;
    private int x;
    private int y;
    
    /// <summary>
    /// Konstraktor, langsung memanggil method Convert
    /// </summary>
    /// <param name="position"> posisi yang ingin diconvert</param>
    public Converter(){
      this.x=this.y=-1;
    }
    
    /// <summary>
    /// Method untuk meng-convert position ke x dan y
    /// </summary>
    public void Convert(int position){
      int tempX=0;
      int tempY=0;
      tempY=position/10;
      if(position%10==0) tempY--;
      this.y=(9-tempY);
		
      if(y%2==0){
        if((position % 10)>0){
          tempX=(9-(position % 10))+1;
        }
        this.x=tempX;
      }
      else{
        if(position % 10==0) x=9;
        else x=(position % 10)-1;
      }
    }
    
    /// <summary>
    /// Getter atribut x
    /// </summary>
    public int GetX(){
      return x;
    }
    
    /// <summary>
    /// Getter atribut y
    /// </summary>
    public int GetY(){
      return y;
    }
  }
}
