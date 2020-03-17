using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Products and Billing address only required for POST operation.
  /// </summary>
  [DataContract]
  public class OrderPost2 {
    /// <summary>
    /// Gets or Sets Products
    /// </summary>
    [DataMember(Name="products", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "products")]
    public List<Object> Products { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billing_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_address")]
    public BillingAddress1 BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets ShippingAddresses
    /// </summary>
    [DataMember(Name="shipping_addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_addresses")]
    public ShippingAddressResource ShippingAddresses { get; set; }

    /// <summary>
    /// The ID of the customer placing the order; or 0 if it was a guest order.
    /// </summary>
    /// <value>The ID of the customer placing the order; or 0 if it was a guest order.</value>
    [DataMember(Name="customer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_id")]
    public int? CustomerId { get; set; }

    /// <summary>
    /// The status ID of the order.
    /// </summary>
    /// <value>The status ID of the order.</value>
    [DataMember(Name="status_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_id")]
    public int? StatusId { get; set; }

    /// <summary>
    /// Override value for subtotal excluding tax. If specified, the field `subtotal_inc_tax` is also required. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>Override value for subtotal excluding tax. If specified, the field `subtotal_inc_tax` is also required. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="subtotal_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal_ex_tax")]
    public string SubtotalExTax { get; set; }

    /// <summary>
    /// Override value for subtotal including tax. If specified, the field `subtotal_ex_tax` is also required. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>Override value for subtotal including tax. If specified, the field `subtotal_ex_tax` is also required. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="subtotal_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal_inc_tax")]
    public string SubtotalIncTax { get; set; }

    /// <summary>
    /// The value of the base shipping cost. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the base shipping cost. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="base_shipping_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_shipping_cost")]
    public string BaseShippingCost { get; set; }

    /// <summary>
    /// The value of shipping cost, excluding tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of shipping cost, excluding tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="shipping_cost_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_cost_ex_tax")]
    public string ShippingCostExTax { get; set; }

    /// <summary>
    /// The value of shipping cost, including tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of shipping cost, including tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="shipping_cost_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_cost_inc_tax")]
    public string ShippingCostIncTax { get; set; }

    /// <summary>
    /// The value of the base handling cost. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the base handling cost. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="base_handling_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_handling_cost")]
    public string BaseHandlingCost { get; set; }

    /// <summary>
    /// The value of the handling cost, excluding tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the handling cost, excluding tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="handling_cost_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_cost_ex_tax")]
    public string HandlingCostExTax { get; set; }

    /// <summary>
    /// The value of the handling cost, including tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the handling cost, including tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="handling_cost_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_cost_inc_tax")]
    public string HandlingCostIncTax { get; set; }

    /// <summary>
    /// The value of the base wrapping cost. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the base wrapping cost. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="base_wrapping_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_wrapping_cost")]
    public string BaseWrappingCost { get; set; }

    /// <summary>
    /// The value of the wrapping cost, excluding tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the wrapping cost, excluding tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="wrapping_cost_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wrapping_cost_ex_tax")]
    public string WrappingCostExTax { get; set; }

    /// <summary>
    /// The value of the wrapping cost, including tax. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The value of the wrapping cost, including tax. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="wrapping_cost_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wrapping_cost_inc_tax")]
    public string WrappingCostIncTax { get; set; }

    /// <summary>
    /// Override value for the total, excluding tax. If specified, the field `total_inc_tax` is also required. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>Override value for the total, excluding tax. If specified, the field `total_inc_tax` is also required. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="total_ex_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_ex_tax")]
    public string TotalExTax { get; set; }

    /// <summary>
    /// Override value for the total, including tax. If specified, the field `total_ex_tax` is also required. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>Override value for the total, including tax. If specified, the field `total_ex_tax` is also required. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="total_inc_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_inc_tax")]
    public string TotalIncTax { get; set; }

    /// <summary>
    /// The total number of items in the order.
    /// </summary>
    /// <value>The total number of items in the order.</value>
    [DataMember(Name="items_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items_total")]
    public decimal? ItemsTotal { get; set; }

    /// <summary>
    /// The number of items that have been shipped.
    /// </summary>
    /// <value>The number of items that have been shipped.</value>
    [DataMember(Name="items_shipped", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items_shipped")]
    public decimal? ItemsShipped { get; set; }

    /// <summary>
    /// The payment method for this order. Can be one of the following: `Manual`, `Credit Card`, `cash`, `Test Payment Gateway`, etc.
    /// </summary>
    /// <value>The payment method for this order. Can be one of the following: `Manual`, `Credit Card`, `cash`, `Test Payment Gateway`, etc.</value>
    [DataMember(Name="payment_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method")]
    public string PaymentMethod { get; set; }

    /// <summary>
    /// The external Transaction ID/Payment ID within this order's payment provider (if a payment provider was used).
    /// </summary>
    /// <value>The external Transaction ID/Payment ID within this order's payment provider (if a payment provider was used).</value>
    [DataMember(Name="payment_provider_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_provider_id")]
    public string PaymentProviderId { get; set; }

    /// <summary>
    /// The amount refunded from this transaction. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>The amount refunded from this transaction. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="refunded_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refunded_amount")]
    public string RefundedAmount { get; set; }

    /// <summary>
    /// Whether this is an order for digital products.
    /// </summary>
    /// <value>Whether this is an order for digital products.</value>
    [DataMember(Name="order_is_digital", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_is_digital")]
    public bool? OrderIsDigital { get; set; }

    /// <summary>
    /// A read-only value. Do not pass in a POST or PUT. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>A read-only value. Do not pass in a POST or PUT. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="gift_certificate_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gift_certificate_amount")]
    public string GiftCertificateAmount { get; set; }

    /// <summary>
    /// IP Address of the customer, if known.
    /// </summary>
    /// <value>IP Address of the customer, if known.</value>
    [DataMember(Name="ip_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip_address")]
    public string IpAddress { get; set; }

    /// <summary>
    /// The full name of the country where the customer made the purchase, based on the IP.
    /// </summary>
    /// <value>The full name of the country where the customer made the purchase, based on the IP.</value>
    [DataMember(Name="geoip_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geoip_country")]
    public string GeoipCountry { get; set; }

    /// <summary>
    /// The country where the customer made the purchase, in ISO2 format, based on the IP.
    /// </summary>
    /// <value>The country where the customer made the purchase, in ISO2 format, based on the IP.</value>
    [DataMember(Name="geoip_country_iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geoip_country_iso2")]
    public string GeoipCountryIso2 { get; set; }

    /// <summary>
    /// Any additional notes for staff.
    /// </summary>
    /// <value>Any additional notes for staff.</value>
    [DataMember(Name="staff_notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staff_notes")]
    public string StaffNotes { get; set; }

    /// <summary>
    /// Message that the customer entered (number, optiona) -o the `Order Comments` box during checkout.
    /// </summary>
    /// <value>Message that the customer entered (number, optiona) -o the `Order Comments` box during checkout.</value>
    [DataMember(Name="customer_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_message")]
    public string CustomerMessage { get; set; }

    /// <summary>
    /// Amount of discount for this transaction. (Float, Float-As-String, Integer)
    /// </summary>
    /// <value>Amount of discount for this transaction. (Float, Float-As-String, Integer)</value>
    [DataMember(Name="discount_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_amount")]
    public string DiscountAmount { get; set; }

    /// <summary>
    /// Indicates whether the order was deleted (archived). Set to to true, to archive an order.
    /// </summary>
    /// <value>Indicates whether the order was deleted (archived). Set to to true, to archive an order.</value>
    [DataMember(Name="is_deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_deleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Indicates whether the shopper has selected an opt-in check box (on the checkout page) to receive emails. A read-only value. Do not pass in a POST or PUT.
    /// </summary>
    /// <value>Indicates whether the shopper has selected an opt-in check box (on the checkout page) to receive emails. A read-only value. Do not pass in a POST or PUT.</value>
    [DataMember(Name="is_email_opt_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_email_opt_in")]
    public bool? IsEmailOptIn { get; set; }

    /// <summary>
    /// If the order was placed through eBay, the eBay order number will be included. Otherwise, the value will be `0`.
    /// </summary>
    /// <value>If the order was placed through eBay, the eBay order number will be included. Otherwise, the value will be `0`.</value>
    [DataMember(Name="ebay_order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ebay_order_id")]
    public string EbayOrderId { get; set; }

    /// <summary>
    /// For orders submitted or modified via the API, using a PUT or POST operation, you can optionally pass in a value identifying the system used to generate the order. For example: `POS`. Otherwise, the value will be null.
    /// </summary>
    /// <value>For orders submitted or modified via the API, using a PUT or POST operation, you can optionally pass in a value identifying the system used to generate the order. For example: `POS`. Otherwise, the value will be null.</value>
    [DataMember(Name="external_source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_source")]
    public string ExternalSource { get; set; }

    /// <summary>
    /// ID of the order in another system. For example, the Amazon Order ID if this is an Amazon order.This field can be updated in a /POST, but using a /PUT to update the order will return a 400 error. The field 'external_id' cannot be written to. Please remove it from your request before trying again. It can not be overwritten once set.
    /// </summary>
    /// <value>ID of the order in another system. For example, the Amazon Order ID if this is an Amazon order.This field can be updated in a /POST, but using a /PUT to update the order will return a 400 error. The field 'external_id' cannot be written to. Please remove it from your request before trying again. It can not be overwritten once set.</value>
    [DataMember(Name="external_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_id")]
    public int? ExternalId { get; set; }

    /// <summary>
    /// Shows where the order originated. The channel_id will default to 1. Read-Only.
    /// </summary>
    /// <value>Shows where the order originated. The channel_id will default to 1. Read-Only.</value>
    [DataMember(Name="channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channel_id")]
    public int? ChannelId { get; set; }

    /// <summary>
    /// BasicTaxProvider - Tax is set to manual.  AvaTaxProvider - This is for when the tax provider has been set to automatic and the order was NOT created by the API. Used for Avalara.  \"\" (blank) - When the tax provider is unknown. This includes legacy orders and orders previously created via API. This can be set when creating an order using a POST.  
    /// </summary>
    /// <value>BasicTaxProvider - Tax is set to manual.  AvaTaxProvider - This is for when the tax provider has been set to automatic and the order was NOT created by the API. Used for Avalara.  \"\" (blank) - When the tax provider is unknown. This includes legacy orders and orders previously created via API. This can be set when creating an order using a POST.  </value>
    [DataMember(Name="tax_provider_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_provider_id")]
    public string TaxProviderId { get; set; }

    /// <summary>
    /// The date this order was created. If not specified, will default to the current time. The date should be in RFC 2822 format.
    /// </summary>
    /// <value>The date this order was created. If not specified, will default to the current time. The date should be in RFC 2822 format.</value>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public string DateCreated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderPost2 {\n");
      sb.Append("  Products: ").Append(Products).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  ShippingAddresses: ").Append(ShippingAddresses).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  StatusId: ").Append(StatusId).Append("\n");
      sb.Append("  SubtotalExTax: ").Append(SubtotalExTax).Append("\n");
      sb.Append("  SubtotalIncTax: ").Append(SubtotalIncTax).Append("\n");
      sb.Append("  BaseShippingCost: ").Append(BaseShippingCost).Append("\n");
      sb.Append("  ShippingCostExTax: ").Append(ShippingCostExTax).Append("\n");
      sb.Append("  ShippingCostIncTax: ").Append(ShippingCostIncTax).Append("\n");
      sb.Append("  BaseHandlingCost: ").Append(BaseHandlingCost).Append("\n");
      sb.Append("  HandlingCostExTax: ").Append(HandlingCostExTax).Append("\n");
      sb.Append("  HandlingCostIncTax: ").Append(HandlingCostIncTax).Append("\n");
      sb.Append("  BaseWrappingCost: ").Append(BaseWrappingCost).Append("\n");
      sb.Append("  WrappingCostExTax: ").Append(WrappingCostExTax).Append("\n");
      sb.Append("  WrappingCostIncTax: ").Append(WrappingCostIncTax).Append("\n");
      sb.Append("  TotalExTax: ").Append(TotalExTax).Append("\n");
      sb.Append("  TotalIncTax: ").Append(TotalIncTax).Append("\n");
      sb.Append("  ItemsTotal: ").Append(ItemsTotal).Append("\n");
      sb.Append("  ItemsShipped: ").Append(ItemsShipped).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  PaymentProviderId: ").Append(PaymentProviderId).Append("\n");
      sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
      sb.Append("  OrderIsDigital: ").Append(OrderIsDigital).Append("\n");
      sb.Append("  GiftCertificateAmount: ").Append(GiftCertificateAmount).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  GeoipCountry: ").Append(GeoipCountry).Append("\n");
      sb.Append("  GeoipCountryIso2: ").Append(GeoipCountryIso2).Append("\n");
      sb.Append("  StaffNotes: ").Append(StaffNotes).Append("\n");
      sb.Append("  CustomerMessage: ").Append(CustomerMessage).Append("\n");
      sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
      sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
      sb.Append("  IsEmailOptIn: ").Append(IsEmailOptIn).Append("\n");
      sb.Append("  EbayOrderId: ").Append(EbayOrderId).Append("\n");
      sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
      sb.Append("  TaxProviderId: ").Append(TaxProviderId).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
