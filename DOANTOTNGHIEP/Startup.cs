using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOANTOTNGHIEP.Startup))]
namespace DOANTOTNGHIEP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
