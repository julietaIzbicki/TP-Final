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
    
    public IActionResult Personal(int id)
    {
        ViewBag.Personal = BD.ListarPersonal(id);
        return View();
    }
    
    public IActionResult Reserva()
    {
        ViewBag.Aros = BD.ListarPiercings();
        ViewBag.Lugares = BD.ListarNegocios();
        return View();
    }

    public Reserva AgregarReserva(string Nombre, string Apellido, string Mail, int Edad,  int Aro, int Negocio, DateTime Fecha)
    {
        Reserva res = BD.GuardarReserva(new Reserva(Nombre, Apellido, Mail, Edad, Aro, Negocio, Fecha));
        ViewBag.Reserva = res;
        return res;
    }

    [HttpGet]
    public int EliminarReserva(string mail)
    {
        BD.ElmiminarReserva(mail);
        return 0;
    }

    [HttpGet]
    public int Likeando(int id)
    {
        BD.AgregarLikes(id);
        return 0; 
    }

    public IActionResult Contacto()
    {
        ViewBag.Lugares = BD.ListarNegocios();
        return View();
    }

    public IActionResult ReservaConfirmada()
    {
        return View();
    }

    public IActionResult ReservaEliminada()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
