using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A credit-card model.
  /// </summary>
  [DataContract]
  public class CreditCard {
    /// <summary>
    /// The credit-card type: Visa, MasterCard, etc. 
    /// </summary>
    /// <value>The credit-card type: Visa, MasterCard, etc. </value>
    [DataMember(Name="card_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_type")]
    public string CardType { get; set; }

    /// <summary>
    /// The IIN of a credit-card number. 
    /// </summary>
    /// <value>The IIN of a credit-card number. </value>
    [DataMember(Name="card_iin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_iin")]
    public string CardIin { get; set; }

    /// <summary>
    /// The last 4 digits of a credit-card number. 
    /// </summary>
    /// <value>The last 4 digits of a credit-card number. </value>
    [DataMember(Name="card_last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_last4")]
    public string CardLast4 { get; set; }

    /// <summary>
    /// The expiry month of a credit-card. 
    /// </summary>
    /// <value>The expiry month of a credit-card. </value>
    [DataMember(Name="card_expiry_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_expiry_month")]
    public int? CardExpiryMonth { get; set; }

    /// <summary>
    /// The expiry year of a credit-card. 
    /// </summary>
    /// <value>The expiry year of a credit-card. </value>
    [DataMember(Name="card_expiry_year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_expiry_year")]
    public int? CardExpiryYear { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditCard {\n");
      sb.Append("  CardType: ").Append(CardType).Append("\n");
      sb.Append("  CardIin: ").Append(CardIin).Append("\n");
      sb.Append("  CardLast4: ").Append(CardLast4).Append("\n");
      sb.Append("  CardExpiryMonth: ").Append(CardExpiryMonth).Append("\n");
      sb.Append("  CardExpiryYear: ").Append(CardExpiryYear).Append("\n");
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
