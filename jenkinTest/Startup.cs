using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkinTest.Startup))]
namespace jenkinTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
