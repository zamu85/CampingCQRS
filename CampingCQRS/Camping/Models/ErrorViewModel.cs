namespace Camping.Domains;

public class ErrorViewDomain
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
