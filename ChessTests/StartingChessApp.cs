using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingChessApp
    {
        [Fact]
        public void NewSessionsAreRunning()
        {
            var app = new ChessApp(new TestOutput());
            Assert.True(app.IsRunning);
        }
    }
}
