using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

public class _SkillComponentPartialViewComponent : ViewComponent
{
    private readonly PortfolioDbContext _context;
    public _SkillComponentPartialViewComponent(PortfolioDbContext context) => _context = context;

    public IViewComponentResult Invoke()
    {
        var values = _context.SkillTables.ToList();
        return View(values);
    }
}