using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ShippingzonesFreeShipping {
    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>(Float, Float-As-String, Integer)</value>
    [DataMember(Name="minimum_sub_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_sub_total")]
    public string MinimumSubTotal { get; set; }

    /// <summary>
    /// Gets or Sets ExcludeFixedShippingProducts
    /// </summary>
    [DataMember(Name="exclude_fixed_shipping_products", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_fixed_shipping_products")]
    public bool? ExcludeFixedShippingProducts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingzonesFreeShipping {\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  MinimumSubTotal: ").Append(MinimumSubTotal).Append("\n");
      sb.Append("  ExcludeFixedShippingProducts: ").Append(ExcludeFixedShippingProducts).Append("\n");
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
