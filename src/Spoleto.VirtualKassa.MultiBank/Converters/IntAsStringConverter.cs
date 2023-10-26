using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Converters
{
    public class IntAsStringConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString();
                var value = Convert.ToInt32(str);

                return value;
            }

            var intValue = reader.GetInt32();
            return intValue;
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
