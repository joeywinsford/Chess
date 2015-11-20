using Chess;
using Xunit;

namespace ChessTests
{
    public class EndingASession
    {
        [Fact]
        public void SessionIsNotRunning()
        {
            var session = new Session();
            session.ReceiveInput(new ExitSessionCommand());
            Assert.False(session.IsRunning);
        }
    }
}
