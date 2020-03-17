using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Common Category object properties.
  /// </summary>
  [DataContract]
  public class CategoryFull {
    /// <summary>
    /// Unique ID of the *Category*. Increments sequentially. Read-Only. 
    /// </summary>
    /// <value>Unique ID of the *Category*. Increments sequentially. Read-Only. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric ID of the category's parent. This field controls where the category sits in the tree of categories that organize the catalog. Required in a POST if creating a child category.
    /// </summary>
    /// <value>The unique numeric ID of the category's parent. This field controls where the category sits in the tree of categories that organize the catalog. Required in a POST if creating a child category.</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public int? ParentId { get; set; }

    /// <summary>
    /// The name displayed for the category. Name is unique with respect to the category's siblings. Required in a POST.
    /// </summary>
    /// <value>The name displayed for the category. Name is unique with respect to the category's siblings. Required in a POST.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The product description, which can include HTML formatting. 
    /// </summary>
    /// <value>The product description, which can include HTML formatting. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Number of views the category has on the storefront. 
    /// </summary>
    /// <value>Number of views the category has on the storefront. </value>
    [DataMember(Name="views", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "views")]
    public int? Views { get; set; }

    /// <summary>
    /// Priority this category will be given when included in the menu and category pages. The lower the number, the closer to the top of the results the category will be. 
    /// </summary>
    /// <value>Priority this category will be given when included in the menu and category pages. The lower the number, the closer to the top of the results the category will be. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Custom title for the category page. If not defined, the category name will be used as the meta title. 
    /// </summary>
    /// <value>Custom title for the category page. If not defined, the category name will be used as the meta title. </value>
    [DataMember(Name="page_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page_title")]
    public string PageTitle { get; set; }

    /// <summary>
    /// A comma-separated list of keywords that can be used to locate the category when searching the store. 
    /// </summary>
    /// <value>A comma-separated list of keywords that can be used to locate the category when searching the store. </value>
    [DataMember(Name="search_keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "search_keywords")]
    public string SearchKeywords { get; set; }

    /// <summary>
    /// Custom meta keywords for the category page. If not defined, the store's default keywords will be used. Must post as an array like: [\"awesome\",\"sauce\"]. 
    /// </summary>
    /// <value>Custom meta keywords for the category page. If not defined, the store's default keywords will be used. Must post as an array like: [\"awesome\",\"sauce\"]. </value>
    [DataMember(Name="meta_keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta_keywords")]
    public List<string> MetaKeywords { get; set; }

    /// <summary>
    /// Custom meta description for the category page. If not defined, the store's default meta description will be used. 
    /// </summary>
    /// <value>Custom meta description for the category page. If not defined, the store's default meta description will be used. </value>
    [DataMember(Name="meta_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta_description")]
    public string MetaDescription { get; set; }

    /// <summary>
    /// A valid layout file. (Please refer to [this article](https://support.bigcommerce.com/articles/Public/Creating-Custom-Template-Files/) on creating category files.) This field is writable only for stores with a Blueprint theme applied. 
    /// </summary>
    /// <value>A valid layout file. (Please refer to [this article](https://support.bigcommerce.com/articles/Public/Creating-Custom-Template-Files/) on creating category files.) This field is writable only for stores with a Blueprint theme applied. </value>
    [DataMember(Name="layout_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "layout_file")]
    public string LayoutFile { get; set; }

    /// <summary>
    /// Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the category will be displayed. If `false`, the category will be hidden from view. 
    /// </summary>
    /// <value>Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the category will be displayed. If `false`, the category will be hidden from view. </value>
    [DataMember(Name="is_visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_visible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// Determines how the products are sorted on category page load. 
    /// </summary>
    /// <value>Determines how the products are sorted on category page load. </value>
    [DataMember(Name="default_product_sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_product_sort")]
    public string DefaultProductSort { get; set; }

    /// <summary>
    /// Image URL used for this category on the storefront. Images can be uploaded via form file post to `/categories/{categoryId}/image`, or by providing a publicly accessible URL in this field. 
    /// </summary>
    /// <value>Image URL used for this category on the storefront. Images can be uploaded via form file post to `/categories/{categoryId}/image`, or by providing a publicly accessible URL in this field. </value>
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
      sb.Append("class CategoryFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Views: ").Append(Views).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
      sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
      sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
      sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
      sb.Append("  LayoutFile: ").Append(LayoutFile).Append("\n");
      sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
      sb.Append("  DefaultProductSort: ").Append(DefaultProductSort).Append("\n");
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
