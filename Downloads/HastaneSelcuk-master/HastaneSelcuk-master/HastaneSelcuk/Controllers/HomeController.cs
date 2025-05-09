using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HastaneSelcuk.Models;

namespace HastaneSelcuk.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("InfoVideo")]
    public IActionResult InfoVideo()
    {
        return View();
    }
    

    [Route("History")]
    public IActionResult History()
    {
        return View();
    }
    
    
    [Route("Management")]
    public IActionResult Management()
    {
        return View();
    }
    
    [Route("PatientRights")]
    public IActionResult PatientRights()
    {
        return View();
    }
    [Route("Doktorlarimiz")]
    public IActionResult Doktorlarimiz()
    {
        return View();
    }
    [Route("HastaRehberi")]
    public IActionResult HastaRehberi()
    {
        return View();
    }
    [Route("HizliErisim")]
    public IActionResult HizliErisim()
    {
        return View();
    }
    [Route("Iletisim")]
    public IActionResult Iletisim()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
