using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaginationFull1 {
    /// <summary>
    /// Total number of items in the result set.
    /// </summary>
    /// <value>Total number of items in the result set.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Total number of items in the collection response.
    /// </summary>
    /// <value>Total number of items in the collection response.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The amount of items returned in the collection per page, controlled by the limit parameter.
    /// </summary>
    /// <value>The amount of items returned in the collection per page, controlled by the limit parameter.</value>
    [DataMember(Name="per_page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "per_page")]
    public int? PerPage { get; set; }

    /// <summary>
    /// The page you are currently on within the collection.
    /// </summary>
    /// <value>The page you are currently on within the collection.</value>
    [DataMember(Name="current_page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_page")]
    public int? CurrentPage { get; set; }

    /// <summary>
    /// The total number of pages in the collection.
    /// </summary>
    /// <value>The total number of pages in the collection.</value>
    [DataMember(Name="total_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_pages")]
    public int? TotalPages { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public LinksFull1 Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaginationFull1 {\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  PerPage: ").Append(PerPage).Append("\n");
      sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
      sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
