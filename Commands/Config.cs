namespace console_entity_framwork_core.Commands;

using console_entity_framwork_core.Helpers;

[Command(name: "config")]
public class Config
{
    public Config()
    {

    }

    [Command(name: "client-id")]
    public void ClientId()
    {
        var client_id = ConfigHelper.GetClientId();
        Console.WriteLine(client_id);
    }

    [Command(name: "client-id-update")]
    public void UpdateClientId(string client_id)
    {
        if (client_id == string.Empty)
        {
            return;
        }

        try
        {
            var result = ConfigHelper.UpdateClientId(client_id);

            if (result != null)
            {
                AnsiConsole.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            AnsiConsole.WriteLine($" Error: {ex.Message}");
        }
    }
}