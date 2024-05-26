#pragma warning disable CS8618

namespace CookieAuthenticationSchemaApp.Dtos;

public class LoginDto
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string? ReturnUrl { get; set; }
}