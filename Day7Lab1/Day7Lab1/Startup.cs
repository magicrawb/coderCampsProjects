using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day7Lab1.Startup))]
namespace Day7Lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
