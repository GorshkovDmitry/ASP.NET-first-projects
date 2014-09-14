using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreeJS.Startup))]
namespace TreeJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
