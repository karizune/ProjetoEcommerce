using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
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
        /*  
          Rode os scripts do banco antes de executar, eles popularão as tabelas necessárias.
                                                                                            */
        static int idusuario;
        static Usuario UsuarioLogado
        {
            get
            {
                return DemoUsuarios[idusuario];
            }
        }
        static readonly List<Usuario> DemoUsuarios = new List<Usuario>
        {
            new Usuario
            {
                UsuarioID=1,    //Usuário sem cartões, com carteira de R$5000
                Nome = "Pedro Rocha Roxo", 
                Endereco = "Uberlaba, Rua Deeo Way, 875",
                CEP="54964-655"
            },
            new Usuario
            {
                UsuarioID = 2,  //Usuário com um cartão, 4000 na carteira 
                Nome = "Jose Oswaldo da Silva", 
                Endereco = "Uberabilândia, Rua São Domingos Dorminhocos, 867",
                CEP = "00000-000"
            },
            new Usuario
            {
                UsuarioID = 3,  //Usuária com três cartões, 500 na carteira
                Nome = "Victoria Ramos Lemos",
                Endereco = "Arruátcjá, Rua Vignon Fulitin, 427",
                CEP = "87789-432"
            }
        };
        public ActionResult Metodo(int id)
        {
            idusuario = id;
            var ListaProdutos = new List<ProdutoCarrinho>
            {
                new ProdutoCarrinho
                {
                    Nome = "Celular XL",DescricaoProduto="Celular grande com uma das melhores telas",
                    UrlImagem="https://www.celulardireto.com.br/wp-content/uploads/2018/10/iphone-xs-max.png",
                    Preco=1500,ProdutoID=0,Quantidade=2
                },
                new ProdutoCarrinho
                {
                    Nome = "Celular Mini",DescricaoProduto="Celular pequeno com uma das melhores Câmeras",
                    UrlImagem="https://i.zst.com.br/images/smartphone-xiaomi-mi-9-se-6gb-ram-64gb-camera-tripla-qualcomm-snapdragon-712-2-chips-android-9-0-pie--photo819343044-45-18-12.jpg",
                    Preco=1300,ProdutoID=1,Quantidade=1
                }
            };
            var listaMetodos = Context.MetodoPagamento.ToList();
            UsuarioLogado.Carteira = Context.Set<Carteira>().Find(UsuarioLogado.UsuarioID);
            return View(new PagarMetodoViewModel(ListaProdutos, listaMetodos, UsuarioLogado));

        }
        
        public ActionResult Cartao(int id)
        {
            idusuario = id;
            var ListaProdutos = new List<ProdutoCarrinho>
            {
                new ProdutoCarrinho
                {
                    Nome = "Celular XL",DescricaoProduto="Celular grande com uma das melhores telas",
                    UrlImagem="https://www.celulardireto.com.br/wp-content/uploads/2018/10/iphone-xs-max.png",
                    Preco=1500,ProdutoID=0,Quantidade=2
                },
                new ProdutoCarrinho
                {
                    Nome = "Celular Mini",DescricaoProduto="Celular pequeno com uma das melhores Câmeras",
                    UrlImagem="https://i.zst.com.br/images/smartphone-xiaomi-mi-9-se-6gb-ram-64gb-camera-tripla-qualcomm-snapdragon-712-2-chips-android-9-0-pie--photo819343044-45-18-12.jpg",
                    Preco=1300,ProdutoID=1,Quantidade=1
                }
            };
            UsuarioLogado.Carteira = Context.Set<Carteira>().Find(UsuarioLogado.UsuarioID);
            UsuarioLogado.CartoesUsuario = Context.Set<Cartao>().Where(f => f.UsuarioID == UsuarioLogado.UsuarioID).ToList();
            return View(new PagarCartaoViewModel(ListaProdutos,UsuarioLogado));
        }
        
        public ActionResult CartaoSucesso(object obj)
        {
            return View();
        }
        public ActionResult Carteira(int id)
        {
            idusuario = id;
            var ListaProdutos = new List<ProdutoCarrinho>
            {
                new ProdutoCarrinho
                {
                    Nome = "Celular XL",DescricaoProduto="Celular grande com uma das melhores telas",
                    UrlImagem="https://www.celulardireto.com.br/wp-content/uploads/2018/10/iphone-xs-max.png",
                    Preco=1500,ProdutoID=0,Quantidade=2
                },
                new ProdutoCarrinho
                {
                    Nome = "Celular Mini",DescricaoProduto="Celular pequeno com uma das melhores Câmeras",
                    UrlImagem="https://i.zst.com.br/images/smartphone-xiaomi-mi-9-se-6gb-ram-64gb-camera-tripla-qualcomm-snapdragon-712-2-chips-android-9-0-pie--photo819343044-45-18-12.jpg",
                    Preco=1300,ProdutoID=1,Quantidade=1
                }
            };
            UsuarioLogado.Carteira = Context.Set<Carteira>().Find(UsuarioLogado.UsuarioID);
            UsuarioLogado.CartoesUsuario = Context.Set<Cartao>().Where(f => f.UsuarioID == UsuarioLogado.UsuarioID).ToList();
            return View(new PagarCarteiraViewModel(ListaProdutos, UsuarioLogado));
            
        }
        public ActionResult Sucesso(int id)
        {

        }

    }


}