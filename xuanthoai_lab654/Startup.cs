using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xuanthoai_lab654.Startup))]
namespace xuanthoai_lab654
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
