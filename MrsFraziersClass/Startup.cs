using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MrsFraziersClass.Startup))]
namespace MrsFraziersClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
