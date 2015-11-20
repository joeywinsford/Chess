using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class InputtingCommands
    {
        [Fact]
        public void AppHandlesUnknownCommandGracefully()
        {
            var output = new TestOutput();
            var app = new ChessApp(output);
            var commandName = "Unknown command";

            var unknownCommand = new AppCommandFactory().Create(commandName);
            Assert.IsType<UnknownAppCommand>(unknownCommand);

            app.ReceiveInput(unknownCommand);
            Assert.Equal(commandName, output.UnknownCommandErrors.Single());
        }
    }
}
