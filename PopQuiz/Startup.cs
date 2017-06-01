using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PopQuiz.Startup))]
namespace PopQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
