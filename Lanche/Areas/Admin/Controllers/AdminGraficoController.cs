using LanchesMac.Areas.Admin.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {    
        private readonly GraficoVendasService _graficoVendas;

        public AdminGraficoController(GraficoVendasService graficoVendas)
        {
            _graficoVendas = graficoVendas;
        }
        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendas.GetVendasLanches(dias);
            return Json(lanchesVendasTotais);
        }
        [HttpGet] //esse calcula as vendas dos 360 dias
        public IActionResult Index(int dias)
        {
            return View();
        }
        [HttpGet] //esse calcula as vendas mensais
        public IActionResult VendasMensal(int dias)
        {
            return View();
        }
        [HttpGet]// esse calcula vendas semanais
        public IActionResult VendasSemanal(int dias)
        {
            return View();
        }
    }
}
