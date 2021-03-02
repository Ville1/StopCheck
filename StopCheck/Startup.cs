using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StopCheck.Startup))]
namespace StopCheck
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {

        }
    }
}
