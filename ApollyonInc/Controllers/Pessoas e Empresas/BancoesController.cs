using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApollyonInc.Data;
using ApollyonInc.Models.Pessoas_e_Empresas;

namespace ApollyonInc.Controllers
{
    public class BancoesController : Controller
    {
        private readonly ApollyonIncContext _context;

        public BancoesController(ApollyonIncContext context)
        {
            _context = context;
        }

        // GET: Bancoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Banco.ToListAsync());
        }

        // GET: Bancoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banco = await _context.Banco
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banco == null)
            {
                return NotFound();
            }

            return View(banco);
        }

        // GET: Bancoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bancoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoBanco,NomeDoBanco")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(banco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banco);
        }

        // GET: Bancoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banco = await _context.Banco.FindAsync(id);
            if (banco == null)
            {
                return NotFound();
            }
            return View(banco);
        }

        // POST: Bancoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoBanco,NomeDoBanco")] Banco banco)
        {
            if (id != banco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(banco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BancoExists(banco.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(banco);
        }

        // GET: Bancoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banco = await _context.Banco
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banco == null)
            {
                return NotFound();
            }

            return View(banco);
        }

        // POST: Bancoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var banco = await _context.Banco.FindAsync(id);
            _context.Banco.Remove(banco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BancoExists(int id)
        {
            return _context.Banco.Any(e => e.Id == id);
        }
    }
}
