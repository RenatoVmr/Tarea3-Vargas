using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea3VRD.Models;

namespace Tarea3VRD.Controllers
{
    public class MascotasController : Controller
    {
        private readonly ILogger<MascotasController> _logger;

        public MascotasController(ILogger<MascotasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                // Aquí guardarías en base de datos o procesarías la información
                // Por ahora lo enviamos a una vista de confirmación
                return View("Confirmacion", mascota);
            }
            return View(mascota);
        }
    }
}
