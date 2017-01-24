using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StMnSystem.Startup))]
namespace StMnSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
