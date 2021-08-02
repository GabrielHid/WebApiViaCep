using System.Data.Entity;
using System.Web.Http;

namespace ExemploWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.ApiContext, Migrations.Configuration>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
