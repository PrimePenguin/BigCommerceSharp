using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RefundItem {
    /// <summary>
    /// Type of item that was refunded
    /// </summary>
    /// <value>Type of item that was refunded</value>
    [DataMember(Name="item_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_type")]
    public string ItemType { get; set; }

    /// <summary>
    /// Reference to the item
    /// </summary>
    /// <value>Reference to the item</value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public int? ItemId { get; set; }

    /// <summary>
    /// Reason for refunding an item
    /// </summary>
    /// <value>Reason for refunding an item</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Quantity of item refunded. Note: this will only be populated for item_type PRODUCT
    /// </summary>
    /// <value>Quantity of item refunded. Note: this will only be populated for item_type PRODUCT</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers
    /// </summary>
    /// <value>A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers</value>
    [DataMember(Name="requested_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_amount")]
    public float? RequestedAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RefundItem {\n");
      sb.Append("  ItemType: ").Append(ItemType).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RequestedAmount: ").Append(RequestedAmount).Append("\n");
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
