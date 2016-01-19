using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(braggingrights.Startup))]
namespace braggingrights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
