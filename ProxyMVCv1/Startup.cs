using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProxyMVCv1.Startup))]
namespace ProxyMVCv1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
