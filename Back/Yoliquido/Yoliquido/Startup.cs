using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yoliquido.Startup))]
namespace Yoliquido
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
