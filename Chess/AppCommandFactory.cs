using System;

namespace Chess
{
    public class AppCommandFactory
    {
        private const string ExitInput = "exit";

        public IAppCommand Create(string input)
        {
            if (input.Equals(ExitInput, StringComparison.OrdinalIgnoreCase))
            {
                return new ExitAppCommand();
            }
            return null;
        }
    }
}