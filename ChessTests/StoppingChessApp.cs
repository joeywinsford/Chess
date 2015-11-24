using Chess;
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

        [Theory]
        [InlineData("STOP")]
        [InlineData("stop")]
        [InlineData("Stop")]
        public void CanStopTheApp(string input)
        {
            _app.ReceiveInput(input);
            Assert.False(_app.IsRunning);
            Assert.Equal(1, _output.NumberOfStopCommands);
        }
    }
}
