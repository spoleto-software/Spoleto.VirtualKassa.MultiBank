using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class IkpuCheckInfoDataData
    {
        [JsonPropertyName("mxikCode")]
        public string MxikCode { get; set; }

        [JsonPropertyName("info")]
        public IkpuCheckInfoDataInfo Info { get; set; }

        public override string ToString() => $"{nameof(MxikCode)} = {MxikCode}, {nameof(Info)} = {Info}";
    }
}