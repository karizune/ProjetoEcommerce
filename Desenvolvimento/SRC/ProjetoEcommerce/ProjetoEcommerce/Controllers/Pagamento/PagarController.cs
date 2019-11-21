using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Entidades.Pagamento.ViewModels;
using ProjetoEcommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class PagarController : Controller
    {
        ProjetoEcommerceContext Context = new ProjetoEcommerceContext();
        public PagarController()
        {

        }
        public ActionResult PagamentoMetodo(/*IEnumerable<ProdutoCarrinho> ListaProdutos*/)
        {
            var ListaProdutos = new List<ProdutoCarrinho>
            {
                new ProdutoCarrinho
                {
                    Nome = "Celular XL",DescricaoProduto="Celular grande com uma das melhores telas",UrlImagem="https://www.celulardireto.com.br/wp-content/uploads/2018/10/iphone-xs-max.png",Preco=1500,ProdutoID=0,Quantidade=2,CriadoEm=DateTime.Now,AtualizadoEm=DateTime.Now, Status=1,Usuario="EU"
                },
                new ProdutoCarrinho
                {
                    Nome = "Celular Mini",DescricaoProduto="Celular pequeno com uma das melhores Câmeras",UrlImagem="https://i.zst.com.br/images/smartphone-xiaomi-mi-9-se-6gb-ram-64gb-camera-tripla-qualcomm-snapdragon-712-2-chips-android-9-0-pie--photo819343044-45-18-12.jpg",Preco=1300,ProdutoID=1,Quantidade=1,CriadoEm=DateTime.Now,AtualizadoEm=DateTime.Now, Status=1,Usuario="EU"
                }
            };
            var listaMetodos = Context.MetodoPagamento.ToList();
            return View(new MetodoPagamentoViewModel(ListaProdutos,listaMetodos));
        }

    }

   
}