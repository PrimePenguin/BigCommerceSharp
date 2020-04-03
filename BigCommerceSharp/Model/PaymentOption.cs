using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PaymentOption
    {
        /// <summary>
        /// Name of the payment method
        /// </summary>
        /// <value>Name of the payment method</value>
        [DataMember(Name = "provider_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "provider_id")]
        public string ProviderId { get; set; }

        /// <summary>
        /// Description for payment provider
        /// </summary>
        /// <value>Description for payment provider</value>
        [DataMember(Name = "provider_description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "provider_description")]
        public string ProviderDescription { get; set; }

        /// <summary>
        /// amount to be refunded via this payment provider
        /// </summary>
        /// <value>amount to be refunded via this payment provider</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Indicates the payment must be done offline due to constraints of the payment provider, such as partial refunds not being supported, or it being offline only such as cash on delivery of bank deposit.
        /// </summary>
        /// <value>Indicates the payment must be done offline due to constraints of the payment provider, such as partial refunds not being supported, or it being offline only such as cash on delivery of bank deposit.</value>
        [DataMember(Name = "offline", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offline")]
        public bool? Offline { get; set; }

        /// <summary>
        /// Indicates if the payment provider is a strictly offline provider, such as cash on delivery or bank deposit.
        /// </summary>
        /// <value>Indicates if the payment provider is a strictly offline provider, such as cash on delivery or bank deposit.</value>
        [DataMember(Name = "offline_provider", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offline_provider")]
        public bool? OfflineProvider { get; set; }

        /// <summary>
        /// Reason the payment option is offline only, if applicable.
        /// </summary>
        /// <value>Reason the payment option is offline only, if applicable.</value>
        [DataMember(Name = "offline_reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offline_reason")]
        public string OfflineReason { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentOption {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderDescription: ").Append(ProviderDescription).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Offline: ").Append(Offline).Append("\n");
            sb.Append("  OfflineProvider: ").Append(OfflineProvider).Append("\n");
            sb.Append("  OfflineReason: ").Append(OfflineReason).Append("\n");
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
