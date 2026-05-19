using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Marcos";
        ViewBag.Curso = "ADS";
        ViewBag.Semestre = "Primeiro Semestre";

        return View();

    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.AlunoId = id;
        return View();
    }

    public IActionResult Sobre()
    {
        return View();
    }
}