using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DateFormat {
    /// <summary>
    /// string that defines dates’ display format, in the pattern: M jS Y
    /// </summary>
    /// <value>string that defines dates’ display format, in the pattern: M jS Y</value>
    [DataMember(Name="display", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display")]
    public string Display { get; set; }

    /// <summary>
    /// string that defines the CSV export format for orders, customers, and products, in the pattern: M jS Y
    /// </summary>
    /// <value>string that defines the CSV export format for orders, customers, and products, in the pattern: M jS Y</value>
    [DataMember(Name="export", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "export")]
    public string Export { get; set; }

    /// <summary>
    /// string that defines dates’ extended-display format, in the pattern: M jS Y @ g:i A.
    /// </summary>
    /// <value>string that defines dates’ extended-display format, in the pattern: M jS Y @ g:i A.</value>
    [DataMember(Name="extended_display", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extended_display")]
    public string ExtendedDisplay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DateFormat {\n");
      sb.Append("  Display: ").Append(Display).Append("\n");
      sb.Append("  Export: ").Append(Export).Append("\n");
      sb.Append("  ExtendedDisplay: ").Append(ExtendedDisplay).Append("\n");
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
