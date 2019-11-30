using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.ViewModels;

namespace ProjetoEcommerce
{
    public static class AutoMapperConfig
    {
        public static Mapper Mapper;

        public static void Configuration()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteViewModel>();
                cfg.CreateMap<Juridico, JuridicoViewModel>();
                cfg.CreateMap<Fisico, FisicoViewModel>();
                cfg.CreateMap<Telefone, TelefoneViewModel>();
                cfg.CreateMap<Email, EmailViewModel>();
                cfg.CreateMap<Sexo, SexoViewModel>();

                cfg.CreateMap<ClienteViewModel, Cliente>();
                cfg.CreateMap<JuridicoViewModel, Juridico>();
                cfg.CreateMap<FisicoViewModel, Fisico>();
                cfg.CreateMap<TelefoneViewModel, Telefone>();
                cfg.CreateMap<EmailViewModel, Email>();
                cfg.CreateMap<SexoViewModel, Sexo>();
            });

            Mapper = new Mapper(config);
        }
    }
}