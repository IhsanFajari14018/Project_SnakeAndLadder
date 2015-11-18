namespace Engine
{
    class Ladder : Teleporter
    {
        public Ladder(int head, int tail) : base(head, tail)
        {

        }

        public override void MovePlayer(Player p)
        {
            //set posisi pemain pada head
            p.SetPosition(Head);
        }
    }
}
