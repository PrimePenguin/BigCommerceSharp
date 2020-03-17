using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The model for a POST to create option values on a product.
  /// </summary>
  [DataContract]
  public class ProductOptionValuePostProduct {
    /// <summary>
    /// The name of the option. 
    /// </summary>
    /// <value>The name of the option. </value>
    [DataMember(Name="option_display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_display_name")]
    public string OptionDisplayName { get; set; }

    /// <summary>
    /// The label of the option value. 
    /// </summary>
    /// <value>The label of the option value. </value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductOptionValuePostProduct {\n");
      sb.Append("  OptionDisplayName: ").Append(OptionDisplayName).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
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
