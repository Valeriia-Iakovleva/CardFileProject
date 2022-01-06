using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardFileProject.Startup))]
namespace CardFileProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
