namespace Chess.Commands
{
    public interface IAppCommand
    {
        void Run(ChessApp app);
        string CommandName { get; }
    }
}