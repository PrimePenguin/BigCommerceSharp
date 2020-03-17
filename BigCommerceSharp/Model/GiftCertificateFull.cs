using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A gift-certificate model.
  /// </summary>
  [DataContract]
  public class GiftCertificateFull {
    /// <summary>
    /// The gift-certificate code. 
    /// </summary>
    /// <value>The gift-certificate code. </value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The balance on a gift certificate when it was purchased. 
    /// </summary>
    /// <value>The balance on a gift certificate when it was purchased. </value>
    [DataMember(Name="original_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_balance")]
    public float? OriginalBalance { get; set; }

    /// <summary>
    /// The balance on a gift certificate at the time of this purchase. 
    /// </summary>
    /// <value>The balance on a gift certificate at the time of this purchase. </value>
    [DataMember(Name="starting_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starting_balance")]
    public float? StartingBalance { get; set; }

    /// <summary>
    /// The remaining balance on a gift certificate. 
    /// </summary>
    /// <value>The remaining balance on a gift certificate. </value>
    [DataMember(Name="remaining_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_balance")]
    public float? RemainingBalance { get; set; }

    /// <summary>
    /// The status of a gift certificate: `active` - gift certificate is active; `pending` - gift certificate purchase is pending; `disabled` - gift certificate is disabled; `expired` - gift certificate is expired. 
    /// </summary>
    /// <value>The status of a gift certificate: `active` - gift certificate is active; `pending` - gift certificate purchase is pending; `disabled` - gift certificate is disabled; `expired` - gift certificate is expired. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GiftCertificateFull {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  OriginalBalance: ").Append(OriginalBalance).Append("\n");
      sb.Append("  StartingBalance: ").Append(StartingBalance).Append("\n");
      sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
