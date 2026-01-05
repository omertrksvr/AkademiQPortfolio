using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using static Portfolio.Data.PortfolioDbContext;
using System.Diagnostics;

namespace AkademiQPortfolio.Controllers;

public class ServicesController : Controller
{
    private readonly PortfolioDbContext _portfolyodbContext;

    public ServicesController(PortfolioDbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }


    public IActionResult Index()
    {
        var values = _portfolyodbContext.Services.ToList();
        return View(values);
    }


    [HttpGet]
    public IActionResult CreateServices()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateServices(Service service)
    {
        _portfolyodbContext.Services.Add(service);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateServices(int id)
    {
        // Eğer ID gelmemişse veya 0 ise direkt Index'e gönder
        if (id == 0) return RedirectToAction("Index");

        var value = _portfolyodbContext.Services.Find(id);

        // Eğer veritabanında bu ID bulunamadıysa hata sayfası yerine Index'e gönder
        if (value == null) return RedirectToAction("Index");

        return View(value);
    }

    [HttpPost]
    public IActionResult UpdateServices(Service service)
    {
        _portfolyodbContext.Services.Update(service);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult DeleteServices(int id) 
    {
        var value = _portfolyodbContext.Services.Find(id);
        _portfolyodbContext.Services.Remove(value);

        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }



}