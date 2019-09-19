using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VR4.Ejercicio.WebApp.Startup))]
namespace VR4.Ejercicio.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
