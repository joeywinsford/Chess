using Nancy;
using Nancy.Testing;
using Xunit;

namespace Chess.API.Tests
{
    public class StartingANewGame
    {
        private readonly BrowserResponse _response;
        private readonly Browser _browser;
        private readonly Game _newGame;

        public StartingANewGame()
        {
            _browser = new Browser(with => with.Module<GameModule>());
            _response = _browser.Post("game/new");
            _newGame = _response.Body.DeserializeJson<Game>();
        }

        [Fact]  
        public void NewGameHasAUniqueName()
        {
            Assert.Equal(HttpStatusCode.OK, _response.StatusCode);

            var secondResponse = _browser.Post("game/new");
            Assert.Equal(HttpStatusCode.OK, secondResponse.StatusCode);

            var secondGame = secondResponse.Body.DeserializeJson<Game>();
            Assert.NotEqual(_newGame.Id, secondGame.Id);
        }
            
        [Fact]
        public void NewGameHasNoPlayers()
        {
            Assert.Equal(0, _newGame.Players.Count);
        }
    }
}
