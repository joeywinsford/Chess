using System;

namespace Chess
{
    public class AppCommandFactory
    {
        private const string Stop = "stop";

        public IAppCommand GetCommand(string input)
        {
            if (input.Equals(Stop, StringComparison.OrdinalIgnoreCase))
            {
                return new StopAppCommand();
            }
            return new UnknownAppCommand(input);
        }
    }
}