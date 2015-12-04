using Nancy.Testing;
using Xunit;

namespace Chess.API.Tests
{
    public class HeartbeatTests
    {
        [Fact]
        public void HeartbeatSaysHiToMum()
        {
            var browser = new Browser(with => with.Module<HeartbeatModule>());
            var response = browser.Get("/");

            Assert.Equal("Hi Mum", response.Body.AsString());
        }
    }
}
