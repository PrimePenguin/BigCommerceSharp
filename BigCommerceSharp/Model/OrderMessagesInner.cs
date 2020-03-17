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
  public class OrderMessagesInner {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets OrderId
    /// </summary>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// Gets or Sets StaffId
    /// </summary>
    [DataMember(Name="staff_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staff_id")]
    public int? StaffId { get; set; }

    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    [DataMember(Name="customer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_id")]
    public int? CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets IsFlagged
    /// </summary>
    [DataMember(Name="is_flagged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_flagged")]
    public bool? IsFlagged { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public string DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public string Customer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderMessagesInner {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  StaffId: ").Append(StaffId).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  IsFlagged: ").Append(IsFlagged).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
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
