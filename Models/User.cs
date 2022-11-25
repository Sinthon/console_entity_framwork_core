namespace console_entity_framwork_core.Models;

public partial class User
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public string Username { get;set; } = string.Empty;
    public string Password { get;set; } = string.Empty;
}