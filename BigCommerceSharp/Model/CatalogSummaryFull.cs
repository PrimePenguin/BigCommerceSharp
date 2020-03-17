using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Catalog Summary object describes a lightweight summary of the catalog.
  /// </summary>
  [DataContract]
  public class CatalogSummaryFull {
    /// <summary>
    /// A count of all inventory items in the catalog. 
    /// </summary>
    /// <value>A count of all inventory items in the catalog. </value>
    [DataMember(Name="inventory_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_count")]
    public int? InventoryCount { get; set; }

    /// <summary>
    /// Total value of store's inventory. 
    /// </summary>
    /// <value>Total value of store's inventory. </value>
    [DataMember(Name="inventory_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_value")]
    public double? InventoryValue { get; set; }

    /// <summary>
    /// ID of the category containing the most products. 
    /// </summary>
    /// <value>ID of the category containing the most products. </value>
    [DataMember(Name="primary_category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary_category_id")]
    public int? PrimaryCategoryId { get; set; }

    /// <summary>
    /// Name of the category containing the most products. 
    /// </summary>
    /// <value>Name of the category containing the most products. </value>
    [DataMember(Name="primary_category_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary_category_name")]
    public string PrimaryCategoryName { get; set; }

    /// <summary>
    /// Total number of variants
    /// </summary>
    /// <value>Total number of variants</value>
    [DataMember(Name="variant_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_count")]
    public int? VariantCount { get; set; }

    /// <summary>
    /// Highest priced variant
    /// </summary>
    /// <value>Highest priced variant</value>
    [DataMember(Name="highest_variant_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highest_variant_price")]
    public double? HighestVariantPrice { get; set; }

    /// <summary>
    /// Average price of all variants
    /// </summary>
    /// <value>Average price of all variants</value>
    [DataMember(Name="average_variant_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_variant_price")]
    public double? AverageVariantPrice { get; set; }

    /// <summary>
    /// Lowest priced variant in the store
    /// </summary>
    /// <value>Lowest priced variant in the store</value>
    [DataMember(Name="lowest_variant_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowest_variant_price")]
    public string LowestVariantPrice { get; set; }

    /// <summary>
    /// Gets or Sets OldestVariantDate
    /// </summary>
    [DataMember(Name="oldest_variant_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oldest_variant_date")]
    public string OldestVariantDate { get; set; }

    /// <summary>
    /// Gets or Sets NewestVariantDate
    /// </summary>
    [DataMember(Name="newest_variant_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newest_variant_date")]
    public string NewestVariantDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CatalogSummaryFull {\n");
      sb.Append("  InventoryCount: ").Append(InventoryCount).Append("\n");
      sb.Append("  InventoryValue: ").Append(InventoryValue).Append("\n");
      sb.Append("  PrimaryCategoryId: ").Append(PrimaryCategoryId).Append("\n");
      sb.Append("  PrimaryCategoryName: ").Append(PrimaryCategoryName).Append("\n");
      sb.Append("  VariantCount: ").Append(VariantCount).Append("\n");
      sb.Append("  HighestVariantPrice: ").Append(HighestVariantPrice).Append("\n");
      sb.Append("  AverageVariantPrice: ").Append(AverageVariantPrice).Append("\n");
      sb.Append("  LowestVariantPrice: ").Append(LowestVariantPrice).Append("\n");
      sb.Append("  OldestVariantDate: ").Append(OldestVariantDate).Append("\n");
      sb.Append("  NewestVariantDate: ").Append(NewestVariantDate).Append("\n");
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
