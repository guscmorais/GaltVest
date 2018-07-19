using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GaltVest.Controllers
{
    public class DashboardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult BemVindo(string nome, int NumVezes)
        {
            ViewData["Mensagem"] = "Olá, " + nome;
            ViewData["NumVezes"] = NumVezes;
            return View();
        }
    }
}
