using Microsoft.AspNetCore.Mvc;

public class EnderecoController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Salvar(EnderecoViewModel model)
    {
        return View("Confirmacao", model);
    }
}