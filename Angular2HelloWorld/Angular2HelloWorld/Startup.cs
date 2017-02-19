using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2HelloWorld.Startup))]
namespace Angular2HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
