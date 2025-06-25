using Microsoft.AspNetCore.Mvc;
using PROJETO2.Models;
using PROJETO2.Repositorio;

namespace PROJETO2.Controllers
{
    public class ProdutoController : Controller
    {

        readonly ProdutoRepositorio _produtoRepositorio;

        public ProdutoController(ProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult Index()
        {
            return View(_produtoRepositorio.TodosProduto);
        }
        public IActionResult CadastrarProduto()
        {
            return View();
        }

    }
}
