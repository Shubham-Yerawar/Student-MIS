using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finalStudent.Startup))]
namespace finalStudent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
