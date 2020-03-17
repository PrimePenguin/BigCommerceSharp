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
  public class ShippingQuotes {
    /// <summary>
    /// Id of the shipping quote
    /// </summary>
    /// <value>Id of the shipping quote</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// uuid of the shipping quote
    /// </summary>
    /// <value>uuid of the shipping quote</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// Time the order was created in RFC 2822 format.
    /// </summary>
    /// <value>Time the order was created in RFC 2822 format.</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Id of the shipping provider
    /// </summary>
    /// <value>Id of the shipping provider</value>
    [DataMember(Name="shipping_provider_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_provider_id")]
    public string ShippingProviderId { get; set; }

    /// <summary>
    /// This can vary based on the shipping provider. Manual shipping methods such as fixed will return an empty array. Shipping providers such as UPS will return an object with the shipping information. Since the shipping quote is tied to a shipping address only one quote will return in the response.
    /// </summary>
    /// <value>This can vary based on the shipping provider. Manual shipping methods such as fixed will return an empty array. Shipping providers such as UPS will return an object with the shipping information. Since the shipping quote is tied to a shipping address only one quote will return in the response.</value>
    [DataMember(Name="shipping_provider_quote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_provider_quote")]
    public List<Object> ShippingProviderQuote { get; set; }

    /// <summary>
    /// Code of the shipping provider
    /// </summary>
    /// <value>Code of the shipping provider</value>
    [DataMember(Name="provider_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider_code")]
    public string ProviderCode { get; set; }

    /// <summary>
    /// Code of the shipping carrier
    /// </summary>
    /// <value>Code of the shipping carrier</value>
    [DataMember(Name="carrier_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// Type of delivery. This can vary based on shipping quote.
    /// </summary>
    /// <value>Type of delivery. This can vary based on shipping quote.</value>
    [DataMember(Name="rate_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate_code")]
    public string RateCode { get; set; }

    /// <summary>
    /// This can vary based on shipping quote
    /// </summary>
    /// <value>This can vary based on shipping quote</value>
    [DataMember(Name="rate_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate_id")]
    public string RateId { get; set; }

    /// <summary>
    /// Shipping method ID
    /// </summary>
    /// <value>Shipping method ID</value>
    [DataMember(Name="method_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method_id")]
    public int? MethodId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingQuotes {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  ShippingProviderId: ").Append(ShippingProviderId).Append("\n");
      sb.Append("  ShippingProviderQuote: ").Append(ShippingProviderQuote).Append("\n");
      sb.Append("  ProviderCode: ").Append(ProviderCode).Append("\n");
      sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
      sb.Append("  RateCode: ").Append(RateCode).Append("\n");
      sb.Append("  RateId: ").Append(RateId).Append("\n");
      sb.Append("  MethodId: ").Append(MethodId).Append("\n");
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
