using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class Education
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? InstutionName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }
}
