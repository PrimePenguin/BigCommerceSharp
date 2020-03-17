using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Pagination links for the previous and next parts of the whole collection. 
  /// </summary>
  [DataContract]
  public class Pagination1Links {
    /// <summary>
    /// Link to the previous page returned in the response. 
    /// </summary>
    /// <value>Link to the previous page returned in the response. </value>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public string Previous { get; set; }

    /// <summary>
    /// Link to the current page returned in the response. 
    /// </summary>
    /// <value>Link to the current page returned in the response. </value>
    [DataMember(Name="current", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current")]
    public string Current { get; set; }

    /// <summary>
    /// Link to the next page returned in the response. 
    /// </summary>
    /// <value>Link to the next page returned in the response. </value>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public string Next { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pagination1Links {\n");
      sb.Append("  Previous: ").Append(Previous).Append("\n");
      sb.Append("  Current: ").Append(Current).Append("\n");
      sb.Append("  Next: ").Append(Next).Append("\n");
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
