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
        public void AppReportsUnknownCommandsToOutputChannel()
        {
            const string commandName = "Unknown command";

            _app.ReceiveInput(commandName);
            Assert.Equal(commandName, _output.UnknownCommandErrors.Single());
        }
    }
}
