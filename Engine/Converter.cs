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
    public Converter(int position){
      this.position=position;
      this.x=this.y=-1;
      Convert();
    }
    
    /// <summary>
    /// Method untuk meng-convert position ke x dan y
    /// </summary>
    private void Convert(){
      int tempX=0;
      int tempY=0;
      tempX=posisi/10;
      if(posisi%10==0) tempX--;
      this.x=(9-tempX);
		
      if(x%2==0){
        if((posisi%10)>0){
          tempY=(9-(posisi%10))+1;
        }
        this.y=tempY;
      }
      else{
        if(posisi%10==0) y=9;
        else y=(posisi%10)-1;
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
