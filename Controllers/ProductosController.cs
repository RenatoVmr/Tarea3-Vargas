using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea3VRD.Models;

namespace Tarea3VRD.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ILogger<ProductosController> _logger;

        public ProductosController(ILogger<ProductosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                // Aquí guardarías en base de datos o procesarías la información
                return View("Confirmacion", producto);
            }
            return View(producto);
        }
    }
}
