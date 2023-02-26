using Newtonsoft.Json;

namespace eRent.UI.Helpers
{
    public class FCMNotification
    {
        [JsonProperty("to")]
        public string to { get; set; }
        [JsonProperty("notification")]
        public notification notification { get; set; }
        // Add other fields as needed
    }
}
