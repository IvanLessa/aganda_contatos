using AgendaContatos.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaContatos.Mvc.Controllers
{
    public class ContatosController : Controller
    {
        //ROTA: /Contatos/Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //método para receber os dados enviados pelo formulário (POST)
        public IActionResult Cadastro(ContatosCadastroModel model)
        {
            //verificar se os campos da model passaram nas validações
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        //ROTA: /Contatos/Consulta
        public IActionResult Consulta()
        {
            return View();
        }

        //ROTA: /Contatos/Edicao
        public IActionResult Edicao()
        {
            return View();
        }

        [HttpPost] //método para receber o submit do formulário
        public IActionResult Edicao(ContatosEdicaoModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }
    }
}



