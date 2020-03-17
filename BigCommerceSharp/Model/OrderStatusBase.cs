using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OrderStatusBase {
    /// <summary>
    /// The id of the type of order status
    /// </summary>
    /// <value>The id of the type of order status</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the type of order status
    /// </summary>
    /// <value>Name of the type of order status</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// System name of the type of order status.
    /// </summary>
    /// <value>System name of the type of order status.</value>
    [DataMember(Name="system_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_label")]
    public string SystemLabel { get; set; }

    /// <summary>
    /// Custom order status label given in the Control Panel
    /// </summary>
    /// <value>Custom order status label given in the Control Panel</value>
    [DataMember(Name="custom_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_label")]
    public string CustomLabel { get; set; }

    /// <summary>
    /// System description of the order status
    /// </summary>
    /// <value>System description of the order status</value>
    [DataMember(Name="system_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_description")]
    public string SystemDescription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderStatusBase {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SystemLabel: ").Append(SystemLabel).Append("\n");
      sb.Append("  CustomLabel: ").Append(CustomLabel).Append("\n");
      sb.Append("  SystemDescription: ").Append(SystemDescription).Append("\n");
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
