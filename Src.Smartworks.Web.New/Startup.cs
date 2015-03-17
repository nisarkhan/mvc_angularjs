using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Src.Smartworks.Web.New.Startup))]
namespace Src.Smartworks.Web.New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
