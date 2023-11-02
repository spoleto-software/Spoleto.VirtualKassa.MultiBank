using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Converters
{
    public class MultiplyDivide100Converter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            decimal d;
            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString();
                d = Convert.ToDecimal(str);
            }
            else
            {
                d = reader.GetDecimal();
            }

            var divided = d / 100M;

            return divided;
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            var multiplied = value * 100M;

            writer.WriteNumberValue(multiplied);
        }
    }
}
