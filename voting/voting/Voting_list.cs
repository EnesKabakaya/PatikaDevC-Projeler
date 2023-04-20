namespace voting
{
    internal class Voting_list
    {
        private string v1;
        private int v2;

        public Voting_list(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static int Oran { get; internal set; }
        public string Name { get; internal set; }
        public int Rate { get; internal set; }
    }
}