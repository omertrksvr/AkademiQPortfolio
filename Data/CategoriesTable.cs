using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class CategoriesTable
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<ProjectsTable> ProjectsTables { get; set; } = new List<ProjectsTable>();
}
