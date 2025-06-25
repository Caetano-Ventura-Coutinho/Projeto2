using Microsoft.AspNetCore.Mvc;
using PROJETO2.Models;
using PROJETO2.Repositorio;

namespace PROJETO2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            if (usuario != null && usuario.Senha == senha) 
            {
                return RedirectToAction("Index", "Produto");
            }

            ModelState.AddModelError("", "email ou senha inválidos");
            return View();
        }
        public IActionResult Cadastro() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario) 
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.AdicionarUsuario(usuario);
                return RedirectToAction("Login");   
            }
        
            return View();
        }

        public IActionResult Contato() 
        {
            return View();
        }

    }
}
