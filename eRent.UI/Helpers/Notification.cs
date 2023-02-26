using Newtonsoft.Json;

namespace eRent.UI.Helpers
{
    public class notification
    {
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("click_action")]
        public string ClickAction { get; set; }
    }
}
