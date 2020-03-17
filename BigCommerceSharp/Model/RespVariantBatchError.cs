using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Errors during batch usage for the BigCommerce API. 
  /// </summary>
  [DataContract]
  public class RespVariantBatchError {
    /// <summary>
    /// Gets or Sets BatchErrors
    /// </summary>
    [DataMember(Name="batch_errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch_errors")]
    public List<object> BatchErrors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RespVariantBatchError {\n");
      sb.Append("  BatchErrors: ").Append(BatchErrors).Append("\n");
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
