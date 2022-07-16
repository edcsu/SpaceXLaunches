using System.Text.Json.Serialization;

namespace SpaceXLaunches.Dtos
{
    public class Links
    {
        [JsonPropertyName("article_link")]
        public Uri ArticleLink { get; set; }

        [JsonPropertyName("flickr_images")]
        public List<Uri> FlickrImages { get; set; }

        [JsonPropertyName("mission_patch_small")]
        public Uri MissionPatchSmall { get; set; }

        [JsonPropertyName("mission_patch")]
        public Uri MissionPatch { get; set; }

        [JsonPropertyName("presskit")]
        public Uri Presskit { get; set; }

        [JsonPropertyName("reddit_campaign")]
        public object RedditCampaign { get; set; }

        [JsonPropertyName("reddit_launch")]
        public Uri RedditLaunch { get; set; }

        [JsonPropertyName("reddit_media")]
        public object RedditMedia { get; set; }

        [JsonPropertyName("reddit_recovery")]
        public object RedditRecovery { get; set; }

        [JsonPropertyName("video_link")]
        public Uri VideoLink { get; set; }

        [JsonPropertyName("wikipedia")]
        public Uri Wikipedia { get; set; }
    }
}
