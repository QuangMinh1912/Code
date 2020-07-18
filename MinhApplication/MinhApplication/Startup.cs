using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MinhApplication.Startup))]
namespace MinhApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
