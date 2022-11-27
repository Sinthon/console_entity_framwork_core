namespace console_entity_framwork_core.Commands;

using console_entity_framwork_core.Helpers;
public partial class Spotity
{

    public Spotity()
    {
        Task.Run(async () => await SearchHelper.GetTokenAsync());
    }

    [Subcommand]
    public Config?  Config { get; set; }

    [Command(name: "search", Description = ": search artist or song")]
    public void Search(string? param)
    {
        if (param == string.Empty)
        {
            return;
        }

        var result = SearchHelper.SearchArtistOrSong(param ?? "");

        if (result == null)
        {
            return;
        }

        var listArtist = new List<SpotifyArtist>();

        foreach (var item in result.artists.items)
        {
            listArtist.Add(new SpotifyArtist()
            {
                ArtistId = item.id,
                Image = item.images.Any() ? item.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                Name = item.name,
                Popularity = $"{item.popularity}% popularidad",
                Followers = $"{item.followers.total.ToString("N")} seguidores"
            });
            
            Console.WriteLine(item.name);
        }

        Console.WriteLine(param);
    }

    [Command(name: "download", Description = "")]
    public void Download(string? param)
    {
        AnsiConsole.Write($"{param}");
    }

    [Command(name: "play", Description = "")]
    public void Play(string? param)
    {
        AnsiConsole.Write($"{param}");
    }
}