using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using PS.Puzzle03.Domain;
using PS.Puzzle03.Models;

namespace PS.Puzzle03
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var builder = new ContainerBuilder();
            //builder.RegisterInstance<IRepository<ServiceCentre>>(new ServiceCentreJSONRepository());
            builder.RegisterType<ServiceCentreJSONRepository>().As<IRepository<ServiceCentre>>().InstancePerRequest();
            builder.RegisterType<ServiceCentreService>().As<IServiceCentreService>().InstancePerRequest();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);
            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
