using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksQuizz.Startup))]
namespace BooksQuizz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
