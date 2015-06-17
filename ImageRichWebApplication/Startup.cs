using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageRichWebSite.Startup))]
namespace ImageRichWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
