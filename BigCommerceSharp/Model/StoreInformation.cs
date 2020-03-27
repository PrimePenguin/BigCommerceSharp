using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  ///
  /// </summary>
  [DataContract]
  public class StoreInformation {
    /// <summary>
    /// Unique store identifier.
    /// </summary>
    /// <value>Unique store identifier.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Primary domain name.
    /// </summary>
    /// <value>Primary domain name.</value>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Store’s current HTTPS URL.
    /// </summary>
    /// <value>Store’s current HTTPS URL.</value>
    [DataMember(Name="secure_URL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secure_URL")]
    public string SecureURL { get; set; }

    /// <summary>
    /// Store's name.
    /// </summary>
    /// <value>Store's name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Primary contact’s first name (as defined during the store sign-up process).
    /// </summary>
    /// <value>Primary contact’s first name (as defined during the store sign-up process).</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Primary contact’s last name (as defined during the store sign-up process).
    /// </summary>
    /// <value>Primary contact’s last name (as defined during the store sign-up process).</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Display address.
    /// </summary>
    /// <value>Display address.</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Country where the store is located (as defined during the store sign-up process).
    /// </summary>
    /// <value>Country where the store is located (as defined during the store sign-up process).</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Display phone number.
    /// </summary>
    /// <value>Display phone number.</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Email address of the store administrator/owner.
    /// </summary>
    /// <value>Email address of the store administrator/owner.</value>
    [DataMember(Name="admin_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "admin_email")]
    public string AdminEmail { get; set; }

    /// <summary>
    /// Email address for orders and fulfillment.
    /// </summary>
    /// <value>Email address for orders and fulfillment.</value>
    [DataMember(Name="order_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_email")]
    public string OrderEmail { get; set; }

    /// <summary>
    /// Default language code.
    /// </summary>
    /// <value>Default language code.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Default currency code
    /// </summary>
    /// <value>Default currency code</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Default symbol for values in the currency.
    /// </summary>
    /// <value>Default symbol for values in the currency.</value>
    [DataMember(Name="currency_symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_symbol")]
    public string CurrencySymbol { get; set; }

    /// <summary>
    /// Default decimal separator for values in the currency.
    /// </summary>
    /// <value>Default decimal separator for values in the currency.</value>
    [DataMember(Name="decimal_separator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decimal_separator")]
    public string DecimalSeparator { get; set; }

    /// <summary>
    /// Default thousands separator for values in the currency.
    /// </summary>
    /// <value>Default thousands separator for values in the currency.</value>
    [DataMember(Name="thousands_separator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thousands_separator")]
    public string ThousandsSeparator { get; set; }

    /// <summary>
    /// Default decimal places for values in the currency.
    /// </summary>
    /// <value>Default decimal places for values in the currency.</value>
    [DataMember(Name="decimal_places", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decimal_places")]
    public int? DecimalPlaces { get; set; }

    /// <summary>
    /// Default position of the currency symbol (left or right).
    /// </summary>
    /// <value>Default position of the currency symbol (left or right).</value>
    [DataMember(Name="currency_symbol_location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_symbol_location")]
    public string CurrencySymbolLocation { get; set; }

    /// <summary>
    /// Default weight units (metric or imperial).
    /// </summary>
    /// <value>Default weight units (metric or imperial).</value>
    [DataMember(Name="weight_units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight_units")]
    public string WeightUnits { get; set; }

    /// <summary>
    /// Default dimension units (metric or imperial).
    /// </summary>
    /// <value>Default dimension units (metric or imperial).</value>
    [DataMember(Name="dimension_units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimension_units")]
    public string DimensionUnits { get; set; }

    /// <summary>
    /// The number of decimal places.
    /// </summary>
    /// <value>The number of decimal places.</value>
    [DataMember(Name="dimension_decimal_places", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimension_decimal_places")]
    public int? DimensionDecimalPlaces { get; set; }

    /// <summary>
    /// The symbol that separates the whole numbers from the decimal points.
    /// </summary>
    /// <value>The symbol that separates the whole numbers from the decimal points.</value>
    [DataMember(Name="dimension_decimal_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimension_decimal_token")]
    public string DimensionDecimalToken { get; set; }

    /// <summary>
    /// The symbol used to denote thousands.
    /// </summary>
    /// <value>The symbol used to denote thousands.</value>
    [DataMember(Name="dimension_thousands_token:", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimension_thousands_token:")]
    public string DimensionThousandsToken { get; set; }

    /// <summary>
    /// Name of the BigCommerce plan to which this store is subscribed.
    /// </summary>
    /// <value>Name of the BigCommerce plan to which this store is subscribed.</value>
    [DataMember(Name="plan_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan_name")]
    public string PlanName { get; set; }

    /// <summary>
    /// Level of the BigCommerce plan to which this store is subscribed.
    /// </summary>
    /// <value>Level of the BigCommerce plan to which this store is subscribed.</value>
    [DataMember(Name="plan_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan_level")]
    public string PlanLevel { get; set; }

    /// <summary>
    /// Industry, or vertical category, in which the business operates. (As selected from drop-down list during the store sign-up process.)
    /// </summary>
    /// <value>Industry, or vertical category, in which the business operates. (As selected from drop-down list during the store sign-up process.)</value>
    [DataMember(Name="industry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "industry")]
    public string Industry { get; set; }

    /// <summary>
    /// A Boolean value that indicates whether or not prices are entered with tax.
    /// </summary>
    /// <value>A Boolean value that indicates whether or not prices are entered with tax.</value>
    [DataMember(Name="is_price_entered_with_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_price_entered_with_tax")]
    public bool? IsPriceEnteredWithTax { get; set; }

    /// <summary>
    /// Gets or Sets Features
    /// </summary>
    [DataMember(Name="features", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "features")]
    public StoreInformationFeatures Features { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoreInformation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  SecureURL: ").Append(SecureURL).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  AdminEmail: ").Append(AdminEmail).Append("\n");
      sb.Append("  OrderEmail: ").Append(OrderEmail).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
      sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
      sb.Append("  ThousandsSeparator: ").Append(ThousandsSeparator).Append("\n");
      sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
      sb.Append("  CurrencySymbolLocation: ").Append(CurrencySymbolLocation).Append("\n");
      sb.Append("  WeightUnits: ").Append(WeightUnits).Append("\n");
      sb.Append("  DimensionUnits: ").Append(DimensionUnits).Append("\n");
      sb.Append("  DimensionDecimalPlaces: ").Append(DimensionDecimalPlaces).Append("\n");
      sb.Append("  DimensionDecimalToken: ").Append(DimensionDecimalToken).Append("\n");
      sb.Append("  DimensionThousandsToken: ").Append(DimensionThousandsToken).Append("\n");
      sb.Append("  PlanName: ").Append(PlanName).Append("\n");
      sb.Append("  PlanLevel: ").Append(PlanLevel).Append("\n");
      sb.Append("  Industry: ").Append(Industry).Append("\n");
      sb.Append("  IsPriceEnteredWithTax: ").Append(IsPriceEnteredWithTax).Append("\n");
      sb.Append("  Features: ").Append(Features).Append("\n");
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
