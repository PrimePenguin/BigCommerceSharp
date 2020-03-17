using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// The model for a POST to create a product review. 
  /// </summary>
  [DataContract]
  public class ProductReviewPost {
    /// <summary>
    /// The title for the product review. Required in /POST.
    /// </summary>
    /// <value>The title for the product review. Required in /POST.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The text for the product review. 
    /// </summary>
    /// <value>The text for the product review. </value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// The status of the product review. Must be one of `approved`, `disapproved` or `pending`. 
    /// </summary>
    /// <value>The status of the product review. Must be one of `approved`, `disapproved` or `pending`. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The rating of the product review. Must be one of 0, 1, 2, 3, 4, 5.
    /// </summary>
    /// <value>The rating of the product review. Must be one of 0, 1, 2, 3, 4, 5.</value>
    [DataMember(Name="rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rating")]
    public int? Rating { get; set; }

    /// <summary>
    /// The email of the reviewer. Must be a valid email, or an empty string.
    /// </summary>
    /// <value>The email of the reviewer. Must be a valid email, or an empty string.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The name of the reviewer.
    /// </summary>
    /// <value>The name of the reviewer.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Date the product was reviewed. Required in /POST. 
    /// </summary>
    /// <value>Date the product was reviewed. Required in /POST. </value>
    [DataMember(Name="date_reviewed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_reviewed")]
    public DateTime? DateReviewed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductReviewPost {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Rating: ").Append(Rating).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DateReviewed: ").Append(DateReviewed).Append("\n");
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
