using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Custom payment from manual order.
  /// </summary>
  [DataContract]
  public class Custom1 {
    /// <summary>
    /// Text entered for the payment method in the control panel. 
    /// </summary>
    /// <value>Text entered for the payment method in the control panel. </value>
    [DataMember(Name="payment_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method")]
    public string PaymentMethod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Custom1 {\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
