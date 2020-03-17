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
  public class Body {
    /// <summary>
    /// Channel ID for requested token
    /// </summary>
    /// <value>Channel ID for requested token</value>
    [DataMember(Name="channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channel_id")]
    public int? ChannelId { get; set; }

    /// <summary>
    /// Unix timestamp (UTC time) defining when the token should expire.
    /// </summary>
    /// <value>Unix timestamp (UTC time) defining when the token should expire.</value>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public int? ExpiresAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Body {\n");
      sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
