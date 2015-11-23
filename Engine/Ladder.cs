namespace Engine
{
    /// <summary>
    /// Kelas ini diturunkan dari kelas Teleporter
    /// Kelas ini merepresentasikan sebuah Ladder
    /// </summary>
    public class Ladder : Teleporter
    {
        /// <summary>
        /// Konstraktor
        /// </summary>
        /// <param name="head">posisi head ladder</param>
        /// <param name="tail">posisi tail ladder</param>
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
