namespace Engine
{
    /// <summary>
    /// Kelas abstrak yang merepresentasikan ular atau tangga
    /// </summary>
    public abstract class Teleporter
    {
        private int head, tail;

        /// <summary>
        /// Field untuk mengganti atau mengembalikan nilai dari atribut privat head
        /// </summary>
        public int Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        /// <summary>
        /// Field untuk mengganti atau mengembalikan nilai dari atribut privat tail
        /// </summary>
        public int Tail
        {
            get
            {
                return tail;
            }
            set
            {
                tail = value;
            }
        }

        /// <summary>
        /// Constructor kelas Teleporter
        /// </summary>
        /// <param name="head">Bagian kepala dari objek Teleporter</param>
        /// <param name="tail">Bagian ekor dari objek Teleporter</param>
        public Teleporter(int head, int tail)
        {
            this.head = head;
            this.tail = tail;
        }

        /// <summary>
        /// Method abstrak untuk memindahkan pemain
        /// </summary>
        /// <param name="p">Objek pemain yang akan dipindahkan</param>
        public abstract void MovePlayer(Player p);
    }
}
