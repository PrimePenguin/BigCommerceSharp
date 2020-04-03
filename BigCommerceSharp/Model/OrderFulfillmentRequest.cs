using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model
{
    public class OrderFulfillmentRequest
    {
    }

    public class UpdateOrderRequest
    { 
        /// <summary>
        /// Status id
        /// </summary>
        /// <value>Numeric ID of this product within this order.</value>
        [DataMember(Name = "status_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status_id")]
        public int StatusId { get; set; }
    }
}
