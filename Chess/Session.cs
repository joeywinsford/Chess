using System.Collections.Generic;

namespace Chess
{
    public class Session
    {
        public List<Input> Inputs { get; } = new List<Input>();
        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(Input input)
        {
            Inputs.Add(input);
            if (input.Command == "Exit")
            {
                IsRunning = false;
            }
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