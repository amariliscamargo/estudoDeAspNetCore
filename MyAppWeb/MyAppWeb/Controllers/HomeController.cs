using Microsoft.AspNetCore.Mvc;

namespace MyAppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _repository;
        
        public HomeController(IProdutoRepository repository)
        {
            _repository = repository;
        }
        // GET
        public IActionResult Index()
        {
            return View(_repository.ListarProdutos());
        }
    }
}