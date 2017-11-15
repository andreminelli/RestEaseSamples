namespace Samples
{

    using Newtonsoft.Json;

    public class MessengerResponse
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }
    }
}
