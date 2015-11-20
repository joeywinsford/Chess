namespace Chess
{
    public class ExitSessionCommand : ISessionCommand
    {
        public void Run(Session session)
        {
            session.Stop();
        }
    }
}