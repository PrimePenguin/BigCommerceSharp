using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Adjuster for Complex Rules.
  /// </summary>
  [DataContract]
  public class AdjusterFull {
    /// <summary>
    /// The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront.
    /// </summary>
    /// <value>The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront. </value>
    [DataMember(Name="adjuster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adjuster")]
    public string Adjuster { get; set; }

    /// <summary>
    /// The numeric amount by which the adjuster will change either the price or the weight of the variant, when the modifier value is selected on the storefront.
    /// </summary>
    /// <value>The numeric amount by which the adjuster will change either the price or the weight of the variant, when the modifier value is selected on the storefront. </value>
    [DataMember(Name="adjuster_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adjuster_value")]
    public decimal? AdjusterValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdjusterFull {\n");
      sb.Append("  Adjuster: ").Append(Adjuster).Append("\n");
      sb.Append("  AdjusterValue: ").Append(AdjusterValue).Append("\n");
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
