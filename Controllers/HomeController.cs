using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Adams", "000.000.000.00", "adamsgawlinski@gmail.com", "Coxambrinha");
        Cliente cliente2 = new Cliente(02, "Adams2", "000.000.000.00", "adamsgawlinski@gmail.com", "Coxambrinha2");
        Cliente cliente3 = new Cliente(03, "Adams3", "000.000.000.00", "adamsgawlinski@gmail.com", "Coxambrinha3");

        List<Cliente> clientList = new List<Cliente>();
        clientList.Add(cliente1);
        clientList.Add(cliente2);
        clientList.Add(cliente3);

        ViewBag.clientList = clientList;;

        Fornecedor fornecedor = new Fornecedor(01,"C# Net", "00.000.000/0000-00", "c#@gmail.com");

        List<Fornecedor> fornecedorList = new List<Fornecedor>();
        fornecedorList.Add(fornecedor);

        ViewBag.fornecedorList = fornecedorList;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
