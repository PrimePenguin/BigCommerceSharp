using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Quantity Bound Item  Type of refund item that capture refunding of items in the order that are of type quantity.  * &#x60;PRODUCT&#x60; * &#x60;GIFT_WRAPPING&#x60; 
  /// </summary>
  [DataContract]
  public class QuantityBoundItem {
    /// <summary>
    /// Type of refund.
    /// </summary>
    /// <value>Type of refund.</value>
    [DataMember(Name="item_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_type")]
    public string ItemType { get; set; }

    /// <summary>
    /// Order Product ID. 
    /// </summary>
    /// <value>Order Product ID. </value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public int? ItemId { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Reason for refund
    /// </summary>
    /// <value>Reason for refund</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuantityBoundItem {\n");
      sb.Append("  ItemType: ").Append(ItemType).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
