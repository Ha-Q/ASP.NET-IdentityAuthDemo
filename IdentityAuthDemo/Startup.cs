using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityAuthDemo.Startup))]
namespace IdentityAuthDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
