using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// The custom URL for the category on the storefront.
  /// </summary>
  [DataContract]
  public class CustomUrlFull {
    /// <summary>
    /// Category URL on the storefront. 
    /// </summary>
    /// <value>Category URL on the storefront. </value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Returns `true` if the URL has been changed from its default state (the auto-assigned URL that BigCommerce provides). 
    /// </summary>
    /// <value>Returns `true` if the URL has been changed from its default state (the auto-assigned URL that BigCommerce provides). </value>
    [DataMember(Name="is_customized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_customized")]
    public bool? IsCustomized { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomUrlFull {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  IsCustomized: ").Append(IsCustomized).Append("\n");
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
