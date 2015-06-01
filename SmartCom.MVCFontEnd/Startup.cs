using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartCom.MVCFontEnd.Startup))]
namespace SmartCom.MVCFontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
