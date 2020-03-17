using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The model for a POST to create variants on a product. 
  /// </summary>
  [DataContract]
  public class ProductVariantPost {
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
    /// Array of option and option values IDs that make up this variant. Will be empty if the variant is the product's base variant.
    /// </summary>
    /// <value>Array of option and option values IDs that make up this variant. Will be empty if the variant is the product's base variant.</value>
    [DataMember(Name="option_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_values")]
    public List<OptionValueVariantPost> OptionValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductVariantPost {\n");
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
