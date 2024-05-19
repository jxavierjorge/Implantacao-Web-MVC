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
        // instancias do tipo cliente
        Cliente c1 = new Cliente(1, "Arthur", "950.491.610-45", "arthur@mail.com", "Bidu");
        Cliente c2 = new Cliente(2, "Claudio", "010.382.150-30", "claudio@mail.com", "Fuffy");
        Cliente c3 = new Cliente(3, "Jorge", "409.435.180-91", "jorge@mail.com", "Cookie");
        Cliente c4 = new Cliente(4, "Ana", "305.332.490-31", "ana@mail.com", "Benny");
        Cliente c5 = new Cliente(5, "Maria", "641.421.820-05", "maria@mail.com", "Aurora");

        //Lista de clientes

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(c1);
        listaClientes.Add(c2);
        listaClientes.Add(c3);
        listaClientes.Add(c4);
        listaClientes.Add(c5);

        // instancias do tipo fornecedor

        Fornecedor f1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor f2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor f3 = new Fornecedor(03, "Bootspet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor f4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor f5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        // Lista de fornecedores

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(f1);
        listaFornecedores.Add(f2);
        listaFornecedores.Add(f3);
        listaFornecedores.Add(f4);
        listaFornecedores.Add(f5);


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
