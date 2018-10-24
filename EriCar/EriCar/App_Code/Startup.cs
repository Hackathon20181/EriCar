using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EriCar.Startup))]
namespace EriCar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
