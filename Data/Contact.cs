using System;
using System.Collections.Generic;

namespace AkademiqPortfolio.Data;

public partial class Contact
{
    public int Id { get; set; }

    public string? Phone { get; set; }

    public string? MailAddress { get; set; }

    public string? Address { get; set; }
}
