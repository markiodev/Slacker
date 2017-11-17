using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Slacker
{
    public class SlackClient
    {
        private readonly Encoding _encoding = new UTF8Encoding();
        private readonly Uri _uri;

        public SlackClient(string urlWithAccessToken)
        {
            this._uri = new Uri(urlWithAccessToken);
        }

        public void PostMessage(string text, string username = null, string channel = null)
        {
            var payload = new ChannelMessagePayload
                          {
                              Channel = channel,
                              Username = username,
                              Text = text
                          };

            this.PostMessage(payload);
        }

        public void PostMessage(ChannelMessagePayload channelMessagePayload)
        {
            var payloadJson = JsonConvert.SerializeObject(channelMessagePayload);

            using(var client = new WebClient())
            {
                var data = new NameValueCollection();
                data["payload"] = payloadJson;

                var response = client.UploadValues(this._uri, "POST", data);

                var responseText = this._encoding.GetString(response);
            }
        }
    }

    public class ChannelMessagePayload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}