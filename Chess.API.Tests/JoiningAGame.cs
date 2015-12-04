using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Testing;
using Xunit;

namespace Chess.API.Tests
{
    public class JoiningAGame
    {
        [Theory]
        [InlineData("Denise", "Black")]
        [InlineData("Derek", "White")]
        public void CanJoinAnEmptyGameAsBlack(string playerName, string colour)
        {
            var browser = new Browser(with => with.Module<GameModule>());
            var game = browser.Post("game/new").Body.DeserializeJson<Game>();

            var response = browser.Post($"game/join/{game.Id}/iam/{playerName}/playing/{colour}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal($"{playerName} joined game {game.Id} as {colour}", response.Body.AsString());
        }
    }
}
