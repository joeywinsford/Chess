using Chess;
using Xunit;

namespace ChessTests
{
    public class ConvertingStringsToSessionCommands
    {
        private readonly StringInputInterpreter _interpreter;

        public ConvertingStringsToSessionCommands()
        {
            _interpreter = new StringInputInterpreter();
        }

        [Fact]
        public void StringCommandContainsOriginalInput()
        {
            var input = "Test Command Please Ignore";
            var command = _interpreter.Resolve(input);

            Assert.IsType<StringSessionCommand>(command);
            Assert.Equal(input, ((StringSessionCommand)command).Command);
        }

        [Theory]
        [InlineData("Exit")]
        [InlineData("exit")]
        public void ExitInputResolvesToExitCommand(string exitInput)
        {
            var command = _interpreter.Resolve(exitInput);
            Assert.IsType<ExitSessionCommand>(command);
        }
    }
}
