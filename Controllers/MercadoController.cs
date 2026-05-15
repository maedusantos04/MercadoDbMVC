using MERCADO_MVC.Models;
using MERCADO_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MERCADO_MVC.Controllers
{
    public class MercadoController : Controller
    {
        private readonly MercadoRepository _repository;

        public MercadoController(MercadoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista";
            List<Mercado> mercados = _repository.ObterMercados();
            ViewBag.TotalProdutos = mercados.Count;
            return View(mercados);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            ViewData["Title"] = "Cadastro";
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Mercado m)
        {
            string precoString = Request.Form["preco"].ToString().Replace(".", ",");

            if (decimal.TryParse(precoString, out var precoConvertido))
            {
                m.Preco = precoConvertido;
            }

            _repository.Adicionar(m);

            return RedirectToAction("Index");
        }
    }
}