namespace Chess
{
    public struct Location
    {
        public Location(Rank rank, File file)
        {
            Rank = rank;
            File = file;
        }

        public Rank Rank { get; }

        public File File { get; }
    }

    public enum File
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
        H = 8
    }

    public enum Rank
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8
    }
}