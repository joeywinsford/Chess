namespace Chess
{
    public interface IAppOutput
    {
        void ReportUnknownCommandError(string unknownCommandName);
    }
}