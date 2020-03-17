using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common Brand properties.
  /// </summary>
  [DataContract]
  public class BrandFull {
    /// <summary>
    /// Unique ID of the *Brand*. Read-Only.
    /// </summary>
    /// <value>Unique ID of the *Brand*. Read-Only.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the brand. Must be unique. Required in POST.
    /// </summary>
    /// <value>The name of the brand. Must be unique. Required in POST.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The title shown in the browser while viewing the brand. 
    /// </summary>
    /// <value>The title shown in the browser while viewing the brand. </value>
    [DataMember(Name="page_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page_title")]
    public string PageTitle { get; set; }

    /// <summary>
    /// Comma-separated list of meta keywords to include in the HTML. 
    /// </summary>
    /// <value>Comma-separated list of meta keywords to include in the HTML. </value>
    [DataMember(Name="meta_keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta_keywords")]
    public List<string> MetaKeywords { get; set; }

    /// <summary>
    /// A meta description to include. 
    /// </summary>
    /// <value>A meta description to include. </value>
    [DataMember(Name="meta_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta_description")]
    public string MetaDescription { get; set; }

    /// <summary>
    /// A comma-separated list of keywords that can be used to locate this brand. 
    /// </summary>
    /// <value>A comma-separated list of keywords that can be used to locate this brand. </value>
    [DataMember(Name="search_keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "search_keywords")]
    public string SearchKeywords { get; set; }

    /// <summary>
    /// Image URL used for this category on the storefront. Images can be uploaded via form file post to `/brands/{brandId}/image`, or by providing a publicly accessible URL in this field. 
    /// </summary>
    /// <value>Image URL used for this category on the storefront. Images can be uploaded via form file post to `/brands/{brandId}/image`, or by providing a publicly accessible URL in this field. </value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or Sets CustomUrl
    /// </summary>
    [DataMember(Name="custom_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_url")]
    public CustomUrlFull1 CustomUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BrandFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
      sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
      sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
      sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  CustomUrl: ").Append(CustomUrl).Append("\n");
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
