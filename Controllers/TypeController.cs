using Microsoft.AspNetCore.Mvc;

namespace Avaliacao1TecnicasDeProgramacao.Controllers
{
    public class TypeController : Controller
    {
        private readonly ILogger<TypeController> _logger;
        public TypeController(ILogger<TypeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Type()
        {
            return View();
        }

        public IActionResult Sofa()
        {
            return View();
        }


    }
}
