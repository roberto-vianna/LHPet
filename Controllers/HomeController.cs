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
        Cliente cliente1 = new Cliente(01, "Roberto", "061.222.673-76", "arthur@gmail", "madruga");
        Cliente cliente2 = new Cliente(02, "Fulano", "064.222.673-76", "fulano@gmail", "espeto");
        Cliente cliente3 = new Cliente(03, "ciclano", "066.222.673-76", "cliclano@gmail", "fumaça");

        /// instancias do tipo clientes  e atribuir os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;

        /// instancias do tipo fornecedor  e atribuir os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Roberto", "061.222.673-76", "arthur@gmail");
        Fornecedor fornecedor2 = new Fornecedor(02, "Fulano", "064.222.673-76", "fulano@gmail");
        Fornecedor fornecedor3 = new Fornecedor(03, "ciclano", "066.222.673-76", "cliclano@gmail");


        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);

        ViewBag.listaFornecedores = listaFornecedores;


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
