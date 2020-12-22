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
    public class DadoBancariosController : Controller
    {
        private readonly ApollyonIncContext _context;

        public DadoBancariosController(ApollyonIncContext context)
        {
            _context = context;
        }

        // GET: DadoBancarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.DadoBancario.ToListAsync());
        }

        // GET: DadoBancarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadoBancario = await _context.DadoBancario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dadoBancario == null)
            {
                return NotFound();
            }

            return View(dadoBancario);
        }

        // GET: DadoBancarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DadoBancarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Agencia,DigitoAgencia,Conta,DigitoConta,Observacoes,Ativo,Padrao")] DadoBancario dadoBancario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadoBancario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dadoBancario);
        }

        // GET: DadoBancarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadoBancario = await _context.DadoBancario.FindAsync(id);
            if (dadoBancario == null)
            {
                return NotFound();
            }
            return View(dadoBancario);
        }

        // POST: DadoBancarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Agencia,DigitoAgencia,Conta,DigitoConta,Observacoes,Ativo,Padrao")] DadoBancario dadoBancario)
        {
            if (id != dadoBancario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dadoBancario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DadoBancarioExists(dadoBancario.Id))
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
            return View(dadoBancario);
        }

        // GET: DadoBancarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dadoBancario = await _context.DadoBancario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dadoBancario == null)
            {
                return NotFound();
            }

            return View(dadoBancario);
        }

        // POST: DadoBancarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dadoBancario = await _context.DadoBancario.FindAsync(id);
            _context.DadoBancario.Remove(dadoBancario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DadoBancarioExists(int id)
        {
            return _context.DadoBancario.Any(e => e.Id == id);
        }
    }
}
