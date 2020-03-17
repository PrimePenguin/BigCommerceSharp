using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Response payload for the BigCommerce Order Transactions API single transaction. 
  /// </summary>
  [DataContract]
  public class TransactionResponse {
    /// <summary>
    /// A BigCommerce Transaction object describes a single transaction.
    /// </summary>
    /// <value>A BigCommerce Transaction object describes a single transaction.</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public object Data { get; set; }

    /// <summary>
    /// May be used in the future
    /// </summary>
    /// <value>May be used in the future</value>
    [DataMember(Name="meta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta")]
    public object Meta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionResponse {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Meta: ").Append(Meta).Append("\n");
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
