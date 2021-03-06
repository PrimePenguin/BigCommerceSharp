using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Product Modifer &#x60;option_value&#x60;.
  /// </summary>
  [DataContract]
  public class ProductModifierOptionValueFull {
    /// <summary>
    /// The unique numeric ID of the value; increments sequentially. 
    /// </summary>
    /// <value>The unique numeric ID of the value; increments sequentially. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets OptionId
    /// </summary>
    [DataMember(Name="option_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_id")]
    public int? OptionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductModifierOptionValueFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OptionId: ").Append(OptionId).Append("\n");
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
