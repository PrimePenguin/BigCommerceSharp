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
  public class OrderProductsProductOptions {
    /// <summary>
    /// The unique numerical ID of the option; increments sequentially.
    /// </summary>
    /// <value>The unique numerical ID of the option; increments sequentially.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Numeric ID of the associated option.
    /// </summary>
    /// <value>Numeric ID of the associated option.</value>
    [DataMember(Name="option_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_id")]
    public int? OptionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="order_product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_product_id")]
    public int? OrderProductId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="product_option_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_option_id")]
    public int? ProductOptionId { get; set; }

    /// <summary>
    /// The name of the option, as shown on the storefront.
    /// </summary>
    /// <value>The name of the option, as shown on the storefront.</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The name of the value, as shown on the storefront.
    /// </summary>
    /// <value>The name of the value, as shown on the storefront.</value>
    [DataMember(Name="display_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_value")]
    public string DisplayValue { get; set; }

    /// <summary>
    /// This value is used to access the Customer File Upload
    /// </summary>
    /// <value>This value is used to access the Customer File Upload</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Option Type
    /// </summary>
    /// <value>Option Type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The option’s name, as used internally. Must be unique
    /// </summary>
    /// <value>The option’s name, as used internally. Must be unique</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// How it is displayed on the storefront. Examples include Drop-down, radio buttons, or rectangles.
    /// </summary>
    /// <value>How it is displayed on the storefront. Examples include Drop-down, radio buttons, or rectangles.</value>
    [DataMember(Name="display_style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_style")]
    public string DisplayStyle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderProductsProductOptions {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OptionId: ").Append(OptionId).Append("\n");
      sb.Append("  OrderProductId: ").Append(OrderProductId).Append("\n");
      sb.Append("  ProductOptionId: ").Append(ProductOptionId).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayStyle: ").Append(DisplayStyle).Append("\n");
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
