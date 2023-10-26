using System.Text.Json;
using System.Text.Json.Serialization;
using Spoleto.VirtualKassa.MultiBank.Models;

namespace Spoleto.VirtualKassa.MultiBank.Converters
{
    public class SlipResultItemInfoConverter : JsonConverter<List<SlipResultItemInfo>>
    {
        //private static readonly JsonConverter<List<SlipResultItemInfo>> _defaultConverter =
        //(JsonConverter<List<SlipResultItemInfo>>)JsonSerializerOptions.Default.GetConverter(typeof(List<SlipResultItemInfo>));

        public override List<SlipResultItemInfo> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString();
                var listByString = JsonSerializer.Deserialize<List<SlipResultItemInfo>>(str, options);

                return listByString;
            }

            var list = JsonSerializer.Deserialize<List<SlipResultItemInfo>>(ref reader, options);
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<SlipResultItemInfo> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
