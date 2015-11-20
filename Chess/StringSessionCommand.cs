namespace Chess
{
    public class StringSessionCommand : ISessionCommand
    {
        public StringSessionCommand(string command)
        {
            Command = command;
        }

        public string Command { get; }
        public void Run(Session session)
        {
        }
    }
}