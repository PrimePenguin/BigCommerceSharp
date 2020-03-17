using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OrderTaxes {
    /// <summary>
    /// The unique numeric identifier of the taxes object.
    /// </summary>
    /// <value>The unique numeric identifier of the taxes object.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric identifier of the order to which the tax was applied. NOTE: Not included if the store was using the automatic tax feature.
    /// </summary>
    /// <value>The unique numeric identifier of the order to which the tax was applied. NOTE: Not included if the store was using the automatic tax feature.</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// The unique numeric identifier of the order address object associated with the order. NOTE: Not included if the store was using the automatic tax feature.
    /// </summary>
    /// <value>The unique numeric identifier of the order address object associated with the order. NOTE: Not included if the store was using the automatic tax feature.</value>
    [DataMember(Name="order_address_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_address_id")]
    public int? OrderAddressId { get; set; }

    /// <summary>
    /// The unique numeric identifier of the tax rate.
    /// </summary>
    /// <value>The unique numeric identifier of the tax rate.</value>
    [DataMember(Name="tax_rate_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_rate_id")]
    public int? TaxRateId { get; set; }

    /// <summary>
    /// The unique numeric identifier of the tax class object. NOTE: Will be 0 if automatic tax was enabled, or if the default tax class was used.
    /// </summary>
    /// <value>The unique numeric identifier of the tax class object. NOTE: Will be 0 if automatic tax was enabled, or if the default tax class was used.</value>
    [DataMember(Name="tax_class_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_class_id")]
    public int? TaxClassId { get; set; }

    /// <summary>
    /// The name of the tax class object.
    /// </summary>
    /// <value>The name of the tax class object.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The name of the type of tax that was applied. NOTE: will be “Automatic Tax” if automatic tax was enabled.
    /// </summary>
    /// <value>The name of the type of tax that was applied. NOTE: will be “Automatic Tax” if automatic tax was enabled.</value>
    [DataMember(Name="class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "class")]
    public string Class { get; set; }

    /// <summary>
    /// The tax rate.  The priority order in which the tax is applied (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The tax rate.  The priority order in which the tax is applied (Float, Float-As-String, Integer)</value>
    [DataMember(Name="rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate")]
    public string Rate { get; set; }

    /// <summary>
    /// The order in which the tax is applied
    /// </summary>
    /// <value>The order in which the tax is applied</value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public decimal? Priority { get; set; }

    /// <summary>
    /// The amount of tax calculated on the order.   (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The amount of tax calculated on the order.   (Float, Float-As-String, Integer)</value>
    [DataMember(Name="priority_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority_amount")]
    public string PriorityAmount { get; set; }

    /// <summary>
    /// (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>(Float, Float-As-String, Integer)</value>
    [DataMember(Name="line_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line_amount")]
    public string LineAmount { get; set; }

    /// <summary>
    /// If the `line_item_type` is `item` or `handling` then this field will be the order product id. Otherwise the field will return as null.
    /// </summary>
    /// <value>If the `line_item_type` is `item` or `handling` then this field will be the order product id. Otherwise the field will return as null.</value>
    [DataMember(Name="order_product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_product_id")]
    public string OrderProductId { get; set; }

    /// <summary>
    /// Type of tax on item
    /// </summary>
    /// <value>Type of tax on item</value>
    [DataMember(Name="line_item_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line_item_type")]
    public string LineItemType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderTaxes {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  OrderAddressId: ").Append(OrderAddressId).Append("\n");
      sb.Append("  TaxRateId: ").Append(TaxRateId).Append("\n");
      sb.Append("  TaxClassId: ").Append(TaxClassId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Class: ").Append(Class).Append("\n");
      sb.Append("  Rate: ").Append(Rate).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  PriorityAmount: ").Append(PriorityAmount).Append("\n");
      sb.Append("  LineAmount: ").Append(LineAmount).Append("\n");
      sb.Append("  OrderProductId: ").Append(OrderProductId).Append("\n");
      sb.Append("  LineItemType: ").Append(LineItemType).Append("\n");
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
