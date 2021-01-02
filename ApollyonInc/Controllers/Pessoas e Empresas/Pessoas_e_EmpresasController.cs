using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApollyonInc.Data;
using ApollyonInc.Models.Pessoas_e_Empresas;
using X.PagedList;

namespace ApollyonInc.Controllers
{
    public class Pessoas_e_EmpresasController : Controller
    {
        private readonly ApollyonIncContext _context;

        public Pessoas_e_EmpresasController(ApollyonIncContext context)
        {
            _context = context;
        }

        //Verficar se Cliente Já está Cadastrado

        public async Task<JsonResult> CPFCNPJExisteAsync(string cpfcnpj)
        {
            if (await _context.Pessoas_e_Empresas.AnyAsync(x => x.CPFCNPJ == cpfcnpj))
                return Json("CPF ou CNPJ já cadastrado no sistema!");
            return Json(true);
        }

        // GET: Pessoas_e_Empresas
        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPorPagina = 10;
            int numeroPagina = (pagina ?? 1);
            return View(await _context.Pessoas_e_Empresas.ToPagedListAsync(numeroPagina, itensPorPagina));
        }
        
        [HttpPost]
        //Procura de Pessoas e empresas no Index
        public async Task<IActionResult> Index(string txtProcurar)
        {
            if (!String.IsNullOrEmpty(txtProcurar))
            {
                return View(await _context.Pessoas_e_Empresas.Where(x => x.NomeRazaoSocial.ToUpper().Contains(txtProcurar.ToUpper())).ToListAsync());
            }
            return View(await _context.Pessoas_e_Empresas.ToListAsync());
        }

        // GET: Pessoas_e_Empresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoas_e_Empresas = await _context.Pessoas_e_Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoas_e_Empresas == null)
            {
                return NotFound();
            }

            return View(pessoas_e_Empresas);
        }

        // GET: Pessoas_e_Empresas/Create
        public IActionResult CreatePE()
        {
            return View();
        }

        // POST: Pessoas_e_Empresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePE([Bind("Id,Cliente,PessoaFisica,PessoaJuridica,DataDeCadastro,Status,NomeSocial,NomeRazaoSocial,ApelidoNomeFantasia,CPFCNPJ,IndicadorDaIEDoDestinatario,RGInscricaoEstadual,InscricaoMunicipal,EmissorDoRG,UFDoEmissor,Sexo,Aniversario,Telefone,Celular,Email,EmailParaNFE,Site,Observacao,LimiteDeCredito,IssRetidoNaFonte,ConsumidorFinal,ProdutorRural,Serasa")] Pessoas_e_Empresas pessoas_e_Empresas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoas_e_Empresas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoas_e_Empresas);
        }

        // GET: Pessoas_e_Empresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoas_e_Empresas = await _context.Pessoas_e_Empresas.FindAsync(id);
            if (pessoas_e_Empresas == null)
            {
                return NotFound();
            }
            return View(pessoas_e_Empresas);
        }

        // POST: Pessoas_e_Empresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteBloqueado,Cliente,PessoaFisica,PessoaJuridica,Fornecedor,Funcionario,DataDeCadastro,Status,NomeSocial,NomeRazaoSocial,ApelidoNomeFantasia,CPFCNPJ,IndicadorDaIEDoDestinatario,RGInscricaoEstadual,InscricaoMunicipal,EmissorDoRG,UFDoEmissor,Sexo,Aniversario,Telefone,Celular,Email,EmailParaNFE,Site,Observacao,LimiteDeCredito,IssRetidoNaFonte,ConsumidorFinal,ProdutorRural,Serasa")] Pessoas_e_Empresas pessoas_e_Empresas)
        {
            if (id != pessoas_e_Empresas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoas_e_Empresas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Pessoas_e_EmpresasExists(pessoas_e_Empresas.Id))
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
            return View(pessoas_e_Empresas);
        }

        // GET: Pessoas_e_Empresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoas_e_Empresas = await _context.Pessoas_e_Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoas_e_Empresas == null)
            {
                return NotFound();
            }

            return View(pessoas_e_Empresas);
        }

        // POST: Pessoas_e_Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoas_e_Empresas = await _context.Pessoas_e_Empresas.FindAsync(id);
            _context.Pessoas_e_Empresas.Remove(pessoas_e_Empresas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Pessoas_e_EmpresasExists(int id)
        {
            return _context.Pessoas_e_Empresas.Any(e => e.Id == id);
        }
    }
}
