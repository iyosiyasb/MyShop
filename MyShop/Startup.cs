using Microsoft.Owin;
using Owin;
using React;
using React.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(MyShop.Startup))]
namespace MyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
