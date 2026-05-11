using MERCADO_MVC.Models;
using MERCADO_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MERCADO_MVC.Controllers
{
    [Route("[controller]")]
    public class MercadoController : Controller
    {
        private readonly MercadoRepository _repository;

        public MercadoController(MercadoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Mercado> mercados = _repository.ObterMercados();
            return View(mercados);
        }
    }
}