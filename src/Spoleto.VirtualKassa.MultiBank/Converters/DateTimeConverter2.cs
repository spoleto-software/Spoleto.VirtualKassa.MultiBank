using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Converters
{
    public class DateTimeConverter2 : JsonConverter<DateTime>
    {
        private const string _format = "yyyy-MM-dd HH:mm:ss";
        private const string _format2 = "yyyyMMddHHmmss";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (DateTime.TryParseExact(reader.GetString(), _format2, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt2))
                return dt2;

            if (DateTime.TryParseExact(reader.GetString(), _format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
                return dt;

            return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(_format2));
        }
    }
}
