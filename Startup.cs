using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VAT_FrontEnd.Startup))]
namespace VAT_FrontEnd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
