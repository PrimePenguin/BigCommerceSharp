using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// A product review model. 
  /// </summary>
  [DataContract]
  public class ProductReviewFull {
    /// <summary>
    /// The unique numeric ID of the product review; increments sequentially. 
    /// </summary>
    /// <value>The unique numeric ID of the product review; increments sequentially. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric identifier for the product with which the review is associated. 
    /// </summary>
    /// <value>The unique numeric identifier for the product with which the review is associated. </value>
    [DataMember(Name="product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_id")]
    public int? ProductId { get; set; }

    /// <summary>
    /// Date the product review was created. 
    /// </summary>
    /// <value>Date the product review was created. </value>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date the product review was modified. 
    /// </summary>
    /// <value>Date the product review was modified. </value>
    [DataMember(Name="date_modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_modified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductReviewFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
