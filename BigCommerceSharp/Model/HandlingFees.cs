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
  public class HandlingFees {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="fixed_surcharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed_surcharge")]
    public string FixedSurcharge { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="percentage_surcharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentage_surcharge")]
    public string PercentageSurcharge { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="display_separately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_separately")]
    public bool? DisplaySeparately { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HandlingFees {\n");
      sb.Append("  FixedSurcharge: ").Append(FixedSurcharge).Append("\n");
      sb.Append("  PercentageSurcharge: ").Append(PercentageSurcharge).Append("\n");
      sb.Append("  DisplaySeparately: ").Append(DisplaySeparately).Append("\n");
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
