using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A store credit model. 
  /// </summary>
  [DataContract]
  public class StoreCredit {
    /// <summary>
    /// Remaining balance of shopper's store credit. 
    /// </summary>
    /// <value>Remaining balance of shopper's store credit. </value>
    [DataMember(Name="remaining_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_balance")]
    public string RemainingBalance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoreCredit {\n");
      sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
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
