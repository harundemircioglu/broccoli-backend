namespace Business.Models.Request.Functional;

public class LoginDto
{
    public string email { get; set; } = default!;
    public string Password { get; set; } = default!;
}