using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItUniver.Calc.WebCalc.Startup))]
namespace ItUniver.Calc.WebCalc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
