using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A BigCommerce Transaction object describes a single transaction.
  /// </summary>
  [DataContract]
  public class Transaction {
    /// <summary>
    /// Unique identifier for the transaction. 
    /// </summary>
    /// <value>Unique identifier for the transaction. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Identifier for the BigCommerce Order with which this transaction is associated. 
    /// </summary>
    /// <value>Identifier for the BigCommerce Order with which this transaction is associated. </value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public string OrderId { get; set; }

    /// <summary>
    /// The datetime of the transaction. 
    /// </summary>
    /// <value>The datetime of the transaction. </value>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// This field contains internal BigPay token for stored card that is then mapped to the actual third-party token. We currently do not offer a way to get third party tokens.These tokens are read-only and do not return any information about the payment.
    /// </summary>
    /// <value>This field contains internal BigPay token for stored card that is then mapped to the actual third-party token. We currently do not offer a way to get third party tokens.These tokens are read-only and do not return any information about the payment.</value>
    [DataMember(Name="payment_instrument_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_instrument_token")]
    public string PaymentInstrumentToken { get; set; }

    /// <summary>
    /// Gets or Sets AvsResult
    /// </summary>
    [DataMember(Name="avs_result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avs_result")]
    public AVSResults AvsResult { get; set; }

    /// <summary>
    /// Gets or Sets CvvResult
    /// </summary>
    [DataMember(Name="cvv_result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cvv_result")]
    public CVVResult CvvResult { get; set; }

    /// <summary>
    /// Gets or Sets CreditCard
    /// </summary>
    [DataMember(Name="credit_card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_card")]
    public CreditCard CreditCard { get; set; }

    /// <summary>
    /// Gets or Sets GiftCertificate
    /// </summary>
    [DataMember(Name="gift_certificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gift_certificate")]
    public GiftCertificate GiftCertificate { get; set; }

    /// <summary>
    /// Gets or Sets StoreCredit
    /// </summary>
    [DataMember(Name="store_credit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store_credit")]
    public TransactionStoreCredit StoreCredit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Transaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  PaymentInstrumentToken: ").Append(PaymentInstrumentToken).Append("\n");
      sb.Append("  AvsResult: ").Append(AvsResult).Append("\n");
      sb.Append("  CvvResult: ").Append(CvvResult).Append("\n");
      sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
      sb.Append("  GiftCertificate: ").Append(GiftCertificate).Append("\n");
      sb.Append("  StoreCredit: ").Append(StoreCredit).Append("\n");
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
