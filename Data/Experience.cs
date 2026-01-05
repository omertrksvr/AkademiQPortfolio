using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class Experience
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? CompanyName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }
}
