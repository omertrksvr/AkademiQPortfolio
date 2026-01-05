using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class About
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string? Cvlink { get; set; }
}
