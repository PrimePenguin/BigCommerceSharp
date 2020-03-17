using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentRequest {
    /// <summary>
    /// Reference to payment provider
    /// </summary>
    /// <value>Reference to payment provider</value>
    [DataMember(Name="provider_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider_id")]
    public string ProviderId { get; set; }

    /// <summary>
    /// Amount refunded via this provider
    /// </summary>
    /// <value>Amount refunded via this provider</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Whether the payment was marked as offline or performed through an online payment service.
    /// </summary>
    /// <value>Whether the payment was marked as offline or performed through an online payment service.</value>
    [DataMember(Name="offline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offline")]
    public bool? Offline { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentRequest {\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Offline: ").Append(Offline).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
