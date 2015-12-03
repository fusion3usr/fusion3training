using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsTraining.Startup))]
namespace JenkinsTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
