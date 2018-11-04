using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(king.Startup))]
namespace king
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
