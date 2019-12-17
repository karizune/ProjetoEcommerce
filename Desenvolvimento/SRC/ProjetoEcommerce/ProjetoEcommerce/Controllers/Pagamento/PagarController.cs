using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoletoNet;

namespace ProjetoEcommerce.Controllers.Pagamento
{
    public class PagarController : Controller
    {
        ProjetoEcommerceContext Context = new ProjetoEcommerceContext();
        /*  
          Rode os scripts do banco antes de executar, eles popularão as tabelas necessárias.
                                                                                            */
        static int idusuario =2;
        static Usuario UsuarioLogado
        {
            get
            {
                return DemoUsuarios[idusuario];
            }
        }
        static readonly List<ProdutoCarrinho> ListaProdutos = new List<ProdutoCarrinho>
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
        public ActionResult Novo(int id)
        {
            idusuario = id;
            return RedirectToAction("Metodo");
        }
        public ActionResult Metodo()
        {
            var listaMetodos = Context.MetodoPagamento.ToList().Where(f=>f.Status==1);
            UsuarioLogado.Carteira = Context.Set<Dominio.Entidades.Pagamento.Carteira>().Find(UsuarioLogado.UsuarioID);
            return View(new PagarMetodoViewModel(ListaProdutos, listaMetodos, UsuarioLogado));
        }
        
        public ActionResult Cartao()
        {
            UsuarioLogado.Carteira = Context.Set<Dominio.Entidades.Pagamento.Carteira>().Find(UsuarioLogado.UsuarioID);
            UsuarioLogado.CartoesUsuario = Context.Set<Cartao>().Where(f => f.UsuarioID == UsuarioLogado.UsuarioID).ToList();
            foreach (var item in UsuarioLogado.CartoesUsuario)
            {
                item.BandeiraCartao = Context.Set<BandeiraCartao>().Find(item.BandeiraCartaoID);
            }
            return View(new PagarCartaoViewModel(ListaProdutos,UsuarioLogado));
        }
        
        
        public ActionResult Carteira()
        {
            UsuarioLogado.Carteira = Context.Set<Dominio.Entidades.Pagamento.Carteira>().Find(UsuarioLogado.UsuarioID);
            UsuarioLogado.CartoesUsuario = Context.Set<Cartao>().Where(f => f.UsuarioID == UsuarioLogado.UsuarioID).ToList();
            return View(new PagarCarteiraViewModel(ListaProdutos, UsuarioLogado));
            
        }
        public ActionResult Boleto()
        {
            return View();
        }
        
        public ActionResult BoletoGerado(PagamentoBoletoViewModel pagamentoBoletoViewModel)
        {
            BoletoBancario boletoBancario = new BoletoBancario();
            boletoBancario.CodigoBanco = (short)104;
            DateTime vencimento = DateTime.Now.AddDays(5);
            Cedente c = new Cedente("000.000.000-00", "Boleto.net ILTDA", "1234", "12345678", "9");
            c.Codigo = "112233";
            BoletoNet.Boleto b = new BoletoNet.Boleto(vencimento, 4300m, "2", "0123456789", c);

            b.Sacado = new Sacado(pagamentoBoletoViewModel.CPFPagador, pagamentoBoletoViewModel.NomePagador);
            b.Sacado.Endereco.End = "Endereço do seu Cliente ";
            b.Sacado.Endereco.Bairro = "Bairro";
            b.Sacado.Endereco.Cidade = "Cidade";
            b.Sacado.Endereco.CEP = "00000000";
            b.Sacado.Endereco.UF = "UF";

            Instrucao_Caixa item;
            //ImportanciaporDiaDesconto
            item = new Instrucao_Caixa((int)EnumInstrucoes_Caixa.Multa, Convert.ToDecimal(0.40));
            b.Instrucoes.Add(item);
            item = new Instrucao_Caixa((int)EnumInstrucoes_Caixa.JurosdeMora, Convert.ToDecimal(0.01));
            b.Instrucoes.Add(item);
            item = new Instrucao_Caixa((int)EnumInstrucoes_Caixa.NaoReceberAposNDias, 90);
            b.Instrucoes.Add(item);
            EspecieDocumento_Caixa espDocCaixa = new EspecieDocumento_Caixa();
            b.EspecieDocumento = new EspecieDocumento_Caixa(espDocCaixa.getCodigoEspecieByEnum(EnumEspecieDocumento_Caixa.DuplicataMercantil));
            b.NumeroDocumento = "00001";
            b.DataProcessamento = DateTime.Now;
            b.DataDocumento = DateTime.Now;
            b.CodigoBarra.PreencheValores(104, 9, 7363L, "0000004300", "0001023514837340110996818");
            b.CodigoBarra.LinhaDigitavel = b.CodigoBarra.LinhaDigitavelFormatada.Trim().Replace(".", string.Empty).Replace(" ", string.Empty);
            var linhaDigitavel = b.CodigoBarra.LinhaDigitavelFormatada;
            boletoBancario.Boleto = b;
            BoletoGeradoViewModel view = new BoletoGeradoViewModel
            {
                HTML = boletoBancario.MontaHtmlEmbedded()
            };

            return View(view);
        }
        public ActionResult Sucesso()
        {
            return View();
        }

    }


}