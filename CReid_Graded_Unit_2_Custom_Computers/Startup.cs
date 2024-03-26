using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CReid_Graded_Unit_2_Custom_Computers.Startup))]
namespace CReid_Graded_Unit_2_Custom_Computers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
