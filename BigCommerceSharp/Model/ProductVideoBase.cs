using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// The model for a POST to create a video on a product. 
  /// </summary>
  [DataContract]
  public class ProductVideoBase {
    /// <summary>
    /// The title for the video. If left blank, this will be filled in according to data on a host site. 
    /// </summary>
    /// <value>The title for the video. If left blank, this will be filled in according to data on a host site. </value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The description for the video. If left blank, this will be filled in according to data on a host site. 
    /// </summary>
    /// <value>The description for the video. If left blank, this will be filled in according to data on a host site. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The order in which the video will be displayed on the product page. Higher integers give the video a lower priority. When updating, if the video is given a lower priority, all videos with a `sort_order` the same as or greater than the video's new `sort_order` value will have their `sort_order`s reordered. 
    /// </summary>
    /// <value>The order in which the video will be displayed on the product page. Higher integers give the video a lower priority. When updating, if the video is given a lower priority, all videos with a `sort_order` the same as or greater than the video's new `sort_order` value will have their `sort_order`s reordered. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// The video type (a short name of a host site). 
    /// </summary>
    /// <value>The video type (a short name of a host site). </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The ID of the video on a host site.
    /// </summary>
    /// <value>The ID of the video on a host site.</value>
    [DataMember(Name="video_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "video_id")]
    public string VideoId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductVideoBase {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  VideoId: ").Append(VideoId).Append("\n");
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
