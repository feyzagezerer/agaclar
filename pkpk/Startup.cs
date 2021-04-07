using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pkpk.Startup))]
namespace pkpk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
