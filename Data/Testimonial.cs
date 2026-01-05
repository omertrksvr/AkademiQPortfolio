using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class Testimonial
{
    public int Id { get; set; }

    public string NameSurname { get; set; } = null!;

    public string? Title { get; set; }

    public string? ImageUrl { get; set; }

    public string Comment { get; set; } = null!;
}
