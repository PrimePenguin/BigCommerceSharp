using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Common Metafield properties.
  /// </summary>
  [DataContract]
  public class MetafieldBase {
    /// <summary>
    /// Unique ID of the *Metafield*. Read-Only.
    /// </summary>
    /// <value>Unique ID of the *Metafield*. Read-Only.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Determines whether the field is completely private to the app that owns the field (`app_only`), or visible to other API consumers (`read`), or completely open for reading and writing to other apps (`write`). Required for POST. 
    /// </summary>
    /// <value>Determines whether the field is completely private to the app that owns the field (`app_only`), or visible to other API consumers (`read`), or completely open for reading and writing to other apps (`write`). Required for POST. </value>
    [DataMember(Name="permission_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission_set")]
    public string PermissionSet { get; set; }

    /// <summary>
    /// Namespace for the metafield, for organizational purposes. This is set set by the developer. Required for POST. 
    /// </summary>
    /// <value>Namespace for the metafield, for organizational purposes. This is set set by the developer. Required for POST. </value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// The name of the field, for example: `location_id`, `color`. Required for POST. 
    /// </summary>
    /// <value>The name of the field, for example: `location_id`, `color`. Required for POST. </value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// The value of the field, for example: `1`, `blue`. Required for POST. 
    /// </summary>
    /// <value>The value of the field, for example: `1`, `blue`. Required for POST. </value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Description for the metafields. 
    /// </summary>
    /// <value>Description for the metafields. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The type of resource with which the metafield is associated. 
    /// </summary>
    /// <value>The type of resource with which the metafield is associated. </value>
    [DataMember(Name="resource_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_type")]
    public string ResourceType { get; set; }

    /// <summary>
    /// The ID for the resource with which the metafield is associated. 
    /// </summary>
    /// <value>The ID for the resource with which the metafield is associated. </value>
    [DataMember(Name="resource_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_id")]
    public int? ResourceId { get; set; }

    /// <summary>
    /// Date and time of the metafield's creation. Read-Only. 
    /// </summary>
    /// <value>Date and time of the metafield's creation. Read-Only. </value>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date and time when the metafield was last updated. Read-Only. 
    /// </summary>
    /// <value>Date and time when the metafield was last updated. Read-Only. </value>
    [DataMember(Name="date_modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_modified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetafieldBase {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PermissionSet: ").Append(PermissionSet).Append("\n");
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
      sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
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
