using AutoMapper;
using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Data.Repositories;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Repositories.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Services.Marketplace;
using ProjetoEcommerce.Service;
using ProjetoEcommerce.Service.Interfaces.Marketplace;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjetoEcommerce
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();

            container.Register<IFeedbackParceiroRepository, FeedbackParceiroRepository>(Lifestyle.Singleton);
            container.Register<IFeedbackParceiroService, FeedbackParceiroService>(Lifestyle.Singleton);

            container.Register<IParceiroRepository, ParceiroRepository>(Lifestyle.Singleton);
            container.Register<IParceiroService, ParceiroService>(Lifestyle.Singleton);

            container.Register<IRastreioRepository, RastreioRepository>(Lifestyle.Singleton);
            container.Register<IRastreioService, RastreioService>(Lifestyle.Singleton);

            container.Register<IFeedbackProdutoReposytory, FeedbackProdutosRepository>(Lifestyle.Singleton);
            container.Register<IFeedbackProdutoService, FeedbackProdutoService>(Lifestyle.Singleton);


            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Singleton);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Singleton);


            container.Verify();

            DependencyResolver.SetResolver(
               new SimpleInjectorDependencyResolver(container));


            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjetoEcommerceContext>());


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
