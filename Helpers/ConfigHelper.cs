namespace console_entity_framwork_core.Helpers;

using console_entity_framwork_core.Data;
public static class ConfigHelper
{

    public static string GetClientId()
    {
        using (var dbContext = new Data.DataContext())
        {
            return dbContext.Clients?.FirstOrDefault()?.ClientRefId ?? "Null";
        }
    }

    public static string UpdateClientId(string client_id)
    {

        using (var dbContext = new Data.DataContext())
        {

            var has_clint = dbContext.Clients?.Any() ?? false;

            if (!has_clint)
            {
                dbContext?.Clients?.Add(new()
                {
                    ClientRefId = client_id,
                });

                return "";
            } 

            var client = dbContext?.Clients?.FirstOrDefault();
            if (client != null)
            {
                client.ClientRefId = client_id;
                dbContext?.SaveChangesAsync();
            }

            return client?.ClientRefId ?? string.Empty;
        }
    }
}