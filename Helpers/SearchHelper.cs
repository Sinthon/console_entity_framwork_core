namespace console_entity_framwork_core.Helpers;

public static class SearchHelper
{
    public static Token token { get; set; } = new();

    public static async Task GetTokenAsync()
    {
        string clientID = "f4aefc7c48664c6aa4aba8ef6e744678";

        string clientSecret = "e560dba8bdd2453d97ec2e3ddf2ca2f8";

        string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));

        List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("grant_type", "client_credentials")
        };

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
        HttpContent content = new FormUrlEncodedContent(args);

        HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content);
        string msg = await resp.Content.ReadAsStringAsync();

        token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(msg);
    }

    public static SpotifySearch.SpotifyResult SearchArtistOrSong(string searchWord)
    {
        var client = new RestClient("https://api.spotify.com/v1/search");

        client.AddDefaultHeader("Authorization", $"Bearer {token.access_token}");

        var request = new RestRequest($"?q={searchWord}&type=artist", Method.Get);

        var response = client.Execute(request);

        if (response.IsSuccessful)
        {
            var result = JsonConvert.DeserializeObject<SpotifySearch.SpotifyResult>(response.Content);
            return result;
        }
        else
        {
            Console.WriteLine(response.Content);
            return new();
        }
    }
}