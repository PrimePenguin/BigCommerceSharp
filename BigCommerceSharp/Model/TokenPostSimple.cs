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
  public class TokenPostSimple {
    /// <summary>
    /// List of allowed domains for Cross-Origin Request Sharing. Currently only accepts a single element.
    /// </summary>
    /// <value>List of allowed domains for Cross-Origin Request Sharing. Currently only accepts a single element.</value>
    [DataMember(Name="allowed_cors_origins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_cors_origins")]
    public List<string> AllowedCorsOrigins { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenPostSimple {\n");
      sb.Append("  AllowedCorsOrigins: ").Append(AllowedCorsOrigins).Append("\n");
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
