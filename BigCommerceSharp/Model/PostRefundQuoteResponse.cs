using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PostRefundQuoteResponse {
    /// <summary>
    /// ID of the order to be refunded
    /// </summary>
    /// <value>ID of the order to be refunded</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers
    /// </summary>
    /// <value>A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers</value>
    [DataMember(Name="total_refund_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_refund_amount")]
    public float? TotalRefundAmount { get; set; }

    /// <summary>
    /// Gets or Sets TotalRefundTaxAmount
    /// </summary>
    [DataMember(Name="total_refund_tax_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_refund_tax_amount")]
    public decimal? TotalRefundTaxAmount { get; set; }

    /// <summary>
    /// Indicates rounding value to bring refund_total to an amount refundable via payment providers (in this case to 2 decimal places)
    /// </summary>
    /// <value>Indicates rounding value to bring refund_total to an amount refundable via payment providers (in this case to 2 decimal places)</value>
    [DataMember(Name="rounding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rounding")]
    public decimal? Rounding { get; set; }

    /// <summary>
    /// A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers
    /// </summary>
    /// <value>A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers</value>
    [DataMember(Name="adjustment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adjustment")]
    public float? Adjustment { get; set; }

    /// <summary>
    /// Indicate if total_refund_amount includes tax amount
    /// </summary>
    /// <value>Indicate if total_refund_amount includes tax amount</value>
    [DataMember(Name="tax_inclusive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_inclusive")]
    public bool? TaxInclusive { get; set; }

    /// <summary>
    /// Returns the [Refund Method](#).  Note that `refund_methods` is a list of refund methods, with each refund method being a list of payment options. i.e. ``` refund methods := List<refund method> refund method := List<payment options> ```  For example, if the order was placed by a combination of store credit and bank deposit the  refund methods would be: ``` {   \"refund_methods\": [     [       {         \"provider_id\": \"storecredit\",         \"provider_description\": \"Store Credit\",         \"amount\": 119.35,         \"offline\": false,         \"offline_provider\": false,         \"offline_reason\": \"\"       }     ],     [       {         \"provider_id\": \"bankdeposit\",         \"provider_description\": \"Bank Deposit\",         \"amount\": 80.35,         \"offline\": true,         \"offline_provider\": true,         \"offline_reason\": \"This is an offline payment provider.\"       },       {         \"provider_id\": \"storecredit\",         \"provider_description\": \"Store Credit\",         \"amount\": 39,         \"offline\": false,         \"offline_provider\": false,         \"offline_reason\": \"\"       }     ]   ] } ```  In this case there are two refund methods available to the merchant 1. refund the entire order amount to store credit 2. refund the amount paid by store credit to store credit, and the amount paid by bank deposit via a manual refund which will be recorded as being refunded against the bank deposit.    >      
    /// </summary>
    /// <value>Returns the [Refund Method](#).  Note that `refund_methods` is a list of refund methods, with each refund method being a list of payment options. i.e. ``` refund methods := List<refund method> refund method := List<payment options> ```  For example, if the order was placed by a combination of store credit and bank deposit the  refund methods would be: ``` {   \"refund_methods\": [     [       {         \"provider_id\": \"storecredit\",         \"provider_description\": \"Store Credit\",         \"amount\": 119.35,         \"offline\": false,         \"offline_provider\": false,         \"offline_reason\": \"\"       }     ],     [       {         \"provider_id\": \"bankdeposit\",         \"provider_description\": \"Bank Deposit\",         \"amount\": 80.35,         \"offline\": true,         \"offline_provider\": true,         \"offline_reason\": \"This is an offline payment provider.\"       },       {         \"provider_id\": \"storecredit\",         \"provider_description\": \"Store Credit\",         \"amount\": 39,         \"offline\": false,         \"offline_provider\": false,         \"offline_reason\": \"\"       }     ]   ] } ```  In this case there are two refund methods available to the merchant 1. refund the entire order amount to store credit 2. refund the amount paid by store credit to store credit, and the amount paid by bank deposit via a manual refund which will be recorded as being refunded against the bank deposit.    >      </value>
    [DataMember(Name="refund_methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refund_methods")]
    public List<List<object>> RefundMethods { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostRefundQuoteResponse {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  TotalRefundAmount: ").Append(TotalRefundAmount).Append("\n");
      sb.Append("  TotalRefundTaxAmount: ").Append(TotalRefundTaxAmount).Append("\n");
      sb.Append("  Rounding: ").Append(Rounding).Append("\n");
      sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
      sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
      sb.Append("  RefundMethods: ").Append(RefundMethods).Append("\n");
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
