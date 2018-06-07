using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DragDrop.Startup))]
namespace DragDrop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
