using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using ProjetoEcommerce.Dominio.Interfaces.Services.Base;
using ProjetoEcommerce.Service.Base;
using SimpleInjector;
using System;

namespace ProjetoEcommerce.Host
{
    public class DependencyInjector
    {
        private Container _container;
        private Lifestyle _lifestyle;

        public void CreateInstance()
        {
            _lifestyle = Lifestyle.Transient;
            _container = new Container();
        }

        public void Config()
        {
            _container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), _lifestyle);
            _container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), _lifestyle);
            //_container.Register<ILogger, FileLogger>(Lifestyle.Singleton);

        }


    }
}
