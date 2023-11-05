namespace SharedLib.Models;

public class SendMessageRequestModel
{
    public string? From { get; set; }
    public string? Message { get; set; }

    public override string ToString() => $"{From ?? "Unknown"}: {Message}";
}