using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Chess
{
    public class Session
    {
        public Session()
        {
        }

        public List<Input> Inputs { get; } = new List<Input>();

        public void ReceiveInput(Input input)
        {
            Inputs.Add(input);
        }
    }

    public class Input
    {
        public Input(string command)
        {
            Command = command;
        }

        public string Command { get; private set; }
    }
}