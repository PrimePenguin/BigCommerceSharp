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
  public class ShippingQuotesResource {
    /// <summary>
    /// This URL will return a 204 for shipping quotes. To return shipping quotes: `/shipping_addresses/shipping_address_id/shipping_quotes`
    /// </summary>
    /// <value>This URL will return a 204 for shipping quotes. To return shipping quotes: `/shipping_addresses/shipping_address_id/shipping_quotes`</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// This URL will return a 204 for shipping quotes. To return shipping quotes: `/shipping_addresses/shipping_address_id/shipping_quotes`
    /// </summary>
    /// <value>This URL will return a 204 for shipping quotes. To return shipping quotes: `/shipping_addresses/shipping_address_id/shipping_quotes`</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingQuotesResource {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
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
