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

            _app.Handle(new TestAppCommand1());
            _app.Handle(new TestAppCommand2());

            Assert.Equal(2, _app.CommandHistory.Count());
            Assert.IsType<TestAppCommand1>(_app.CommandHistory.First());
            Assert.IsType<TestAppCommand2>(_app.CommandHistory.Last());
        }

        public class TestAppCommand1 : IAppCommand
        {
            public void Run(ChessApp app)
            {
            }
        }

        public class TestAppCommand2 : IAppCommand
        {
            public void Run(ChessApp app)
            {
            }
        }
    }
}
