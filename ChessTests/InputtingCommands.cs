using System.Linq;
using Chess;
using Chess.Commands;
using Xunit;

namespace ChessTests
{
    public class InputtingCommands
    {
        private readonly ChessApp _app;

        public InputtingCommands()
        {
            var output = new TestOutput();
            _app = new ChessApp(output);
        }

        [Fact]
        public void AppKeepsHistoryOfCommands()
        {
            const string firstCommand = "Test command 1";
            const string secondCommand = "Test command 2";

            _app.Handle(new TestAppCommand(firstCommand));
            _app.Handle(new TestAppCommand(secondCommand));

            Assert.Equal(2, _app.CommandHistory.Count());
            Assert.Equal(firstCommand, _app.CommandHistory.First().CommandName);
            Assert.Equal(secondCommand, _app.CommandHistory.Last().CommandName);
        }

        public class TestAppCommand : IAppCommand
        {
            public TestAppCommand(string commandName)
            {
                CommandName = commandName;
            }

            public void Run(ChessApp app)
            {
            }

            public string CommandName { get; }
        }
    }
}
