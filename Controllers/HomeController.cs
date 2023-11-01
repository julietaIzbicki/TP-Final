using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Final.Models;

namespace TP_Final.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Aros = BD.ListarPiercings();
        ViewBag.Lugares = BD.ListarNegocios();
        return View();
    }

    public IActionResult Catalogo()
    {
        ViewBag.Aros = BD.ListarPiercings();
        return View();
    }

    public IActionResult Piercing(int id)
    {
        ViewBag.UnAro = BD.InfoPiercing(id);
        return View();
    }
    
    public IActionResult Lugar(int id)
    {
        ViewBag.UnLugar = BD.InfoSede(id);
        return View();
    }
    
    public IActionResult Reserva()
    {
        ViewBag.Aros = BD.ListarPiercings();
        ViewBag.Lugares = BD.ListarNegocios();
        return View();
    }

    public IActionResult AgregarReserva(string Nombre, string Apellido, string Mail, int Edad, DateTime Fecha,  int IdPiercing, int IdNegocio)
    {
        BD.GuardarReserva(new Reserva (Nombre, Apellido, Mail, Edad, Fecha, IdPiercing, IdNegocio));
        return RedirectToAction("Index", "Home");
    }

    public IActionResult EliminarReserva()
    {
        return View();
    }


    public IActionResult Contacto()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
