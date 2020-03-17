using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common ComplexRule properties.
  /// </summary>
  [DataContract]
  public class ComplexRuleBase {
    /// <summary>
    /// The unique numeric ID of the rule; increments sequentially. Read-Only
    /// </summary>
    /// <value>The unique numeric ID of the rule; increments sequentially. Read-Only</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric ID of the product with which the rule is associated; increments sequentially. 
    /// </summary>
    /// <value>The unique numeric ID of the product with which the rule is associated; increments sequentially. </value>
    [DataMember(Name="product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_id")]
    public int? ProductId { get; set; }

    /// <summary>
    /// The priority to give this rule when making adjustments to the product properties. 
    /// </summary>
    /// <value>The priority to give this rule when making adjustments to the product properties. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Flag for determining whether the rule is to be used when adjusting a product's price, weight, image, or availabilty. 
    /// </summary>
    /// <value>Flag for determining whether the rule is to be used when adjusting a product's price, weight, image, or availabilty. </value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Flag for determining whether other rules should not be applied after this rule has been applied. 
    /// </summary>
    /// <value>Flag for determining whether other rules should not be applied after this rule has been applied. </value>
    [DataMember(Name="stop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stop")]
    public bool? Stop { get; set; }

    /// <summary>
    /// Flag for determining whether the rule should disable purchasing of a product when the conditions are applied. 
    /// </summary>
    /// <value>Flag for determining whether the rule should disable purchasing of a product when the conditions are applied. </value>
    [DataMember(Name="purchasing_disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasing_disabled")]
    public bool? PurchasingDisabled { get; set; }

    /// <summary>
    /// Message displayed on the storefront when a rule disables the purchasing of a product. 
    /// </summary>
    /// <value>Message displayed on the storefront when a rule disables the purchasing of a product. </value>
    [DataMember(Name="purchasing_disabled_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasing_disabled_message")]
    public string PurchasingDisabledMessage { get; set; }

    /// <summary>
    /// Flag for determining whether the rule should hide purchasing of a product when the conditions are applied. 
    /// </summary>
    /// <value>Flag for determining whether the rule should hide purchasing of a product when the conditions are applied. </value>
    [DataMember(Name="purchasing_hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasing_hidden")]
    public bool? PurchasingHidden { get; set; }

    /// <summary>
    /// The URL for an image displayed on the storefront when the conditions are applied. Limit of 8MB per file.  
    /// </summary>
    /// <value>The URL for an image displayed on the storefront when the conditions are applied. Limit of 8MB per file.  </value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or Sets PriceAdjuster
    /// </summary>
    [DataMember(Name="price_adjuster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_adjuster")]
    public AdjusterFull1 PriceAdjuster { get; set; }

    /// <summary>
    /// Gets or Sets WeightAdjuster
    /// </summary>
    [DataMember(Name="weight_adjuster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight_adjuster")]
    public AdjusterFull1 WeightAdjuster { get; set; }

    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<ComplexRuleConditionBase1> Conditions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComplexRuleBase {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Stop: ").Append(Stop).Append("\n");
      sb.Append("  PurchasingDisabled: ").Append(PurchasingDisabled).Append("\n");
      sb.Append("  PurchasingDisabledMessage: ").Append(PurchasingDisabledMessage).Append("\n");
      sb.Append("  PurchasingHidden: ").Append(PurchasingHidden).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  PriceAdjuster: ").Append(PriceAdjuster).Append("\n");
      sb.Append("  WeightAdjuster: ").Append(WeightAdjuster).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
