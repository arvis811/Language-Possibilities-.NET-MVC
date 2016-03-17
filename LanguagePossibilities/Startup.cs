using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanguagePossibilities.Startup))]
namespace LanguagePossibilities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
