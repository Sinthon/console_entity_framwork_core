namespace  console_entity_framwork_core.Models;

public class SpotifySearch
    {
        public class ExternalUrls
        {
            public string spotify { get; set; } = string.Empty;
        }

        public class Followers
        {
            public object href { get; set; } = string.Empty;
            public int total { get; set; }
        }

        public class ImageSP
        {
            public int width { get; set; }
            public string url { get; set; } = string.Empty;
            public int height { get; set; }
        }

        public class Item
        {
            public ExternalUrls external_urls { get; set; } = new();
            public Followers followers { get; set; } = new();
            public List<string> genres { get; set; } = new();
            public string href { get; set; } = string.Empty;
            public string id { get; set; }  = string.Empty;
            public List<ImageSP> images { get; set; } = new();
            public string name { get; set; } = string.Empty;
            public int popularity { get; set; }
            public string type { get; set; } = string.Empty;
            public string uri { get; set; } = string.Empty;
        }

        public class Artists
        {
            public string href { get; set; } = string.Empty;
            public List<Item> items { get; set; } = new();
            public int limit { get; set; }
            public string next { get; set; } = string.Empty;
            public int offset { get; set; }
            public object previous { get; set; } = new();
            public int total { get; set; }
        }

        public class SpotifyResult
        {
            public Artists artists { get; set; } = new();
        }
    }