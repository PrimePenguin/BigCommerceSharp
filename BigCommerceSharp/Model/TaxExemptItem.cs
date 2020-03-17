using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Tax Exempt Item
  /// </summary>
  [DataContract]
  public class TaxExemptItem {
    /// <summary>
    /// Type of refund
    /// </summary>
    /// <value>Type of refund</value>
    [DataMember(Name="item_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_type")]
    public string ItemType { get; set; }

    /// <summary>
    /// A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers
    /// </summary>
    /// <value>A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// Reason for the refund.
    /// </summary>
    /// <value>Reason for the refund.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaxExemptItem {\n");
      sb.Append("  ItemType: ").Append(ItemType).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
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
