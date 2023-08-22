namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string name { get; set; } = default!;
    public string email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public string Password { get; set; } = default!;
}