using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PedidosWeb.Models;

namespace PedidosWeb.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly MeuDbContext _context;

        public FuncionariosController(MeuDbContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index()
        {
            var funcionarios = await _context.Funcionarios.ToListAsync();
            return View(funcionarios);
        }

        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(m => m.Id == id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Email,Celular,Endereco")] Funcionarios funcionario)
        {
            if (funcionario == null)
            {
                throw new ArgumentNullException(nameof(funcionario));
            }

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(funcionario);
                    await _context.SaveChangesAsync();
                    TempData["MensagemSucesso"] = "Funcionário cadastrado com sucesso";
                    return RedirectToAction(nameof(Index));
                }
                return View(funcionario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não foi possível cadastrar o funcionário. Detalhes do erro: {erro.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios.FindAsync(id);

            if (funcionario == null)
            {
                return NotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Email,Celular,Endereco")] Funcionarios funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                    TempData["MensagemSucesso"] = "Funcionário alterado com sucesso";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(funcionario);
        }

        private bool FuncionarioExists(int id)
        {
            return _context.Funcionarios.Any(e => e.Id == id);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(m => m.Id == id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario != null)
            {
                _context.Funcionarios.Remove(funcionario);
                await _context.SaveChangesAsync();
                TempData["MensagemSucesso"] = "Funcionário excluído com sucesso";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
