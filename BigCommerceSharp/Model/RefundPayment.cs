using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RefundPayment {
    /// <summary>
    /// Reference to refund payment id
    /// </summary>
    /// <value>Reference to refund payment id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Reference to payment provider
    /// </summary>
    /// <value>Reference to payment provider</value>
    [DataMember(Name="provider_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider_id")]
    public string ProviderId { get; set; }

    /// <summary>
    /// A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers
    /// </summary>
    /// <value>A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// Indicate whether payment was offline
    /// </summary>
    /// <value>Indicate whether payment was offline</value>
    [DataMember(Name="offline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offline")]
    public bool? Offline { get; set; }

    /// <summary>
    /// Indicate if this payment has been declined by payment provider
    /// </summary>
    /// <value>Indicate if this payment has been declined by payment provider</value>
    [DataMember(Name="is_declined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_declined")]
    public bool? IsDeclined { get; set; }

    /// <summary>
    /// Message indicate why payment was declined
    /// </summary>
    /// <value>Message indicate why payment was declined</value>
    [DataMember(Name="declined_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declined_message")]
    public string DeclinedMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RefundPayment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Offline: ").Append(Offline).Append("\n");
      sb.Append("  IsDeclined: ").Append(IsDeclined).Append("\n");
      sb.Append("  DeclinedMessage: ").Append(DeclinedMessage).Append("\n");
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
