using AkademiqPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;

namespace AkademiqPortfolio.Controllers;

public class ProjectController : Controller
{
    private readonly PortfolioDbContext _portfolyodbContext;

    public ProjectController(PortfolioDbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }

    public IActionResult Index()
    {
        // Projeleri kategorileriyle birlikte çekiyoruz
        var value = _portfolyodbContext.Projects.Include(x => x.Category).ToList();
        return View(value);
    }

    [HttpGet]
    public IActionResult ProjectCreate()
    {
        // Dropdown için kategorileri listeliyoruz
        ViewBag.Categories = _portfolyodbContext.Categories.Select(x => new SelectListItem
        {
            Text = x.CategoryName,
            Value = x.CategoryId.ToString()
        }).ToList();

        return View();
    }

    [HttpPost]
    public IActionResult ProjectCreate(ProjectsTable projectsTable)
    {
        _portfolyodbContext.Projects.Add(projectsTable);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }

    // --- GÜNCELLEME (EDIT) KISMI ---

    [HttpGet]
    public IActionResult ProjectUpdate(int id)
    {
        // 1. Güncellenecek veriyi ID üzerinden buluyoruz
        var value = _portfolyodbContext.Projects.Find(id);

        if (value == null)
        {
            return NotFound();
        }

        // 2. Dropdown'ın dolu gelmesi için kategorileri tekrar yüklüyoruz
        ViewBag.Categories = _portfolyodbContext.Categories.Select(x => new SelectListItem
        {
            Text = x.CategoryName,
            Value = x.CategoryId.ToString()
        }).ToList();

        return View(value);
    }

    [HttpPost]
    public IActionResult ProjectUpdate(ProjectsTable projectsTable)
    {
        // Veritabanındaki veriyi güncelliyoruz
        _portfolyodbContext.Projects.Update(projectsTable);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }

    // --- SİLME (DELETE) KISMI ---

    public IActionResult ProjectDelete(int id)
    {
        var value = _portfolyodbContext.Projects.Find(id);
        if (value != null)
        {
            _portfolyodbContext.Projects.Remove(value);
            _portfolyodbContext.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}