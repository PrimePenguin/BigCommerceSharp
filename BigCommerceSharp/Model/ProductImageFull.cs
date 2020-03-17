using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common ProductImage properties.
  /// </summary>
  [DataContract]
  public class ProductImageFull {
    /// <summary>
    /// The unique numeric ID of the image; increments sequentially. 
    /// </summary>
    /// <value>The unique numeric ID of the image; increments sequentially. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric identifier for the product with which the image is associated. 
    /// </summary>
    /// <value>The unique numeric identifier for the product with which the image is associated. </value>
    [DataMember(Name="product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_id")]
    public int? ProductId { get; set; }

    /// <summary>
    /// The zoom URL for this image. By default, this is used as the zoom image on product pages when zoom images are enabled. 
    /// </summary>
    /// <value>The zoom URL for this image. By default, this is used as the zoom image on product pages when zoom images are enabled. </value>
    [DataMember(Name="url_zoom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_zoom")]
    public string UrlZoom { get; set; }

    /// <summary>
    /// The standard URL for this image. By default, this is used for product-page images. 
    /// </summary>
    /// <value>The standard URL for this image. By default, this is used for product-page images. </value>
    [DataMember(Name="url_standard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_standard")]
    public string UrlStandard { get; set; }

    /// <summary>
    /// The thumbnail URL for this image. By default, this is the image size used on the category page and in side panels. 
    /// </summary>
    /// <value>The thumbnail URL for this image. By default, this is the image size used on the category page and in side panels. </value>
    [DataMember(Name="url_thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_thumbnail")]
    public string UrlThumbnail { get; set; }

    /// <summary>
    /// The tiny URL for this image. By default, this is the image size used for thumbnails beneath the product image on a product page. 
    /// </summary>
    /// <value>The tiny URL for this image. By default, this is the image size used for thumbnails beneath the product image on a product page. </value>
    [DataMember(Name="url_tiny", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_tiny")]
    public string UrlTiny { get; set; }

    /// <summary>
    /// The date on which the product image was modified. 
    /// </summary>
    /// <value>The date on which the product image was modified. </value>
    [DataMember(Name="date_modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_modified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductImageFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  UrlZoom: ").Append(UrlZoom).Append("\n");
      sb.Append("  UrlStandard: ").Append(UrlStandard).Append("\n");
      sb.Append("  UrlThumbnail: ").Append(UrlThumbnail).Append("\n");
      sb.Append("  UrlTiny: ").Append(UrlTiny).Append("\n");
      sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
