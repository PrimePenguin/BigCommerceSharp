using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// The model for a POST to create option values on a product.
  /// </summary>
  [DataContract]
  public class ProductOptionValuePost {
    /// <summary>
    /// The flag for preselecting a value as the default on the storefront. This field is not supported for swatch options/modifiers. 
    /// </summary>
    /// <value>The flag for preselecting a value as the default on the storefront. This field is not supported for swatch options/modifiers. </value>
    [DataMember(Name="is_default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_default")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// The text display identifying the value on the storefront. Required in a /POST. 
    /// </summary>
    /// <value>The text display identifying the value on the storefront. Required in a /POST. </value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// The order in which the value will be displayed on the product page. Required in a /POST. 
    /// </summary>
    /// <value>The order in which the value will be displayed on the product page. Required in a /POST. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Extra data describing the value, based on the type of option or modifier with which the value is associated. The `swatch` type option can accept an array of `colors`, with up to three hexidecimal color keys; or an `image_url`, which is a full image URL path including protocol. The `product list` type option requires a `product_id`. The `checkbox` type option requires a boolean flag, called `checked_value`, to determine which value is considered to be the checked state. 
    /// </summary>
    /// <value>Extra data describing the value, based on the type of option or modifier with which the value is associated. The `swatch` type option can accept an array of `colors`, with up to three hexidecimal color keys; or an `image_url`, which is a full image URL path including protocol. The `product list` type option requires a `product_id`. The `checkbox` type option requires a boolean flag, called `checked_value`, to determine which value is considered to be the checked state. </value>
    [DataMember(Name="value_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_data")]
    public object ValueData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductOptionValuePost {\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  ValueData: ").Append(ValueData).Append("\n");
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
