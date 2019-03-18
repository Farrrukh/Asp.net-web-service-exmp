using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebService1.Startup))]
namespace WebService1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
