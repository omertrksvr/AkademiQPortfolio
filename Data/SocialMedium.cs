using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class SocialMedium
{
    public int Id { get; set; }

    public string? Platform { get; set; }

    public string? Icon { get; set; }

    public string? Url { get; set; }
}
