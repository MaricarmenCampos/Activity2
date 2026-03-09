namespace NewRepo.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequesStId => !string.IsNullOrEmpty(RequestId);
}
