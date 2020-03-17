using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Address Verification Service (AVS) result from the payment gateway.
  /// </summary>
  [DataContract]
  public class AVSResults {
    /// <summary>
    /// AVS code.
    /// </summary>
    /// <value>AVS code.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// AVS message.
    /// </summary>
    /// <value>AVS message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// AVS Code for street matching result.
    /// </summary>
    /// <value>AVS Code for street matching result.</value>
    [DataMember(Name="street_match", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street_match")]
    public string StreetMatch { get; set; }

    /// <summary>
    /// AVS Code for postal matching result.
    /// </summary>
    /// <value>AVS Code for postal matching result.</value>
    [DataMember(Name="postal_match", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_match")]
    public string PostalMatch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AVSResults {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  StreetMatch: ").Append(StreetMatch).Append("\n");
      sb.Append("  PostalMatch: ").Append(PostalMatch).Append("\n");
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
