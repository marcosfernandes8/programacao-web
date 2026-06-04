using Microsoft.AspNetCore.Mvc;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Produtos = new List<String>
        {
            "Celular","Notebook","Tablet","Computador","Fone de Ouvido"
        };

        ViewBag.Precos = new List<double>
        {
          1.319, 3.498, 1.340, 4.999, 99.99
        };

        return View();
    }
}