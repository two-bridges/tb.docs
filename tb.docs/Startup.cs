using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tb.docs.Startup))]
namespace tb.docs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
