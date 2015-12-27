using Domain.Common;
using Microsoft.Practices.Unity;
using Sample.Domain;
using Sample.Domain.Domains;
using System.Web.Http;
using Unity.WebApi;

namespace Sample.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterInstance<IDomain<Sale>>(new SalesDomain());
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}