using System;
using System.Collections.Generic;
using System.Web;
using Nancy;

namespace Chess.API
{
    public class HeartbeatModule : NancyModule
    {
        public HeartbeatModule()
        {
            Get["/"] = parameters => $"The time on the server is {DateTime.Now.ToString("R")}";
        }
    }
}