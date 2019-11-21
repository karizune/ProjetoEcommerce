using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Perfil;
using ProjetoEcommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel >();
            Mapper.CreateMap<Juridico, JuridicoViewModel>();
            Mapper.CreateMap<Fisico, FisicoViewModel>();
            Mapper.CreateMap<Telefone, TelefoneViewModel>();
            Mapper.CreateMap<Email, EmailViewModel>();
            Mapper.CreateMap<Sexo, SexoViewModel>();
        }
    }
}