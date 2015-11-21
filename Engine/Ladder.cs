namespace Engine
{
    public class Ladder : Teleporter
    {
        ///<summary>
        ///Konstraktor
        ///</summary>
        public Ladder(int head, int tail) : base(head, tail)
        {

        }

        ///<summary>
        ///Method override untuk memindahkan player
        ///</summary>
        ///<param name="p">Pemain yang akan dipindahkan</param>
        public override void MovePlayer(Player p)
        {
            //set posisi pemain pada head
            p.SetPosition(Head);
        }
    }
}
