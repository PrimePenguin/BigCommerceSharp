using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// The model for a POST to create variants on a product. 
  /// </summary>
  [DataContract]
  public class ProductVariantPostProduct {
    /// <summary>
    /// Gets or Sets ProductId
    /// </summary>
    [DataMember(Name="product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_id")]
    public int? ProductId { get; set; }

    /// <summary>
    /// Gets or Sets Sku
    /// </summary>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or Sets OptionValues
    /// </summary>
    [DataMember(Name="option_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_values")]
    public List<Object> OptionValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductVariantPostProduct {\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  OptionValues: ").Append(OptionValues).Append("\n");
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
