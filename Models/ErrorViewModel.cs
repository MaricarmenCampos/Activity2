namespace NewRepo.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequeStId => !string.IsNullOrEmpty(RequestId);
}
