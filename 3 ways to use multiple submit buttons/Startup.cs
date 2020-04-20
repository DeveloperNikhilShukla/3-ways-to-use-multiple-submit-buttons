using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3_ways_to_use_multiple_submit_buttons.Startup))]
namespace _3_ways_to_use_multiple_submit_buttons
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
