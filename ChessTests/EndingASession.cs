using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess;
using Xunit;

namespace ChessTests
{
    public class EndingASession
    {
        [Fact]
        public void SessionIsNotRunning()
        {
            var session = new Session();
            session.ReceiveInput(new Input("Exit"));
            Assert.False(session.IsRunning);
        }
    }
}
