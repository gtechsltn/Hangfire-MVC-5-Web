using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HangFireMvc5WebApp.Startup))]
namespace HangFireMvc5WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
