namespace console_entity_framwork_core.Models;

public class Token
    {
        public string access_token { get; set; } = string.Empty;

        public string token_type { get; set; } = string.Empty;

        public int expires_in { get; set; }
    }