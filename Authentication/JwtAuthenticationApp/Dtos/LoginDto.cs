namespace JwtAuthenticationApp.Dtos;

public class LoginDto
{
    public required string Login { get; set; }
    public required string Password { get; set; }
}