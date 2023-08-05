namespace Spoleto.VirtualKassa.MultiBank.Models
{
    public class EmptyResponse : IMultiBankResponse
    {
        bool IMultiBankResponse.Success { get => true; set { } }
    }
}
