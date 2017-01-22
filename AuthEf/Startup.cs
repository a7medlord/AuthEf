using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthEf.Startup))]
namespace AuthEf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
