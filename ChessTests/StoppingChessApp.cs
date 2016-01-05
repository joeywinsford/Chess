using Chess;
using Chess.Commands;
using Xunit;

namespace ChessTests
{
    public class StoppingChessApp
    {
        private readonly ChessApp _app;
        private readonly TestOutput _output;

        public StoppingChessApp()
        {
            _output = new TestOutput();
            _app = new ChessApp(_output);
        }

        [Fact]
        public void CanStopTheApp()
        {
            _app.Handle(new StopAppCommand());
            Assert.False(_app.IsRunning);
            Assert.Equal(1, _output.NumberOfStopCommands);
        }
    }
}
