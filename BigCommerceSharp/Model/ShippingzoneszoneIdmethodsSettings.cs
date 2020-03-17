using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Depends on the shipping-method type. See the [supported settings object](#supported-settings).
  /// </summary>
  [DataContract]
  public class ShippingzoneszoneIdmethodsSettings {
    /// <summary>
    /// Flat rate per order. 
    /// </summary>
    /// <value>Flat rate per order. </value>
    [DataMember(Name="rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate")]
    public decimal? Rate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingzoneszoneIdmethodsSettings {\n");
      sb.Append("  Rate: ").Append(Rate).Append("\n");
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
