namespace NewRepo.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequessStId => !string.IsNullOrEmpty(RequestId);
}
