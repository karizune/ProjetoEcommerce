using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.AutoMapper
{
    public class DomainToViewModelMappingProfile
    {
        return _mapper.Map<CategoriasViewModel>(_repositorio.GetById(id));
    }
}