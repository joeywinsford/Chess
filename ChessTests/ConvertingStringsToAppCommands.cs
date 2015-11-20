using Chess;
using Xunit;

namespace ChessTests
{
    public class ConvertingStringsToAppCommands
    {
        private readonly AppCommandFactory _commandFactory;

        public ConvertingStringsToAppCommands()
        {
            _commandFactory = new AppCommandFactory();
        }

        [Theory]
        [InlineData("Stop")]
        [InlineData("stop")]
        [InlineData("STOP")]
        public void ExitInputResolvesToExitCommand(string exitInput)
        {
            var command = _commandFactory.Create(exitInput);
            Assert.IsType<StopAppCommand>(command);
        }
    }
}
