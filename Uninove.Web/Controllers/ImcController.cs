using Microsoft.AspNetCore.Mvc;

public class ImcController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ImcViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        model.Resultado = model.Peso / (model.Altura * model.Altura);

        if (model.Resultado < 18.5)
            model.Classificacao = "Abaixo do peso";
        else if (model.Resultado < 25)
            model.Classificacao = "Peso normal";
        else if (model.Resultado < 30)
            model.Classificacao = "Sobrepeso";
        else
            model.Classificacao = "Obesidade";

        return View(model);
    }
}