using System;
using System.Collections.Generic;
using System.Web;
using Owin;

namespace Chess.API
{
    public class Start
    {
        public void Configure(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}