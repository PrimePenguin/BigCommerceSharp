using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ProductVariantFull {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// Read-only reference to v2 API's SKU ID. Null if it is a base variant.
    /// </summary>
    /// <value>Read-only reference to v2 API's SKU ID. Null if it is a base variant.</value>
    [DataMember(Name="sku_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku_id")]
    public int? SkuId { get; set; }

    /// <summary>
    /// Array of option and option values IDs that make up this variant. Will be empty if the variant is the product's base variant.
    /// </summary>
    /// <value>Array of option and option values IDs that make up this variant. Will be empty if the variant is the product's base variant.</value>
    [DataMember(Name="option_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_values")]
    public List<ProductVariantOptionValueBase1> OptionValues { get; set; }

    /// <summary>
    /// The price of the variant as seen on the storefront. This price takes into account `sale_price` and any price adjustment rules that are applicable to this variant. 
    /// </summary>
    /// <value>The price of the variant as seen on the storefront. This price takes into account `sale_price` and any price adjustment rules that are applicable to this variant. </value>
    [DataMember(Name="calculated_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "calculated_price")]
    public double? CalculatedPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductVariantFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  SkuId: ").Append(SkuId).Append("\n");
      sb.Append("  OptionValues: ").Append(OptionValues).Append("\n");
      sb.Append("  CalculatedPrice: ").Append(CalculatedPrice).Append("\n");
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
