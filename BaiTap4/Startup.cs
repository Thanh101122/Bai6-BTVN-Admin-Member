using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTap4.Startup))]
namespace BaiTap4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
