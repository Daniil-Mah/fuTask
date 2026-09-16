namespace TaskService.DTO;

public class CreateUser
{
    public string Name { get; set; } = string.Empty;
    public HashCode PasswordHash { get; set; }
}