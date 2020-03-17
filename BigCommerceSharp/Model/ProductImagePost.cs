using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The model for a POST to create an image on a product.
  /// </summary>
  [DataContract]
  public class ProductImagePost {
    /// <summary>
    /// Must be a fully qualified URL path, including protocol. Limit of 8MB per file.  
    /// </summary>
    /// <value>Must be a fully qualified URL path, including protocol. Limit of 8MB per file.  </value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Must be sent as a multipart/form-data field in the request body. 
    /// </summary>
    /// <value>Must be sent as a multipart/form-data field in the request body. </value>
    [DataMember(Name="image_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_file")]
    public string ImageFile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductImagePost {\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
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
