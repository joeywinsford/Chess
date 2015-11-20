using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingANewGameSession
    {
        [Fact]
        public void SessionAcceptsInput()
        {
            var command = "Start Game";
            var session = new Session();

            session.ReceiveInput(new Input(command));

            Assert.Equal(command, session.Inputs.First().Command);
        }
    }
}
