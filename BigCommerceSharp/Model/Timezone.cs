using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Timezone {
    /// <summary>
    /// a string identifying the time zone, in the format: <Continent-name>/<City-name>.
    /// </summary>
    /// <value>a string identifying the time zone, in the format: <Continent-name>/<City-name>.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// a negative or positive number, identifying the offset from UTC/GMT, in seconds, during winter/standard time.
    /// </summary>
    /// <value>a negative or positive number, identifying the offset from UTC/GMT, in seconds, during winter/standard time.</value>
    [DataMember(Name="raw_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raw_offset")]
    public int? RawOffset { get; set; }

    /// <summary>
    /// \"-/+\" offset from UTC/GMT, in seconds, during summer/daylight saving time.
    /// </summary>
    /// <value>\"-/+\" offset from UTC/GMT, in seconds, during summer/daylight saving time.</value>
    [DataMember(Name="dst_offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dst_offset")]
    public int? DstOffset { get; set; }

    /// <summary>
    /// a boolean indicating whether this time zone observes daylight saving time.
    /// </summary>
    /// <value>a boolean indicating whether this time zone observes daylight saving time.</value>
    [DataMember(Name="dst_correction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dst_correction")]
    public bool? DstCorrection { get; set; }

    /// <summary>
    /// Gets or Sets DateFormat
    /// </summary>
    [DataMember(Name="date_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_format")]
    public DateFormat DateFormat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Timezone {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RawOffset: ").Append(RawOffset).Append("\n");
      sb.Append("  DstOffset: ").Append(DstOffset).Append("\n");
      sb.Append("  DstCorrection: ").Append(DstCorrection).Append("\n");
      sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
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
