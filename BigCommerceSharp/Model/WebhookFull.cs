using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WebhookFull {
    /// <summary>
    /// Id of the webhook
    /// </summary>
    /// <value>Id of the webhook</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Client ID, unique to the store
    /// </summary>
    /// <value>Client ID, unique to the store</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Store permanent ID. 
    /// </summary>
    /// <value>Store permanent ID. </value>
    [DataMember(Name="store_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store_hash")]
    public string StoreHash { get; set; }

    /// <summary>
    /// Webhook event subscribed to
    /// </summary>
    /// <value>Webhook event subscribed to</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// URL that returns a 200 response for webhooks
    /// </summary>
    /// <value>URL that returns a 200 response for webhooks</value>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public HooksHeaders Headers { get; set; }

    /// <summary>
    /// If the webhook is active or not
    /// </summary>
    /// <value>If the webhook is active or not</value>
    [DataMember(Name="is_active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Created time
    /// </summary>
    /// <value>Created time</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public int? CreatedAt { get; set; }

    /// <summary>
    /// Updated time
    /// </summary>
    /// <value>Updated time</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public int? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhookFull {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  StoreHash: ").Append(StoreHash).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
