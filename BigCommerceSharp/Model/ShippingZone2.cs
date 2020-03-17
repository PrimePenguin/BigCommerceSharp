using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ShippingZone2 {
    /// <summary>
    /// Zone Id. READ-ONLY
    /// </summary>
    /// <value>Zone Id. READ-ONLY</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Zone name. Required for /PUT
    /// </summary>
    /// <value>Zone name. Required for /PUT</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Array of zone locations.
    /// </summary>
    /// <value>Array of zone locations.</value>
    [DataMember(Name="locations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locations")]
    public List<ShippingZoneLocations> Locations { get; set; }

    /// <summary>
    /// Gets or Sets FreeShipping
    /// </summary>
    [DataMember(Name="free_shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "free_shipping")]
    public ShippingzonesFreeShipping FreeShipping { get; set; }

    /// <summary>
    /// Gets or Sets HandlingFees
    /// </summary>
    [DataMember(Name="handling_fees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_fees")]
    public ShippingZoneHandlingFees HandlingFees { get; set; }

    /// <summary>
    /// Whether this shipping zone is enabled.
    /// </summary>
    /// <value>Whether this shipping zone is enabled.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingZone2 {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Locations: ").Append(Locations).Append("\n");
      sb.Append("  FreeShipping: ").Append(FreeShipping).Append("\n");
      sb.Append("  HandlingFees: ").Append(HandlingFees).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
