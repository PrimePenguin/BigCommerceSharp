using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ProductFull {
    /// <summary>
    /// The date on which the product was created. 
    /// </summary>
    /// <value>The date on which the product was created. </value>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date on which the product was modified. 
    /// </summary>
    /// <value>The date on which the product was modified. </value>
    [DataMember(Name="date_modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_modified")]
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// ID of the product. Read Only.
    /// </summary>
    /// <value>ID of the product. Read Only.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique identifier of the base variant associated with a simple product. This value is `null` for complex products.
    /// </summary>
    /// <value>The unique identifier of the base variant associated with a simple product. This value is `null` for complex products.</value>
    [DataMember(Name="base_variant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_variant_id")]
    public int? BaseVariantId { get; set; }

    /// <summary>
    /// The price of the product as seen on the storefront. It will be equal to the `sale_price`, if set, and the `price` if there is not a `sale_price`.
    /// </summary>
    /// <value>The price of the product as seen on the storefront. It will be equal to the `sale_price`, if set, and the `price` if there is not a `sale_price`.</value>
    [DataMember(Name="calculated_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "calculated_price")]
    public float? CalculatedPrice { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public List<ProductOptionBase1> Options { get; set; }

    /// <summary>
    /// Gets or Sets Modifiers
    /// </summary>
    [DataMember(Name="modifiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiers")]
    public List<object> Modifiers { get; set; }

    /// <summary>
    /// Minimum Advertised Price.
    /// </summary>
    /// <value>Minimum Advertised Price.</value>
    [DataMember(Name="map_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "map_price")]
    public decimal? MapPrice { get; set; }

    /// <summary>
    /// Indicates that the product is in an Option Set (legacy V2 concept).
    /// </summary>
    /// <value>Indicates that the product is in an Option Set (legacy V2 concept).</value>
    [DataMember(Name="option_set_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_set_id")]
    public int? OptionSetId { get; set; }

    /// <summary>
    /// Legacy template setting which controls if the option set shows up to the side of or below the product image and description.
    /// </summary>
    /// <value>Legacy template setting which controls if the option set shows up to the side of or below the product image and description.</value>
    [DataMember(Name="option_set_display", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_set_display")]
    public string OptionSetDisplay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductFull {\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  DateModified: ").Append(DateModified).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  BaseVariantId: ").Append(BaseVariantId).Append("\n");
      sb.Append("  CalculatedPrice: ").Append(CalculatedPrice).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
      sb.Append("  MapPrice: ").Append(MapPrice).Append("\n");
      sb.Append("  OptionSetId: ").Append(OptionSetId).Append("\n");
      sb.Append("  OptionSetDisplay: ").Append(OptionSetDisplay).Append("\n");
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
