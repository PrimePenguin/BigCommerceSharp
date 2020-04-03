using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

    /// <summary>
    /// Request body for refund quotes
    /// </summary>
    [DataContract]
    public class RefundQuoteRequest
    {
        /// <summary>
        /// Order ID against which this refund will be created. This is optional for creating a single refund request. The order ID is included in the request path.
        /// </summary>
        /// <value>Order ID against which this refund will be created. This is optional for creating a single refund request. The order ID is included in the request path.</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order_id")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<RefundQuoteItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "tax_adjustment_amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tax_adjustment_amount")]
        public int TaxAdjustmentAmount { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundQuoteRequest {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  tax_adjustment_amount: ").Append(TaxAdjustmentAmount).Append("\n");
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
    public class RefundQuoteItem
    {
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "item_id")]
        public int ItemId { get; set; }

        [DataMember(Name = "item_type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "item_type")]
        public string ItemType { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }
    }
}
