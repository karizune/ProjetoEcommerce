[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoEcommerce.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoEcommerce.NinjectWebCommon), "Stop")]

namespace ProjetoEcommerce
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using ProjetoEcommerce.Data.Repositories;
    using ProjetoEcommerce.Dominio.Interfaces.Repositories;
    using ProjetoEcommerce.Dominio.Interfaces.Services;
    using ProjetoEcommerce.Dominio.Services;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IJuridicoService>().To<JuridicoService>();
            kernel.Bind<IFisicoService>().To<FisicoService>();
            kernel.Bind<ISexoService>().To<SexoService>();
            kernel.Bind<ITelefoneService>().To<TelefoneService>();
            kernel.Bind<IEmailService>().To<EmailService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IJuridicoRepository>().To<JuridicoRepository>();
            kernel.Bind<IFisicoRepository>().To<FisicoRepository>();
            kernel.Bind<ISexoRepository>().To<SexoRepository>();
            kernel.Bind<ITelefoneRepository>().To<TelefoneRepository>();
            kernel.Bind<IEmailRepository>().To<EmailRepository>();
        }        
    }
}
