using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartCom.WebFromFrontEnd.Startup))]
namespace SmartCom.WebFromFrontEnd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
