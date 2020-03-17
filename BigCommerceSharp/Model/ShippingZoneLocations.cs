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
  public class ShippingZoneLocations {
    /// <summary>
    /// Location’s ID.
    /// </summary>
    /// <value>Location’s ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Location’s ZIP/postal code.
    /// </summary>
    /// <value>Location’s ZIP/postal code.</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// 2-letter ISO Alpha-2 code for the country.
    /// </summary>
    /// <value>2-letter ISO Alpha-2 code for the country.</value>
    [DataMember(Name="country_iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_iso2")]
    public string CountryIso2 { get; set; }

    /// <summary>
    /// ISO Alpha-2 code for the state.
    /// </summary>
    /// <value>ISO Alpha-2 code for the state.</value>
    [DataMember(Name="state_iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_iso2")]
    public string StateIso2 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingZoneLocations {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  CountryIso2: ").Append(CountryIso2).Append("\n");
      sb.Append("  StateIso2: ").Append(StateIso2).Append("\n");
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
