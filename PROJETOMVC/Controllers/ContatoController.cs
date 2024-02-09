using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Context;
using PROJETOMVC.Models;

namespace PROJETOMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)//INJEÇÃO DE DEPENDENCIA para o _context
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
    }
}
