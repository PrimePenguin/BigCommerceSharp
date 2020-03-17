using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common Product Option &#x60;option_value&#x60; properties.
  /// </summary>
  [DataContract]
  public class ProductOptionOptionValueBase {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductOptionOptionValueBase {\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
