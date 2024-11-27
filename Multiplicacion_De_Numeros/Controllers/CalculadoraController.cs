using Microsoft.AspNetCore.Mvc;

namespace MultiplicacionApp.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Resultado(int numero1, int numero2)
        {
            ViewBag.Resultado = numero1 * numero2;
            return View("Index");
        }
    }
}
