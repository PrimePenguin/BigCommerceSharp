using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// + &#x60;stencil_enabled&#x60;: &#x60;true&#x60; (boolean)     + &#x60;sitewidehttps_enabled&#x60;: &#x60;false&#x60; (boolean)     + &#x60;facebook_catalog_id&#x60; (string)
  /// </summary>
  [DataContract]
  public class StoreInformationFeatures {
    /// <summary>
    /// Indicates whether a store is using a Stencil theme.
    /// </summary>
    /// <value>Indicates whether a store is using a Stencil theme.</value>
    [DataMember(Name="stencil_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stencil_enabled")]
    public bool? StencilEnabled { get; set; }

    /// <summary>
    /// Indicates if there is sitewide https.
    /// </summary>
    /// <value>Indicates if there is sitewide https.</value>
    [DataMember(Name="sitewidehttps_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sitewidehttps_enabled")]
    public string SitewidehttpsEnabled { get; set; }

    /// <summary>
    /// Id of the facebook catalog. If there is none, it returns an empty string. 
    /// </summary>
    /// <value>Id of the facebook catalog. If there is none, it returns an empty string. </value>
    [DataMember(Name="facebook_catalog_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facebook_catalog_id")]
    public string FacebookCatalogId { get; set; }

    /// <summary>
    /// What type of checkout is enabled on the store. Possible values returned are optimized, single (one page), single_customizable (one page for developers), klarna.
    /// </summary>
    /// <value>What type of checkout is enabled on the store. Possible values returned are optimized, single (one page), single_customizable (one page for developers), klarna.</value>
    [DataMember(Name="checkout_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkout_type")]
    public string CheckoutType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoreInformationFeatures {\n");
      sb.Append("  StencilEnabled: ").Append(StencilEnabled).Append("\n");
      sb.Append("  SitewidehttpsEnabled: ").Append(SitewidehttpsEnabled).Append("\n");
      sb.Append("  FacebookCatalogId: ").Append(FacebookCatalogId).Append("\n");
      sb.Append("  CheckoutType: ").Append(CheckoutType).Append("\n");
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
