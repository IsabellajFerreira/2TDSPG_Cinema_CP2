using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using _2TDSPG_Cinema.Models;
using _2TDSPG_Cinema.Data;

namespace _2TDSPG_Cinema.Controllers
{
    public class SessaoController : Controller
    {
        private readonly DataContext _context;

        public SessaoController(DataContext context)
        {
            _context = context;
        }

        // GET: Sessao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sessoes.ToListAsync());
        }

        // GET: Sessao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessoes
                .FirstOrDefaultAsync(m => m.Id == id);

            if (sessao == null)
            {
                return NotFound();
            }

            return View(sessao);
        }

        // GET: Sessao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sessao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Horario,Capacidade,IngressosDisponiveis")] Sessao sessao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sessao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sessao);
        }

        // GET: Sessao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessoes
                .FirstOrDefaultAsync(m => m.Id == id);

            if (sessao == null)
            {
                return NotFound();
            }

            return View(sessao);
        }

        // POST: Sessao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sessao = await _context.Sessoes.FindAsync(id);
            _context.Sessoes.Remove(sessao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessaoExists(int id)
        {
            return _context.Sessoes.Any(e => e.Id == id);
        }


    }
}
