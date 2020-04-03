using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model
{
    /// <summary>
    /// Request body for refund requests
    /// </summary>
    [DataContract]
    public class RefundRequest
    {
        /// <summary>
        /// Order id against which this refund will be created
        /// </summary>
        /// <value>Order id against which this refund will be created</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order_id")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<RefundLineItem> Items { get; set; }

        /// <summary>
        /// Reason for refund
        /// </summary>
        /// <value>Reason for refund</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payments")]
        public List<PaymentRequest> Payments { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundRequest {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
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

        public class RefundLineItem
        {
            /// <summary>
            /// Item Id
            /// </summary>
            /// <value>Reason for refund</value>
            [DataMember(Name = "item_id", EmitDefaultValue = false)]
            [JsonProperty(PropertyName = "item_id")]
            public int ItemId { get; set; }

            /// <summary>
            /// Item type
            /// </summary>
            /// <value>Reason for refund</value>
            [DataMember(Name = "item_type", EmitDefaultValue = false)]
            [JsonProperty(PropertyName = "item_type")]
            public string ItemType { get; set; }

            /// <summary>
            /// Quantity
            /// </summary>
            /// <value>Reason for refund</value>
            [DataMember(Name = "quantity", EmitDefaultValue = false)]
            [JsonProperty(PropertyName = "quantity")]
            public int Quantity { get; set; }

            /// <summary>
            ///Amount
            /// </summary>
            /// <value>Reason for refund</value>
            [DataMember(Name = "amount", EmitDefaultValue = false)]
            [JsonProperty(PropertyName = "amount")]
            public int? Amount { get; set; }
        }
    }
}
