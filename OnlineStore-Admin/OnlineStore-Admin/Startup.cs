using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStore_Admin.Startup))]
namespace OnlineStore_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
