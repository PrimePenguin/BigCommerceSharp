using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Refund1 {
    /// <summary>
    /// Refund resource ID
    /// </summary>
    /// <value>Refund resource ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Reference to order id
    /// </summary>
    /// <value>Reference to order id</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// Reference to the user's id who create this refund. This is automatically populated by BigCommerce.
    /// </summary>
    /// <value>Reference to the user's id who create this refund. This is automatically populated by BigCommerce.</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// Timestamp of when this refund was created
    /// </summary>
    /// <value>Timestamp of when this refund was created</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Reason for refund
    /// </summary>
    /// <value>Reason for refund</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers
    /// </summary>
    /// <value>A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers</value>
    [DataMember(Name="total_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_amount")]
    public float? TotalAmount { get; set; }

    /// <summary>
    /// Total tax amount refunded back to shopper. Note: order_level_amount does not affect tax liability. This can be negative amount indicating we have collected tax by virtue of refunding less to the customer
    /// </summary>
    /// <value>Total tax amount refunded back to shopper. Note: order_level_amount does not affect tax liability. This can be negative amount indicating we have collected tax by virtue of refunding less to the customer</value>
    [DataMember(Name="total_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_tax")]
    public decimal? TotalTax { get; set; }

    /// <summary>
    /// Array of items refunded
    /// </summary>
    /// <value>Array of items refunded</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<RefundItem> Items { get; set; }

    /// <summary>
    /// An array of refund payments made to payment providers
    /// </summary>
    /// <value>An array of refund payments made to payment providers</value>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public List<RefundPayment> Payments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Refund1 {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
      sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
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
