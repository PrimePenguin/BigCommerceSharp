using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Used to reflect parent &lt;&gt; child category relationships. Used by Category Tree.
  /// </summary>
  [DataContract]
  public class CategoriesTreeNodeFull {
    /// <summary>
    /// The unique numeric ID of the category; increments sequentially. 
    /// </summary>
    /// <value>The unique numeric ID of the category; increments sequentially. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric ID of the category's parent. This field controls where the category sits in the tree of categories that organize the catalog. 
    /// </summary>
    /// <value>The unique numeric ID of the category's parent. This field controls where the category sits in the tree of categories that organize the catalog. </value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public int? ParentId { get; set; }

    /// <summary>
    /// The name displayed for the category. Name is unique with respect to the category's siblings. 
    /// </summary>
    /// <value>The name displayed for the category. Name is unique with respect to the category's siblings. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the category will be displayed. If `false`, the category will be hidden from view. 
    /// </summary>
    /// <value>Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the category will be displayed. If `false`, the category will be hidden from view. </value>
    [DataMember(Name="is_visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_visible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// The custom URL for the category on the storefront. 
    /// </summary>
    /// <value>The custom URL for the category on the storefront. </value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The list of children of the category. 
    /// </summary>
    /// <value>The list of children of the category. </value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<CategoriesTreeNodeFull> Children { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoriesTreeNodeFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
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
