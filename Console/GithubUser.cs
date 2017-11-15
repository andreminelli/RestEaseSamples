namespace Samples
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class GithubUser
    {
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("bio")]
        public object Bio { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("company")]
        public object Company { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers")]
        public long Followers { get; set; }

        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty("following")]
        public long Following { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("hireable")]
        public object Hireable { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty("public_gists")]
        public long PublicGists { get; set; }

        [JsonProperty("public_repos")]
        public long PublicRepos { get; set; }

        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
