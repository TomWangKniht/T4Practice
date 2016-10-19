using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T4Practice.Startup))]
namespace T4Practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
