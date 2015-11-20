using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Chess
{
    public class Session
    {
        public List<Input> Inputs { get; } = new List<Input>();
        public bool IsRunning { get; } = true;

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