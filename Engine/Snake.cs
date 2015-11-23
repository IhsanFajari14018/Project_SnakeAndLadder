namespace Engine
{
    /// <summary>
    /// Kelas ini diturunkan dari kelas Teleporter
    /// Kelas ini merepresentasikan satu snake
    /// </summary>
    public class Snake : Teleporter //tail adalah titik akhir (end)
    {
        /// <summary>
        /// Konstraktor
        /// </summary>
        /// <param name="head"> posisi kepala snake</param>
        /// <param name="tail"> posisi ekor snake</param>
        public Snake(int head, int tail) : base(head, tail)
        {

        }

        /// <summary>
        /// Method override untuk memindahkan player
        /// </summary>
        /// <param name="p"> Player yang ingin dipindahkan</param>
        public override void MovePlayer(Player p)
        {
            //set posisi pemain pada tail
            p.SetPosition(Tail);
        }
    }
}
