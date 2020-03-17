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
  public class WebhookBase {
    /// <summary>
    /// Event you subscribe to
    /// </summary>
    /// <value>Event you subscribe to</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// URL must be active and return a 200 response
    /// </summary>
    /// <value>URL must be active and return a 200 response</value>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// If webhook is active or not
    /// </summary>
    /// <value>If webhook is active or not</value>
    [DataMember(Name="is_active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public HooksHeaders1 Headers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhookBase {\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
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
