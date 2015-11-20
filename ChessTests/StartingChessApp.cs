using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingChessApp
    {
        [Fact]
        public void NewSessionsAreRunning()
        {
            var app = TestAppFactory.Create();
            Assert.True(app.IsRunning);
        }
    }
}
