using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.IdentityModel.Tokens;
using primerparcial_migraciones.Datos;
using primerparcial_migraciones.Models;
using System.Diagnostics;

namespace primerparcial_migraciones.Datos
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GestionMedicaContext _context;
        public HomeController(ILogger<HomeController> logger, GestionMedicaContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]

        public IActionResult Index()
        {
            var pacientes = _context.Pacientes.ToList();
            var medicos = _context.Medicos.ToList();
            var usuarios = _context.Usuario.ToList();

            var vistaModelo = new VistaModelos
            {
                Pacientes = pacientes,
                Medicos = medicos,
                Usuario = usuarios
            };

            return View(vistaModelo);

  

            

        }
  
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}