using System.Collections;
using System.Text.Json;
using System.Web;
using Spoleto.Common.Helpers;

namespace Spoleto.VirtualKassa.MultiBank.Helpers
{
    /// <summary>
    /// The http helper for creating requests, processing responses.
    /// </summary>
    public class HttpHelper
    {
        /// <summary>
        /// Converts to query string.
        /// </summary>
        /// <returns></returns>
        public static string ToQueryString<T>(T body)
        {
            var bodyJson = JsonHelper.ToJson(body);
            var dictionaryAsObjectValues = JsonHelper.FromJson<Dictionary<string, object>>(bodyJson);

            var args = new List<string>();
            foreach (var key in dictionaryAsObjectValues.Keys)
            {
                var jsonValue = (JsonElement)dictionaryAsObjectValues[key];
                var objValue = FlattenJsonValue(jsonValue);
                if (objValue is string str)
                {
                    args.Add($"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(str)}");
                }
                else if (objValue is IEnumerable enumerable)
                {
                    foreach (string item in enumerable)
                    {
                        args.Add($"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(item)}");
                    }
                }
            }

            return string.Join("&", args);
        }

        private static object? FlattenJsonValue(JsonElement objValue)
            => objValue.ValueKind switch
            {
                JsonValueKind.String => objValue.GetString(),
                JsonValueKind.Array => objValue.EnumerateArray().Select(FlattenJsonValue),
                _ => objValue.GetRawText()
            };
    }
}
