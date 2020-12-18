using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTL_LTWEB.Startup))]
namespace BTL_LTWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
