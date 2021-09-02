using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TC.Startup))]
namespace TC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
