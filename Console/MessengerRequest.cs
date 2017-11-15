namespace Samples
{
    using Newtonsoft.Json;

    public class MessengerRequest
    {
        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("messaging_type")]
        public string MessagingType { get; set; }

        [JsonProperty("recipient")]
        public Recipient Recipient { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Message
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
