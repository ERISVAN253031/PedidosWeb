using Microsoft.AspNetCore.Mvc;
using PedidosWeb.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace PedidosWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly MeuDbContext _context;

        public HomeController(MeuDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Logar(string nome, string senha)
        {
            return Json(new { });
        }
    }
}