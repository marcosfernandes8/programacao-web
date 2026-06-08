using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
public class AlunoController : Controller
{

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        return View(aluno);
    }

}