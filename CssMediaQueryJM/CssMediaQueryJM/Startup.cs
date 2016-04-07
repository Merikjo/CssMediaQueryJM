using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CssMediaQueryJM.Startup))]
namespace CssMediaQueryJM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
