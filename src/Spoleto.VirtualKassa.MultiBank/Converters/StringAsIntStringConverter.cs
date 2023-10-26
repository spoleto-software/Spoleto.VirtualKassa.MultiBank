using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Converters
{
    public class StringAsIntStringConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            if (reader.TokenType == JsonTokenType.Number)
            {
                var number = reader.GetInt32();
                var value = number.ToString();

                return value;
            }

            var strValue = reader.GetString();
            return strValue;
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
