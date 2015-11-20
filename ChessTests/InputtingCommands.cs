using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class InputtingCommands
    {
        private readonly TestOutput _output;
        private readonly ChessApp _app;

        public InputtingCommands()
        {
            _output = new TestOutput();
            _app = new ChessApp(_output);
        }

        [Fact]
        public void AppKeepsHistoryOfCommands()
        {
            const string firstCommand = "Test command 1";
            const string secondCommand = "Test command 2";

            _app.ReceiveInput(firstCommand);
            _app.ReceiveInput(secondCommand);

            Assert.Equal(2, _app.CommandHistory.Count());
            Assert.Equal(firstCommand, _app.CommandHistory.First().CommandName);
            Assert.Equal(secondCommand, _app.CommandHistory.Last().CommandName);
        }

        [Fact]
        public void AppReportsUnknownCommandsToOutputChannel()
        {
            const string commandName = "Test command";

            _app.ReceiveInput(commandName);
            Assert.Equal(commandName, _output.UnknownCommandErrors.Single());
        }
    }
}
