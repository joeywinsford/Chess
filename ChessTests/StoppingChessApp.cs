using Chess;
using Xunit;

namespace ChessTests
{
    public class StoppingChessApp
    {
        private readonly ChessApp _app;
        private readonly AppCommandFactory _commandFactory;

        public StoppingChessApp()
        {
            _app = new ChessApp();
            _commandFactory = new AppCommandFactory();
        }

        [Theory]
        [InlineData("STOP")]
        [InlineData("stop")]
        [InlineData("Stop")]
        public void CanStopTheApp(string input)
        {
            var stopCommand = _commandFactory.Create(input);
            _app.ReceiveInput(stopCommand);
            Assert.False(_app.IsRunning);
        }
    }
}
