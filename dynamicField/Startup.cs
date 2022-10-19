using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dynamicField.Startup))]
namespace dynamicField
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
