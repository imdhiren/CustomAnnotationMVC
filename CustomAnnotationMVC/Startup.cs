using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomAnnotationMVC.Startup))]
namespace CustomAnnotationMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
