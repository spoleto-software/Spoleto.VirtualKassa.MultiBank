using System.Text.Json.Serialization;

namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class FiscalModuleStatusDB
    {
        [JsonPropertyName("ArchivedFiles")]
        public Dictionary<string, int> ArchivedFiles { get; set; }

        public override string ToString() => $"{String.Join(Environment.NewLine, ArchivedFiles.Select(x => $"{x.Key} :  + {x.Value}"))}";
    }
}