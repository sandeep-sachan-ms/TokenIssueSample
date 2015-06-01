using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartCom.Login.Startup))]
namespace SmartCom.Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
