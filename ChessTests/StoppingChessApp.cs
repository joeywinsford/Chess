using Chess;
using Xunit;

namespace ChessTests
{
    public class StoppingChessApp
    {
        private readonly ChessApp _app;

        public StoppingChessApp()
        {
            _app = TestAppFactory.Create();
        }

        [Theory]
        [InlineData("STOP")]
        [InlineData("stop")]
        [InlineData("Stop")]
        public void CanStopTheApp(string input)
        {
            _app.ReceiveInput(input);
            Assert.False(_app.IsRunning);
        }
    }
}
