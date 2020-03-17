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
  public class OrderCustomProduct {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets PriceExTax
    /// </summary>
    [DataMember(Name="price_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_ex_tax")]
    public decimal? PriceExTax { get; set; }

    /// <summary>
    /// Gets or Sets PriceIncTax
    /// </summary>
    [DataMember(Name="price_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_inc_tax")]
    public decimal? PriceIncTax { get; set; }

    /// <summary>
    /// Gets or Sets Sku
    /// </summary>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or Sets Upc
    /// </summary>
    [DataMember(Name="upc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upc")]
    public string Upc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderCustomProduct {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  PriceExTax: ").Append(PriceExTax).Append("\n");
      sb.Append("  PriceIncTax: ").Append(PriceIncTax).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Upc: ").Append(Upc).Append("\n");
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
