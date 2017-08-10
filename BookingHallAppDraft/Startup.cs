using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingHallAppDraft.Startup))]
namespace BookingHallAppDraft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
