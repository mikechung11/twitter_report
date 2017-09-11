using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterReport.Web.Startup))]
namespace TwitterReport.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
