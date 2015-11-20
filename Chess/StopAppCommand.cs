﻿namespace Chess
{
    public class StopAppCommand : IAppCommand
    {
        public void Run(ChessApp app)
        {
            app.Stop(); 
        }

        public string CommandName => "Stop App";
    }
}