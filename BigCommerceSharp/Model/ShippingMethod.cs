using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | |  |  |  | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;     {     \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,     \&quot;type\&quot;: \&quot;perorder\&quot;,     \&quot;settings\&quot;: {       \&quot;rate\&quot;: 7     }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | |  |  |  | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;     {     \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,     \&quot;type\&quot;: \&quot;peritem\&quot;,     \&quot;settings\&quot;: {       \&quot;rate\&quot;: 8     }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | |  |  |  | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60; { \&quot;name\&quot;: \&quot;Rate per Weight\&quot;, \&quot;type\&quot;: \&quot;weight\&quot;, \&quot;settings\&quot;: {      \&quot;default_cost\&quot;: 12,      \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,      \&quot;range\&quot;: [        {          \&quot;lower_limit\&quot;: 0,          \&quot;upper_limit\&quot;: 20,          \&quot;shipping_cost\&quot;: 8        },        {          \&quot;lower_limit\&quot;: 20,          \&quot;upper_limit\&quot;: 40,          \&quot;shipping_cost\&quot;: 12        }      ]    } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | |  |  |  | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60; { \&quot;name\&quot;: \&quot;Per Total or Free\&quot;, \&quot;type\&quot;: \&quot;total\&quot;, \&quot;settings\&quot;: {      \&quot;default_cost\&quot;: 12,      \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,      \&quot;include_order_total_taxes\&quot;: 0,      \&quot;range\&quot;: [        {          \&quot;lower_limit\&quot;: 0,          \&quot;upper_limit\&quot;: 5,          \&quot;shipping_cost\&quot;: 5        },        {          \&quot;lower_limit\&quot;: 5,          \&quot;upper_limit\&quot;: 10,          \&quot;shipping_cost\&quot;: 8        },        {          \&quot;lower_limit\&quot;: 10,          \&quot;upper_limit\&quot;: 20,          \&quot;shipping_cost\&quot;: 10        },        {          \&quot;lower_limit\&quot;: 20,          \&quot;upper_limit\&quot;: 49.99,          \&quot;shipping_cost\&quot;: 15        },        {          \&quot;lower_limit\&quot;: 50,          \&quot;upper_limit\&quot;: 100000,          \&quot;shipping_cost\&quot;: 0        }             ]    } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | |  |  |  | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;        {          \&quot;lower_limit\&quot;: 0,          \&quot;upper_limit\&quot;: 20,          \&quot;shipping_cost\&quot;: 8        } &#x60;&#x60;&#x60;
  /// </summary>
  [DataContract]
  public class ShippingMethod {
    /// <summary>
    /// Shipping-method ID. READ-ONLY
    /// </summary>
    /// <value>Shipping-method ID. READ-ONLY</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Display name for shipping method.
    /// </summary>
    /// <value>Display name for shipping method.</value>
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
    /// Depends on the shipping-method type. See the [supported settings object](https://developer.bigcommerce.com/api-reference/store-management/shipping-api/shipping-method/getashippingmethod).
    /// </summary>
    /// <value>Depends on the shipping-method type. See the [supported settings object](https://developer.bigcommerce.com/api-reference/store-management/shipping-api/shipping-method/getashippingmethod).</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public Object Settings { get; set; }

    /// <summary>
    /// Whether or not this shipping-zone method is enabled.
    /// </summary>
    /// <value>Whether or not this shipping-zone method is enabled.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// `fixed_surcharge`: flat-rate handling fee applied to shipping cost.  `percentage_surcharge`: percentage handling fee applied to shipping cost
    /// </summary>
    /// <value>`fixed_surcharge`: flat-rate handling fee applied to shipping cost.  `percentage_surcharge`: percentage handling fee applied to shipping cost</value>
    [DataMember(Name="handling_fees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_fees")]
    public Object HandlingFees { get; set; }

    /// <summary>
    /// Whether or not this shipping zone is the fallback if all others are not valid for the order.
    /// </summary>
    /// <value>Whether or not this shipping zone is the fallback if all others are not valid for the order.</value>
    [DataMember(Name="is_fallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_fallback")]
    public bool? IsFallback { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingMethod {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  HandlingFees: ").Append(HandlingFees).Append("\n");
      sb.Append("  IsFallback: ").Append(IsFallback).Append("\n");
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
