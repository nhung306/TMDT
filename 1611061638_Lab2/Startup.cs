using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1611061638_Lab2.Startup))]
namespace _1611061638_Lab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
