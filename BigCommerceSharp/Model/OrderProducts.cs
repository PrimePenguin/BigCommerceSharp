using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OrderProducts
    {
        /// <summary>
        /// Numeric ID of this product within this order.
        /// </summary>
        /// <value>Numeric ID of this product within this order.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Numeric ID of the associated order.
        /// </summary>
        /// <value>Numeric ID of the associated order.</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order_id")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Numeric ID of the product.
        /// </summary>
        /// <value>Numeric ID of the product.</value>
        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// Numeric ID of the associated order address.
        /// </summary>
        /// <value>Numeric ID of the associated order address.</value>
        [DataMember(Name = "order_address_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order_address_id")]
        public int? OrderAddressId { get; set; }

        /// <summary>
        /// The product name.
        /// </summary>
        /// <value>The product name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// User-defined product code/stock keeping unit (SKU).
        /// </summary>
        /// <value>User-defined product code/stock keeping unit (SKU).</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Type of product
        /// </summary>
        /// <value>Type of product</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The product's base price. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The product's base price. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "base_price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base_price")]
        public string BasePrice { get; set; }

        /// <summary>
        /// The product’s price excluding tax. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The product’s price excluding tax. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "price_ex_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price_ex_tax")]
        public string PriceExTax { get; set; }

        /// <summary>
        /// The product’s price including tax. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The product’s price including tax. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "price_inc_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price_inc_tax")]
        public string PriceIncTax { get; set; }

        /// <summary>
        /// Amount of tax applied to a single product.  Price tax is calculated as: `price_tax = price_inc_tax - price_ex_tax`  (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Amount of tax applied to a single product.  Price tax is calculated as: `price_tax = price_inc_tax - price_ex_tax`  (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "price_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price_tax")]
        public string PriceTax { get; set; }

        /// <summary>
        /// Total base price. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Total base price. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "base_total", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base_total")]
        public string BaseTotal { get; set; }

        /// <summary>
        /// Total base price excluding tax. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Total base price excluding tax. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "total_ex_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total_ex_tax")]
        public string TotalExTax { get; set; }

        /// <summary>
        /// Total base price including tax. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Total base price including tax. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "total_inc_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total_inc_tax")]
        public string TotalIncTax { get; set; }

        /// <summary>
        /// Total tax applied to products. For example, if quantity if 2, base price is 5 and tax rate is 10%. price_tax will be $.50 and total_tax will be $1.00.  If there is a manual discount applied total_tax is calcuted as the following: `(price_ex_tax - discount)*tax_rate=total_tax`. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Total tax applied to products. For example, if quantity if 2, base price is 5 and tax rate is 10%. price_tax will be $.50 and total_tax will be $1.00.  If there is a manual discount applied total_tax is calcuted as the following: `(price_ex_tax - discount)*tax_rate=total_tax`. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "total_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total_tax")]
        public string TotalTax { get; set; }

        /// <summary>
        /// Quantity of the product ordered.
        /// </summary>
        /// <value>Quantity of the product ordered.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The product's cost price.  This can be set using the Catalog API. (Float, Float-As-String, Integer) Read Only
        /// </summary>
        /// <value>The product's cost price.  This can be set using the Catalog API. (Float, Float-As-String, Integer) Read Only</value>
        [DataMember(Name = "base_cost_price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base_cost_price")]
        public string BaseCostPrice { get; set; }

        /// <summary>
        /// The product's cost price including tax. (Float, Float-As-String, Integer) The cost of your products to you; this is never shown to customers, but can be used for accounting purposes. Read Only
        /// </summary>
        /// <value>The product's cost price including tax. (Float, Float-As-String, Integer) The cost of your products to you; this is never shown to customers, but can be used for accounting purposes. Read Only</value>
        [DataMember(Name = "cost_price_inc_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cost_price_inc_tax")]
        public string CostPriceIncTax { get; set; }

        /// <summary>
        /// The products cost price excluding tax. (Float, Float-As-String, Integer) The cost of your products to you; this is never shown to customers, but can be used for accounting purposes. Read Only
        /// </summary>
        /// <value>The products cost price excluding tax. (Float, Float-As-String, Integer) The cost of your products to you; this is never shown to customers, but can be used for accounting purposes. Read Only</value>
        [DataMember(Name = "cost_price_ex_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cost_price_ex_tax")]
        public string CostPriceExTax { get; set; }

        /// <summary>
        /// Weight of the product. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Weight of the product. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weight")]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Width of the product.
        /// </summary>
        /// <value>Width of the product. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "width")]
        public decimal? Width { get; set; }

        /// <summary>
        /// Height of the product.
        /// </summary>
        /// <value>Height of the product. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Depth of the product.
        /// </summary>
        /// <value>Height of the product. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "depth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "depth")]
        public decimal? Depth { get; set; }

        /// <summary>
        /// fulfillment source
        /// </summary>
        /// <value>fulfillment source</value>
        [DataMember(Name = "fulfillment_source", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fulfillment_source")]
        public string FulfillmentSource { get; set; }

        /// <summary>
        /// Tax applied to the product’s cost price. (Float, Float-As-String, Integer) The cost of your products to you; this is never shown to customers, but can be used for accounting purposes. Read Only
        /// </summary>
        /// <value>Tax applied to the product’s cost price. (Float, Float-As-String, Integer) The cost of your products to you; this is never shown to customers, but can be used for accounting purposes. Read Only</value>
        [DataMember(Name = "cost_price_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cost_price_tax")]
        public string CostPriceTax { get; set; }

        /// <summary>
        /// Whether the product has been refunded.
        /// </summary>
        /// <value>Whether the product has been refunded.</value>
        [DataMember(Name = "is_refunded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "is_refunded")]
        public bool? IsRefunded { get; set; }

        /// <summary>
        /// Refunded quantity
        /// </summary>
        /// <value>Whether the product has been refunded.</value>
        [DataMember(Name = "quantity_refunded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity_refunded")]
        public decimal? QuantityRefunded { get; set; }

        /// <summary>
        /// The amount refunded from this transaction. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The amount refunded from this transaction. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "refunded_amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refunded_amount")]
        public string RefundedAmount { get; set; }

        /// <summary>
        /// Numeric ID for the refund.
        /// </summary>
        /// <value>Numeric ID for the refund.</value>
        [DataMember(Name = "return_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "return_id")]
        public decimal? ReturnId { get; set; }

        /// <summary>
        /// Name of gift-wrapping option
        /// </summary>
        /// <value>Name of gift-wrapping option</value>
        [DataMember(Name = "wrapping_name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wrapping_name")]
        public string WrappingName { get; set; }

        /// <summary>
        /// The value of the base wrapping cost. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The value of the base wrapping cost. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "base_wrapping_cost", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base_wrapping_cost")]
        public string BaseWrappingCost { get; set; }

        /// <summary>
        /// The value of the wrapping cost, excluding tax. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The value of the wrapping cost, excluding tax. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "wrapping_cost_ex_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wrapping_cost_ex_tax")]
        public string WrappingCostExTax { get; set; }

        /// <summary>
        /// The value of the wrapping cost, including tax. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>The value of the wrapping cost, including tax. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "wrapping_cost_inc_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wrapping_cost_inc_tax")]
        public string WrappingCostIncTax { get; set; }

        /// <summary>
        /// Tax applied to gift-wrapping option. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Tax applied to gift-wrapping option. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "wrapping_cost_tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wrapping_cost_tax")]
        public string WrappingCostTax { get; set; }

        /// <summary>
        /// Message to accompany gift-wrapping option.
        /// </summary>
        /// <value>Message to accompany gift-wrapping option.</value>
        [DataMember(Name = "wrapping_message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wrapping_message")]
        public string WrappingMessage { get; set; }

        /// <summary>
        /// Quantity of this item shipped.
        /// </summary>
        /// <value>Quantity of this item shipped.</value>
        [DataMember(Name = "quantity_shipped", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity_shipped")]
        public decimal? QuantityShipped { get; set; }

        /// <summary>
        /// Name of promotional event/delivery date.
        /// </summary>
        /// <value>Name of promotional event/delivery date.</value>
        [DataMember(Name = "event_name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Date of the promotional event/scheduled delivery.
        /// </summary>
        /// <value>Date of the promotional event/scheduled delivery.</value>
        [DataMember(Name = "event_date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "event_date")]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Fixed shipping cost for this product. (Float, Float-As-String, Integer)
        /// </summary>
        /// <value>Fixed shipping cost for this product. (Float, Float-As-String, Integer)</value>
        [DataMember(Name = "fixed_shipping_cost", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fixed_shipping_cost")]
        public string FixedShippingCost { get; set; }

        /// <summary>
        /// Item ID for this product on eBay.
        /// </summary>
        /// <value>Item ID for this product on eBay.</value>
        [DataMember(Name = "ebay_item_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ebay_item_id")]
        public string EbayItemId { get; set; }

        /// <summary>
        /// Transaction ID for this product on eBay.
        /// </summary>
        /// <value>Transaction ID for this product on eBay.</value>
        [DataMember(Name = "ebay_transaction_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ebay_transaction_id")]
        public string EbayTransactionId { get; set; }

        /// <summary>
        /// Numeric ID of the option set applied to the product.
        /// </summary>
        /// <value>Numeric ID of the option set applied to the product.</value>
        [DataMember(Name = "option_set_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "option_set_id")]
        public int? OptionSetId { get; set; }

        /// <summary>
        /// ID of a parent product.
        /// </summary>
        /// <value>ID of a parent product.</value>
        [DataMember(Name = "parent_order_product_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parent_order_product_id")]
        public int? ParentOrderProductId { get; set; }

        /// <summary>
        /// Whether this product is bundled with other products.
        /// </summary>
        /// <value>Whether this product is bundled with other products.</value>
        [DataMember(Name = "is_bundled_product", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "is_bundled_product")]
        public bool? IsBundledProduct { get; set; }

        /// <summary>
        /// Bin picking number for the physical product.
        /// </summary>
        /// <value>Bin picking number for the physical product.</value>
        [DataMember(Name = "bin_picking_number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bin_picking_number")]
        public string BinPickingNumber { get; set; }

        /// <summary>
        /// Array of objects containing discounts applied to the product.
        /// </summary>
        /// <value>Array of objects containing discounts applied to the product.</value>
        [DataMember(Name = "applied_discounts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "applied_discounts")]
        public List<OrderProductsAppliedDiscounts> AppliedDiscounts { get; set; }

        /// <summary>
        /// Array of product option objects.
        /// </summary>
        /// <value>Array of product option objects.</value>
        [DataMember(Name = "product_options", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product_options")]
        public List<OrderProductsProductOptions> ProductOptions { get; set; }

        /// <summary>
        /// ID of the order in another system. For example, the Amazon Order ID if this is an Amazon order.This field can be updated in a /POST, but using a /PUT to update the order will return a 400 error. The field 'external_id' cannot be written to. Please remove it from your request before trying again. It can not be overwritten once set.
        /// </summary>
        /// <value>ID of the order in another system. For example, the Amazon Order ID if this is an Amazon order.This field can be updated in a /POST, but using a /PUT to update the order will return a 400 error. The field 'external_id' cannot be written to. Please remove it from your request before trying again. It can not be overwritten once set.</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "external_id")]
        public int? ExternalId { get; set; }

        /// <summary>
        /// Universal Product Code. Can be written to for custom products and catalog products.
        /// </summary>
        /// <value>Universal Product Code. Can be written to for custom products and catalog products.</value>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "upc")]
        public string Upc { get; set; }

        /// <summary>
        /// Products `variant_id`. PUT or POST. This field is not available for custom products.
        /// </summary>
        /// <value>Products `variant_id`. PUT or POST. This field is not available for custom products.</value>
        [DataMember(Name = "variant_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "variant_id")]
        public int? VariantId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderProducts {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  OrderAddressId: ").Append(OrderAddressId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BasePrice: ").Append(BasePrice).Append("\n");
            sb.Append("  PriceExTax: ").Append(PriceExTax).Append("\n");
            sb.Append("  PriceIncTax: ").Append(PriceIncTax).Append("\n");
            sb.Append("  PriceTax: ").Append(PriceTax).Append("\n");
            sb.Append("  BaseTotal: ").Append(BaseTotal).Append("\n");
            sb.Append("  TotalExTax: ").Append(TotalExTax).Append("\n");
            sb.Append("  TotalIncTax: ").Append(TotalIncTax).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  BaseCostPrice: ").Append(BaseCostPrice).Append("\n");
            sb.Append("  CostPriceIncTax: ").Append(CostPriceIncTax).Append("\n");
            sb.Append("  CostPriceExTax: ").Append(CostPriceExTax).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  CostPriceTax: ").Append(CostPriceTax).Append("\n");
            sb.Append("  IsRefunded: ").Append(IsRefunded).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  ReturnId: ").Append(ReturnId).Append("\n");
            sb.Append("  WrappingName: ").Append(WrappingName).Append("\n");
            sb.Append("  BaseWrappingCost: ").Append(BaseWrappingCost).Append("\n");
            sb.Append("  WrappingCostExTax: ").Append(WrappingCostExTax).Append("\n");
            sb.Append("  WrappingCostIncTax: ").Append(WrappingCostIncTax).Append("\n");
            sb.Append("  WrappingCostTax: ").Append(WrappingCostTax).Append("\n");
            sb.Append("  WrappingMessage: ").Append(WrappingMessage).Append("\n");
            sb.Append("  QuantityShipped: ").Append(QuantityShipped).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  FixedShippingCost: ").Append(FixedShippingCost).Append("\n");
            sb.Append("  EbayItemId: ").Append(EbayItemId).Append("\n");
            sb.Append("  EbayTransactionId: ").Append(EbayTransactionId).Append("\n");
            sb.Append("  OptionSetId: ").Append(OptionSetId).Append("\n");
            sb.Append("  ParentOrderProductId: ").Append(ParentOrderProductId).Append("\n");
            sb.Append("  IsBundledProduct: ").Append(IsBundledProduct).Append("\n");
            sb.Append("  BinPickingNumber: ").Append(BinPickingNumber).Append("\n");
            sb.Append("  AppliedDiscounts: ").Append(AppliedDiscounts).Append("\n");
            sb.Append("  ProductOptions: ").Append(ProductOptions).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
