using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<JuridicoViewModel, Juridico>();
            Mapper.CreateMap<FisicoViewModel, Fisico>();
            Mapper.CreateMap<TelefoneViewModel, Telefone>();
            Mapper.CreateMap<EmailViewModel, Email>();
            Mapper.CreateMap<SexoViewModel, Sexo>();
        }
    }
}