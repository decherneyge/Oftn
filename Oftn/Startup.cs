using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oftn.Startup))]
namespace Oftn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
