using System;

namespace Chess
{
    public class StringInputInterpreter
    {
        private const string ExitInput = "exit";

        public ISessionCommand Resolve(string input)
        {
            if (input.Equals(ExitInput, StringComparison.OrdinalIgnoreCase))
            {
                return new ExitSessionCommand();
            }
            return new StringSessionCommand(input);
        }
    }
}