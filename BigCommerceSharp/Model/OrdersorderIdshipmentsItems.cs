using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ShipmentLineItem
    {
        /// <summary>
        /// Gets or Sets OrderProductId
        /// </summary>
        [DataMember(Name = "order_product_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order_product_id")]
        public int? OrderProductId { get; set; }

        ///// <summary>
        ///// Gets or Sets ProductId
        ///// </summary>
        //[DataMember(Name = "product_id", EmitDefaultValue = false)]
        //[JsonProperty(PropertyName = "product_id")]
        //public int? ProductId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrdersorderIdshipmentsItems {\n");
            sb.Append("  OrderProductId: ").Append(OrderProductId).Append("\n");
            //sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
