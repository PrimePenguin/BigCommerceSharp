using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// You can pass in any number of custom headers to validate webhooks being returned. 
  /// </summary>
  [DataContract]
  public class HooksHeaders1 {
    /// <summary>
    /// Gets or Sets Custom
    /// </summary>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom")]
    public string Custom { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HooksHeaders1 {\n");
      sb.Append("  Custom: ").Append(Custom).Append("\n");
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
