using Microsoft.AspNetCore.Mvc;
using TarefasApp.Models;
using TarefasApp.Data;

namespace TarefasApp.Controllers
{
    public class TarefasController : Controller
    {
        private readonly AppDbContext _context;

        public TarefasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Tarefas.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Edit(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}