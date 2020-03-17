using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common ProductImage properties.
  /// </summary>
  [DataContract]
  public class ProductImageBase {
    /// <summary>
    /// The local path to the original image file uploaded to BigCommerce. 
    /// </summary>
    /// <value>The local path to the original image file uploaded to BigCommerce. </value>
    [DataMember(Name="image_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_file")]
    public string ImageFile { get; set; }

    /// <summary>
    /// Flag for identifying whether the image is used as the product's thumbnail. 
    /// </summary>
    /// <value>Flag for identifying whether the image is used as the product's thumbnail. </value>
    [DataMember(Name="is_thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_thumbnail")]
    public bool? IsThumbnail { get; set; }

    /// <summary>
    /// The order in which the image will be displayed on the product page. Higher integers give the image a lower priority. When updating, if the image is given a lower priority, all images with a `sort_order` the same as or greater than the image's new `sort_order` value will have their `sort_order`s reordered. 
    /// </summary>
    /// <value>The order in which the image will be displayed on the product page. Higher integers give the image a lower priority. When updating, if the image is given a lower priority, all images with a `sort_order` the same as or greater than the image's new `sort_order` value will have their `sort_order`s reordered. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// The description for the image. 
    /// </summary>
    /// <value>The description for the image. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Must be a fully qualified URL path, including protocol. Limit of 8MB per file.
    /// </summary>
    /// <value>Must be a fully qualified URL path, including protocol. Limit of 8MB per file.</value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductImageBase {\n");
      sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
      sb.Append("  IsThumbnail: ").Append(IsThumbnail).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
