using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Gets custom fields associated with a product. These allow you to specify additional information that will appear on the product&#39;s page, such as a book&#39;s ISBN or a DVD&#39;s release date.
  /// </summary>
  [DataContract]
  public class ProductCustomFieldBase {
    /// <summary>
    /// The unique numeric ID of the custom field; increments sequentially. Read-Only
    /// </summary>
    /// <value>The unique numeric ID of the custom field; increments sequentially. Read-Only</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the field, shown on the storefront, orders, etc. Required for /POST 
    /// </summary>
    /// <value>The name of the field, shown on the storefront, orders, etc. Required for /POST </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The name of the field, shown on the storefront, orders, etc. Required for /POST 
    /// </summary>
    /// <value>The name of the field, shown on the storefront, orders, etc. Required for /POST </value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductCustomFieldBase {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
