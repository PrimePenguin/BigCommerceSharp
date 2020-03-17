using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Common Bulk Pricing Rule properties
  /// </summary>
  [DataContract]
  public class BulkPricingRuleFull {
    /// <summary>
    /// Unique ID of the *Bulk Pricing Rule*. Read-Only.
    /// </summary>
    /// <value>Unique ID of the *Bulk Pricing Rule*. Read-Only.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero. Required in /POST. 
    /// </summary>
    /// <value>The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero. Required in /POST. </value>
    [DataMember(Name="quantity_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity_min")]
    public int? QuantityMin { get; set; }

    /// <summary>
    /// The maximum inclusive quantity of a product to satisfy this rule. Must be greater than the `quantity_min` value – unless this field has a value of 0 (zero), in which case there will be no maximum bound for this rule. Required in /POST.
    /// </summary>
    /// <value>The maximum inclusive quantity of a product to satisfy this rule. Must be greater than the `quantity_min` value – unless this field has a value of 0 (zero), in which case there will be no maximum bound for this rule. Required in /POST.</value>
    [DataMember(Name="quantity_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity_max")]
    public int? QuantityMax { get; set; }

    /// <summary>
    /// The type of adjustment that is made. Values: `price` - the adjustment amount per product; `percent` - the adjustment as a percentage of the original price; `fixed` - the adjusted absolute price of the product. Required in /POST.
    /// </summary>
    /// <value>The type of adjustment that is made. Values: `price` - the adjustment amount per product; `percent` - the adjustment as a percentage of the original price; `fixed` - the adjusted absolute price of the product. Required in /POST.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer and the response will return as an integer. For percentage enter the amount as the percentage divided by 100 using string format. For example 10% percent would be “.10”. The response will return as an integer.  Required in /POST.
    /// </summary>
    /// <value>The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer and the response will return as an integer. For percentage enter the amount as the percentage divided by 100 using string format. For example 10% percent would be “.10”. The response will return as an integer.  Required in /POST.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BulkPricingRuleFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  QuantityMin: ").Append(QuantityMin).Append("\n");
      sb.Append("  QuantityMax: ").Append(QuantityMax).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
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
