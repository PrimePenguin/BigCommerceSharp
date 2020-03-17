using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// |Type &#x60;int&#x60;|Name| |-|-| |&#x60;0&#x60;|&#x60;per_item_discount&#x60;| |&#x60;1&#x60;|&#x60;percentage_discount&#x60;| |&#x60;2&#x60;|&#x60;per_total_discount&#x60;| |&#x60;3&#x60;|&#x60;shipping_discount&#x60;| |&#x60;4&#x60;|&#x60;free_shipping&#x60;| |&#x60;5&#x60;|&#x60;promotion&#x60;|
  /// </summary>
  [DataContract]
  public class OrderCoupons {
    /// <summary>
    /// Numeric ID of the coupon code.
    /// </summary>
    /// <value>Numeric ID of the coupon code.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Numeric ID of the associated coupon.
    /// </summary>
    /// <value>Numeric ID of the associated coupon.</value>
    [DataMember(Name="coupon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coupon_id")]
    public int? CouponId { get; set; }

    /// <summary>
    /// Numeric ID of the associated order.
    /// </summary>
    /// <value>Numeric ID of the associated order.</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// Coupon code, as a string.
    /// </summary>
    /// <value>Coupon code, as a string.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Amount of the discount. This information is returned as in integer. Dollar and percentage discounts will return the same. For example, $3 returns as '3' while 5% will return as 5. Check the discount type to see what type of discount is available. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>Amount of the discount. This information is returned as in integer. Dollar and percentage discounts will return the same. For example, $3 returns as '3' while 5% will return as 5. Check the discount type to see what type of discount is available. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// type 0: per_item_discount type 1: percentage_discount type 2: per_total_discount type 3: shipping_discount type 4: free_shipping type 5: promotions
    /// </summary>
    /// <value>type 0: per_item_discount type 1: percentage_discount type 2: per_total_discount type 3: shipping_discount type 4: free_shipping type 5: promotions</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// The amount off the order the discount is worth. For example, if an order subtotal is $90 and the discount is $3 then it will return as 3.000. If the discount is 3% then will return as 2.7000 or the amount of the order.  (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The amount off the order the discount is worth. For example, if an order subtotal is $90 and the discount is $3 then it will return as 3.000. If the discount is 3% then will return as 2.7000 or the amount of the order.  (Float, Float-As-String, Integer)</value>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public decimal? Discount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderCoupons {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CouponId: ").Append(CouponId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
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
