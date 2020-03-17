using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AdjustersFull {
    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public AdjusterFull1 Price { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public AdjusterFull1 Weight { get; set; }

    /// <summary>
    /// The URL for an image displayed on the storefront when the modifier value is selected.Limit of 8MB per file.  
    /// </summary>
    /// <value>The URL for an image displayed on the storefront when the modifier value is selected.Limit of 8MB per file.  </value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or Sets PurchasingDisabled
    /// </summary>
    [DataMember(Name="purchasing_disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasing_disabled")]
    public AdjustersFull1PurchasingDisabled PurchasingDisabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdjustersFull {\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  PurchasingDisabled: ").Append(PurchasingDisabled).Append("\n");
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
