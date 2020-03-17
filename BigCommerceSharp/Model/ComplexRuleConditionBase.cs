using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Complex rules may return with conditions that apply to one or more variants, or with a single modifier value (if the rules were created using the v2 API or the control panel). Complex rules created or updated in the v3 API must have conditions that either reference multiple &#x60;modifier_value_id&#x60;&#39;s, or else reference a &#x60;modifier_value_id&#x60; and a &#x60;variant_id&#x60;.
  /// </summary>
  [DataContract]
  public class ComplexRuleConditionBase {
    /// <summary>
    /// The unique numeric ID of the rule condition; increments sequentially. Read-Only 
    /// </summary>
    /// <value>The unique numeric ID of the rule condition; increments sequentially. Read-Only </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numeric ID of the rule with which the condition is associated. Read-Only
    /// </summary>
    /// <value>The unique numeric ID of the rule with which the condition is associated. Read-Only</value>
    [DataMember(Name="rule_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule_id")]
    public int? RuleId { get; set; }

    /// <summary>
    /// The unique numeric ID of the modifier with which the rule condition is associated. Required in /POST.
    /// </summary>
    /// <value>The unique numeric ID of the modifier with which the rule condition is associated. Required in /POST.</value>
    [DataMember(Name="modifier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifier_id")]
    public int? ModifierId { get; set; }

    /// <summary>
    /// The unique numeric ID of the modifier value with which the rule condition is associated. Required in /POST.
    /// </summary>
    /// <value>The unique numeric ID of the modifier value with which the rule condition is associated. Required in /POST.</value>
    [DataMember(Name="modifier_value_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifier_value_id")]
    public int? ModifierValueId { get; set; }

    /// <summary>
    /// The unique numeric ID of the variant with which the rule condition is associated. Required in /POST.
    /// </summary>
    /// <value>The unique numeric ID of the variant with which the rule condition is associated. Required in /POST.</value>
    [DataMember(Name="variant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_id")]
    public int? VariantId { get; set; }

    /// <summary>
    /// (READ-ONLY:) The unique numeric ID of the SKU (v2 API), or Combination, with which the rule condition is associated. This is to maintain cross-compatibility between v2 and v3. 
    /// </summary>
    /// <value>(READ-ONLY:) The unique numeric ID of the SKU (v2 API), or Combination, with which the rule condition is associated. This is to maintain cross-compatibility between v2 and v3. </value>
    [DataMember(Name="combination_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "combination_id")]
    public int? CombinationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComplexRuleConditionBase {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RuleId: ").Append(RuleId).Append("\n");
      sb.Append("  ModifierId: ").Append(ModifierId).Append("\n");
      sb.Append("  ModifierValueId: ").Append(ModifierValueId).Append("\n");
      sb.Append("  VariantId: ").Append(VariantId).Append("\n");
      sb.Append("  CombinationId: ").Append(CombinationId).Append("\n");
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
