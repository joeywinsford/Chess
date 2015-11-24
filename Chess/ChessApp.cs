using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class ChessApp
    {
        private readonly AppCommandFactory _commandFactory = new AppCommandFactory();
        private readonly List<Game> _games = new List<Game>();

        public ChessApp(IAppOutput output)
        {
            Output = output;
        }

        public IAppOutput Output { get; set; }

        public List<IAppCommand> CommandHistory { get; } = new List<IAppCommand>();

        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(string input)
        {
            var command = _commandFactory.GetCommand(input);

            CommandHistory.Add(command);
            command.Run(this);
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public Game GetGame(Guid id)
        {
            return _games.Single(game => game.Id == id);
        }

        public void RegisterGame(Game game)
        {
            _games.Add(game);
        }
    }
}