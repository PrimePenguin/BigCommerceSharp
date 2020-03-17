using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An object containing a publicly accessible image URL, or a form post that contains an image file.
  /// </summary>
  [DataContract]
  public class ResourceImage1 {
    /// <summary>
    /// A public URL for a GIF, JPEG, or PNG image. Limit of 8MB per file.  
    /// </summary>
    /// <value>A public URL for a GIF, JPEG, or PNG image. Limit of 8MB per file.  </value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceImage1 {\n");
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
