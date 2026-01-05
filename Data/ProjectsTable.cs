using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class ProjectsTable
{
    public int ProjectId { get; set; }
    public string? ProjectName { get; set; }
    public string? Title { get; set; }
    public string? Image { get; set; }
    public int? CategoryId { get; set; }

    // Navigation Property: CategoriesTable ismini kullandığınız için böyle olmalı
    public virtual CategoriesTable? Category { get; set; }
}