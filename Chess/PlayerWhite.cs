namespace Chess
{
    public class PlayerWhite : IPlayer
    {
        public PlayerWhite(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}