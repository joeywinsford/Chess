using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingANewGameSession
    {
        [Fact]
        public void NewSessionsAreRunning()
        {
            var session = new Session();
            Assert.True(session.IsRunning);
        }

        [Fact]
        public void SessionAcceptsInput()
        {
            var command = "Start Game";
            var session = new Session();

            session.ReceiveInput(new StringSessionCommand(command));

            var receivedInput = session.Inputs.First();
            Assert.IsType<StringSessionCommand>(receivedInput);
            Assert.Equal(command, ((StringSessionCommand)receivedInput).Command);
        }
    }
}
