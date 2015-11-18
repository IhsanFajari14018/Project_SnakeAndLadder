namespace Engine
{
    public class Snake : Teleporter//tail adalah titik akhir (end)
    {
        public Snake(int head, int tail) : base(head, tail)
        {

        }

        public override void MovePlayer(Player p)
        {
            //set posisi pemain pada tail
            p.SetPosition(Tail);
        }
    }
}
