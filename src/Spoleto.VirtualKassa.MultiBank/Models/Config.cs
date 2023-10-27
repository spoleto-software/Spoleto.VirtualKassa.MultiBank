using System.Reflection.PortableExecutable;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class Config
    {
        [JsonPropertyName("transitional")]
        public Transitional Transitional { get; set; }

        [JsonPropertyName("transformRequest")]
        public List<object> TransformRequest { get; set; }

        [JsonPropertyName("transformResponse")]
        public List<object> TransformResponse { get; set; }

        [JsonPropertyName("timeout")]
        public int Timeout { get; set; }

        [JsonPropertyName("xsrfCookieName")]
        public string XsrfCookieName { get; set; }

        [JsonPropertyName("xsrfHeaderName")]
        public string XsrfHeaderName { get; set; }

        [JsonPropertyName("maxContentLength")]
        public int MaxContentLength { get; set; }

        [JsonPropertyName("maxBodyLength")]
        public int MaxBodyLength { get; set; }

        [JsonPropertyName("headers")]
        public Headers Headers { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}