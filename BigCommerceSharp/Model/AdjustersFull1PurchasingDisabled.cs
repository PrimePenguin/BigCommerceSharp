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
  public class AdjustersFull1PurchasingDisabled {
    /// <summary>
    /// Flag for whether the modifier value disables purchasing when selected on the storefront. This can be used for temporarily disabling a particular modifier value. 
    /// </summary>
    /// <value>Flag for whether the modifier value disables purchasing when selected on the storefront. This can be used for temporarily disabling a particular modifier value. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public bool? Status { get; set; }

    /// <summary>
    /// The message displayed on the storefront when the purchasing disabled status is `true`. 
    /// </summary>
    /// <value>The message displayed on the storefront when the purchasing disabled status is `true`. </value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdjustersFull1PurchasingDisabled {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
