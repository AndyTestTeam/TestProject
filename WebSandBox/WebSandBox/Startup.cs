using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSandBox.Startup))]
namespace WebSandBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
