using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_en_casa.Startup))]
namespace Prueba_en_casa
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
