using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OrderShippingAddress {
    /// <summary>
    /// ID of this shipping address.
    /// </summary>
    /// <value>ID of this shipping address.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// ID of the order.
    /// </summary>
    /// <value>ID of the order.</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// Addressee first name.
    /// </summary>
    /// <value>Addressee first name.</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Addressee last name.
    /// </summary>
    /// <value>Addressee last name.</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Addressee company.
    /// </summary>
    /// <value>Addressee company.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Street address (first line).
    /// </summary>
    /// <value>Street address (first line).</value>
    [DataMember(Name="street_1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street_1")]
    public string Street1 { get; set; }

    /// <summary>
    /// Street address (second line).
    /// </summary>
    /// <value>Street address (second line).</value>
    [DataMember(Name="street_2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street_2")]
    public string Street2 { get; set; }

    /// <summary>
    /// Addressee city.
    /// </summary>
    /// <value>Addressee city.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// ZIP or postal code, as a string.
    /// </summary>
    /// <value>ZIP or postal code, as a string.</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Addressee’s country.
    /// </summary>
    /// <value>Addressee’s country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// 2-letter ISO Alpha-2 code for the country. (Looking Up Country Codes)
    /// </summary>
    /// <value>2-letter ISO Alpha-2 code for the country. (Looking Up Country Codes)</value>
    [DataMember(Name="country_iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_iso2")]
    public string CountryIso2 { get; set; }

    /// <summary>
    /// The name of the state or province. Should be spelled out in full, e.g.: California.
    /// </summary>
    /// <value>The name of the state or province. Should be spelled out in full, e.g.: California.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Recipient’s email address.
    /// </summary>
    /// <value>Recipient’s email address.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Recipient’s telephone number
    /// </summary>
    /// <value>Recipient’s telephone number</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The total number of items in the order.
    /// </summary>
    /// <value>The total number of items in the order.</value>
    [DataMember(Name="items_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items_total")]
    public decimal? ItemsTotal { get; set; }

    /// <summary>
    /// The number of items that have been shipped.
    /// </summary>
    /// <value>The number of items that have been shipped.</value>
    [DataMember(Name="items_shipped", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items_shipped")]
    public decimal? ItemsShipped { get; set; }

    /// <summary>
    /// Text code identifying the BigCommerce shipping module selected by the customer.
    /// </summary>
    /// <value>Text code identifying the BigCommerce shipping module selected by the customer.</value>
    [DataMember(Name="shipping_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_method")]
    public string ShippingMethod { get; set; }

    /// <summary>
    /// The base value of the order’s items. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The base value of the order’s items. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="base_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_cost")]
    public string BaseCost { get; set; }

    /// <summary>
    /// The value of the order’s items, excluding tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the order’s items, excluding tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="cost_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_ex_tax")]
    public string CostExTax { get; set; }

    /// <summary>
    /// The value of the order’s items, including tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the order’s items, including tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="cost_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_inc_tax")]
    public string CostIncTax { get; set; }

    /// <summary>
    /// The tax amount on the order. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The tax amount on the order. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="cost_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_tax")]
    public string CostTax { get; set; }

    /// <summary>
    /// The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.)
    /// </summary>
    /// <value>The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.)</value>
    [DataMember(Name="cost_tax_class_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_tax_class_id")]
    public int? CostTaxClassId { get; set; }

    /// <summary>
    /// The base handling charge. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The base handling charge. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="base_handling_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_handling_cost")]
    public string BaseHandlingCost { get; set; }

    /// <summary>
    /// The handling charge, excluding tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The handling charge, excluding tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="handling_cost_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_cost_ex_tax")]
    public string HandlingCostExTax { get; set; }

    /// <summary>
    /// The handling charge, including tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The handling charge, including tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="handling_cost_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_cost_inc_tax")]
    public string HandlingCostIncTax { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="handling_cost_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_cost_tax")]
    public string HandlingCostTax { get; set; }

    /// <summary>
    /// A read-only value. Do not attempt to set or modify this value in a POST or PUT operation. (NOTE: Value ignored if automatic tax is enabled on the store.)
    /// </summary>
    /// <value>A read-only value. Do not attempt to set or modify this value in a POST or PUT operation. (NOTE: Value ignored if automatic tax is enabled on the store.)</value>
    [DataMember(Name="handling_cost_tax_class_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_cost_tax_class_id")]
    public int? HandlingCostTaxClassId { get; set; }

    /// <summary>
    /// Numeric ID of the shipping zone.
    /// </summary>
    /// <value>Numeric ID of the shipping zone.</value>
    [DataMember(Name="shipping_zone_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_zone_id")]
    public decimal? ShippingZoneId { get; set; }

    /// <summary>
    /// Name of the shipping zone.
    /// </summary>
    /// <value>Name of the shipping zone.</value>
    [DataMember(Name="shipping_zone_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_zone_name")]
    public string ShippingZoneName { get; set; }

    /// <summary>
    /// Empty array
    /// </summary>
    /// <value>Empty array</value>
    [DataMember(Name="form_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "form_fields")]
    public List<FormFields> FormFields { get; set; }

    /// <summary>
    /// Gets or Sets ShippingQuotes
    /// </summary>
    [DataMember(Name="shipping_quotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_quotes")]
    public ShippingQuotesResource ShippingQuotes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderShippingAddress {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Street1: ").Append(Street1).Append("\n");
      sb.Append("  Street2: ").Append(Street2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  CountryIso2: ").Append(CountryIso2).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  ItemsTotal: ").Append(ItemsTotal).Append("\n");
      sb.Append("  ItemsShipped: ").Append(ItemsShipped).Append("\n");
      sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
      sb.Append("  BaseCost: ").Append(BaseCost).Append("\n");
      sb.Append("  CostExTax: ").Append(CostExTax).Append("\n");
      sb.Append("  CostIncTax: ").Append(CostIncTax).Append("\n");
      sb.Append("  CostTax: ").Append(CostTax).Append("\n");
      sb.Append("  CostTaxClassId: ").Append(CostTaxClassId).Append("\n");
      sb.Append("  BaseHandlingCost: ").Append(BaseHandlingCost).Append("\n");
      sb.Append("  HandlingCostExTax: ").Append(HandlingCostExTax).Append("\n");
      sb.Append("  HandlingCostIncTax: ").Append(HandlingCostIncTax).Append("\n");
      sb.Append("  HandlingCostTax: ").Append(HandlingCostTax).Append("\n");
      sb.Append("  HandlingCostTaxClassId: ").Append(HandlingCostTaxClassId).Append("\n");
      sb.Append("  ShippingZoneId: ").Append(ShippingZoneId).Append("\n");
      sb.Append("  ShippingZoneName: ").Append(ShippingZoneName).Append("\n");
      sb.Append("  FormFields: ").Append(FormFields).Append("\n");
      sb.Append("  ShippingQuotes: ").Append(ShippingQuotes).Append("\n");
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
