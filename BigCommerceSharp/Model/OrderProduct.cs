using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// &#x60;product_options&#x60; are required if adding a product with variants.
  /// </summary>
  [DataContract]
  public class OrderProduct {
    /// <summary>
    /// Gets or Sets ProductId
    /// </summary>
    [DataMember(Name="product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_id")]
    public int? ProductId { get; set; }

    /// <summary>
    /// Gets or Sets ProductOptions
    /// </summary>
    [DataMember(Name="product_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_options")]
    public List<OrderProductProductOptions> ProductOptions { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets PriceIncTax
    /// </summary>
    [DataMember(Name="price_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_inc_tax")]
    public decimal? PriceIncTax { get; set; }

    /// <summary>
    /// Gets or Sets PriceExTax
    /// </summary>
    [DataMember(Name="price_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_ex_tax")]
    public decimal? PriceExTax { get; set; }

    /// <summary>
    /// Gets or Sets Upc
    /// </summary>
    [DataMember(Name="upc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upc")]
    public string Upc { get; set; }

    /// <summary>
    /// Products `variant_id`. PUT or POST. This field is not available for custom products.
    /// </summary>
    /// <value>Products `variant_id`. PUT or POST. This field is not available for custom products.</value>
    [DataMember(Name="variant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_id")]
    public int? VariantId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderProduct {\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  ProductOptions: ").Append(ProductOptions).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  PriceIncTax: ").Append(PriceIncTax).Append("\n");
      sb.Append("  PriceExTax: ").Append(PriceExTax).Append("\n");
      sb.Append("  Upc: ").Append(Upc).Append("\n");
      sb.Append("  VariantId: ").Append(VariantId).Append("\n");
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
