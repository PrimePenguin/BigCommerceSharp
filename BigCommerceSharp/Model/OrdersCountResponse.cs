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
  public class OrdersCountResponse {
    /// <summary>
    /// Gets or Sets Statuses
    /// </summary>
    [DataMember(Name="statuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses")]
    public Object Statuses { get; set; }

    /// <summary>
    /// Total number of orders in the store
    /// </summary>
    /// <value>Total number of orders in the store</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public decimal? Count { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrdersCountResponse {\n");
      sb.Append("  Statuses: ").Append(Statuses).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
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
