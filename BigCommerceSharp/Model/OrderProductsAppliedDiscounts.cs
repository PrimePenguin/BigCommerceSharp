using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// When applying a manual discount to an order (not a product level discount), the discount is distributed across products in proportion to the products price. &#x60;(total_manual_discount*price_ex_tax)/subtotal_ex_tax&#x60;
  /// </summary>
  [DataContract]
  public class OrderProductsAppliedDiscounts {
    /// <summary>
    /// Name of the coupon applied to order
    /// </summary>
    /// <value>Name of the coupon applied to order</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Amount of the discount.(Float, Float-As-String, Integer) 
    /// </summary>
    /// <value>Amount of the discount.(Float, Float-As-String, Integer) </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Name of the coupon. `Manual Discount` when creating a manual discount.
    /// </summary>
    /// <value>Name of the coupon. `Manual Discount` when creating a manual discount.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Coupon Code. There is no code when creating a manual discount.
    /// </summary>
    /// <value>Coupon Code. There is no code when creating a manual discount.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Determines if the discount if discount was applied at the Order or Product level. Read Only.
    /// </summary>
    /// <value>Determines if the discount if discount was applied at the Order or Product level. Read Only.</value>
    [DataMember(Name="target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target")]
    public string Target { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderProductsAppliedDiscounts {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Target: ").Append(Target).Append("\n");
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
