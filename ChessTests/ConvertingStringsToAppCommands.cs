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
        [InlineData("Exit")]
        [InlineData("exit")]
        public void ExitInputResolvesToExitCommand(string exitInput)
        {
            var command = _commandFactory.Create(exitInput);
            Assert.IsType<ExitAppCommand>(command);
        }
    }
}
