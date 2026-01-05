namespace AkademiqPortfolio.Data;

public partial class Message
{
    public int Id { get; set; }
    public string NameSurname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string MessageContent { get; set; } = null!;

    // Eksik olan bu iki alanı ekle:
    public DateTime SendDate { get; set; }
    public bool IsRead { get; set; }
}