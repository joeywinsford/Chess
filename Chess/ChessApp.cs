using System.Collections.Generic;
using System.Linq;
using Chess.Commands;

namespace Chess
{
    public class ChessApp
    {
        private readonly List<Game> _games = new List<Game>();

        public ChessApp(IAppOutput output)
        {
            Output = output;
        }

        public IAppOutput Output { get; set; }

        public List<IAppCommand> CommandHistory { get; } = new List<IAppCommand>();

        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(IAppCommand command)
        {
            CommandHistory.Add(command);
            command.Run(this);
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public Game GetGame(string id)
        {
            return _games.Single(game => game.Id == id);
        }

        public void RegisterGame(Game game)
        {
            _games.Add(game);
        }
    }
}