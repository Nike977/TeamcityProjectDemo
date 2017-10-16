using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamcityTest.Startup))]
namespace teamcityTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
