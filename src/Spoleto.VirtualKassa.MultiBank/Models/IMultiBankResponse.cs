namespace Spoleto.VirtualKassa.MultiBank.Models
{
    /// <summary>
    /// The base interface for MultiBank responses.
    /// </summary>
    public interface IMultiBankResponse
    {
        /// <summary>
        /// Success?
        /// </summary>
        bool Success { get; set; }
    }
}
