namespace  console_entity_framwork_core.Models;

public class Client
{
    public int ClientId { get; set; }
    public string ClientRefId { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;
}