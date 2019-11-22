using AutoMapper;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce
{
    public static class MapperHelper
    {
        private static MapperConfiguration Config()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<FeedbackParceiro, FeedbackParceiroViewModel>();
                cfg.CreateMap<FeedbackParceiroViewModel, FeedbackParceiro>();
                cfg.CreateMap<FeedbackProduto, FeedbackProdutoViewModel>();
            });

            return config;
        }

        public static Mapper Container()
        {
            return new Mapper(Config());
        }

    }
}