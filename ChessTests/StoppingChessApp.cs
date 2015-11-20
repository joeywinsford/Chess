using Chess;
using Xunit;

namespace ChessTests
{
    public class StoppingChessApp
    {
        [Fact]
        public void AppIsNotRunning()
        {
            var app = new ChessApp();
            app.ReceiveInput(new ExitAppCommand());
            Assert.False(app.IsRunning);
        }
    }
}
