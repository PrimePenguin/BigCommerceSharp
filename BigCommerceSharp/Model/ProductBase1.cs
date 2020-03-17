using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Shared &#x60;Product&#x60; properties used in: * &#x60;POST&#x60; * &#x60;PUT&#x60; * &#x60;GET&#x60;
  /// </summary>
  [DataContract]
  public class ProductBase1 {
    /// <summary>
    /// The product name. 
    /// </summary>
    /// <value>The product name. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The product type. One of: `physical` - a physical stock unit, `digital` - a digital download. 
    /// </summary>
    /// <value>The product type. One of: `physical` - a physical stock unit, `digital` - a digital download. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// User defined product code/stock keeping unit (SKU). 
    /// </summary>
    /// <value>User defined product code/stock keeping unit (SKU). </value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// The product description, which can include HTML formatting. 
    /// </summary>
    /// <value>The product description, which can include HTML formatting. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Weight of the product, which can be used when calculating shipping costs. This is based on the unit set on the store 
    /// </summary>
    /// <value>Weight of the product, which can be used when calculating shipping costs. This is based on the unit set on the store </value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public float? Weight { get; set; }

    /// <summary>
    /// Width of the product, which can be used when calculating shipping costs. 
    /// </summary>
    /// <value>Width of the product, which can be used when calculating shipping costs. </value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public float? Width { get; set; }

    /// <summary>
    /// Depth of the product, which can be used when calculating shipping costs. 
    /// </summary>
    /// <value>Depth of the product, which can be used when calculating shipping costs. </value>
    [DataMember(Name="depth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "depth")]
    public float? Depth { get; set; }

    /// <summary>
    /// Height of the product, which can be used when calculating shipping costs. 
    /// </summary>
    /// <value>Height of the product, which can be used when calculating shipping costs. </value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public float? Height { get; set; }

    /// <summary>
    /// The price of the product. The price should include or exclude tax, based on the store settings. 
    /// </summary>
    /// <value>The price of the product. The price should include or exclude tax, based on the store settings. </value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    /// <summary>
    /// The cost price of the product. Stored for reference only; it is not used or displayed anywhere on the store. 
    /// </summary>
    /// <value>The cost price of the product. Stored for reference only; it is not used or displayed anywhere on the store. </value>
    [DataMember(Name="cost_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_price")]
    public float? CostPrice { get; set; }

    /// <summary>
    /// The retail cost of the product. If entered, the retail cost price will be shown on the product page. 
    /// </summary>
    /// <value>The retail cost of the product. If entered, the retail cost price will be shown on the product page. </value>
    [DataMember(Name="retail_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retail_price")]
    public float? RetailPrice { get; set; }

    /// <summary>
    /// If entered, the sale price will be used instead of value in the price field when calculating the product's cost. 
    /// </summary>
    /// <value>If entered, the sale price will be used instead of value in the price field when calculating the product's cost. </value>
    [DataMember(Name="sale_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_price")]
    public float? SalePrice { get; set; }

    /// <summary>
    /// The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.) 
    /// </summary>
    /// <value>The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.) </value>
    [DataMember(Name="tax_class_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_class_id")]
    public int? TaxClassId { get; set; }

    /// <summary>
    /// Accepts AvaTax System Tax Codes, which identify products and services that fall into special sales-tax categories. By using these codes, merchants who subscribe to BigCommerce's Avalara Premium integration can calculate sales taxes more accurately. Stores without Avalara Premium will ignore the code when calculating sales tax. Do not pass more than one code. The codes are case-sensitive. For details, please see Avalara's documentation. 
    /// </summary>
    /// <value>Accepts AvaTax System Tax Codes, which identify products and services that fall into special sales-tax categories. By using these codes, merchants who subscribe to BigCommerce's Avalara Premium integration can calculate sales taxes more accurately. Stores without Avalara Premium will ignore the code when calculating sales tax. Do not pass more than one code. The codes are case-sensitive. For details, please see Avalara's documentation. </value>
    [DataMember(Name="product_tax_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_tax_code")]
    public string ProductTaxCode { get; set; }

    /// <summary>
    /// An array of IDs for the categories to which this product belongs. When updating a product, if an array of categories is supplied, all product categories will be overwritten. Does not accept more than 1,000 ID values. 
    /// </summary>
    /// <value>An array of IDs for the categories to which this product belongs. When updating a product, if an array of categories is supplied, all product categories will be overwritten. Does not accept more than 1,000 ID values. </value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<int?> Categories { get; set; }

    /// <summary>
    /// A product can be added to an existing brand during a product /PUT or /POST. 
    /// </summary>
    /// <value>A product can be added to an existing brand during a product /PUT or /POST. </value>
    [DataMember(Name="brand_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand_id")]
    public int? BrandId { get; set; }

    /// <summary>
    /// Current inventory level of the product. Simple inventory tracking must be enabled (See the `inventory_tracking` field) for this to take any effect. 
    /// </summary>
    /// <value>Current inventory level of the product. Simple inventory tracking must be enabled (See the `inventory_tracking` field) for this to take any effect. </value>
    [DataMember(Name="inventory_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_level")]
    public int? InventoryLevel { get; set; }

    /// <summary>
    /// Inventory warning level for the product. When the product's inventory level drops below the warning level, the store owner will be informed. Simple inventory tracking must be enabled (see the `inventory_tracking` field) for this to take any effect. 
    /// </summary>
    /// <value>Inventory warning level for the product. When the product's inventory level drops below the warning level, the store owner will be informed. Simple inventory tracking must be enabled (see the `inventory_tracking` field) for this to take any effect. </value>
    [DataMember(Name="inventory_warning_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_warning_level")]
    public int? InventoryWarningLevel { get; set; }

    /// <summary>
    /// The type of inventory tracking for the product. Values are: `none` - inventory levels will not be tracked; `product` - inventory levels will be tracked using the `inventory_level` and `inventory_warning_level` fields; `variant` - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. 
    /// </summary>
    /// <value>The type of inventory tracking for the product. Values are: `none` - inventory levels will not be tracked; `product` - inventory levels will be tracked using the `inventory_level` and `inventory_warning_level` fields; `variant` - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. </value>
    [DataMember(Name="inventory_tracking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_tracking")]
    public string InventoryTracking { get; set; }

    /// <summary>
    /// A fixed shipping cost for the product. If defined, this value will be used during checkout instead of normal shipping-cost calculation. 
    /// </summary>
    /// <value>A fixed shipping cost for the product. If defined, this value will be used during checkout instead of normal shipping-cost calculation. </value>
    [DataMember(Name="fixed_cost_shipping_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed_cost_shipping_price")]
    public float? FixedCostShippingPrice { get; set; }

    /// <summary>
    /// Flag used to indicate whether the product has free shipping. If `true`, the shipping cost for the product will be zero. 
    /// </summary>
    /// <value>Flag used to indicate whether the product has free shipping. If `true`, the shipping cost for the product will be zero. </value>
    [DataMember(Name="is_free_shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_free_shipping")]
    public bool? IsFreeShipping { get; set; }

    /// <summary>
    /// Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the product will be displayed. If `false`, the product will be hidden from view. 
    /// </summary>
    /// <value>Flag to determine whether the product should be displayed to customers browsing the store. If `true`, the product will be displayed. If `false`, the product will be hidden from view. </value>
    [DataMember(Name="is_visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_visible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// Flag to determine whether the product should be included in the `featured products` panel when viewing the store. 
    /// </summary>
    /// <value>Flag to determine whether the product should be included in the `featured products` panel when viewing the store. </value>
    [DataMember(Name="is_featured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_featured")]
    public bool? IsFeatured { get; set; }

    /// <summary>
    /// An array of IDs for the related products. 
    /// </summary>
    /// <value>An array of IDs for the related products. </value>
    [DataMember(Name="related_products", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "related_products")]
    public List<int?> RelatedProducts { get; set; }

    /// <summary>
    /// Warranty information displayed on the product page. Can include HTML formatting. 
    /// </summary>
    /// <value>Warranty information displayed on the product page. Can include HTML formatting. </value>
    [DataMember(Name="warranty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warranty")]
    public string Warranty { get; set; }

    /// <summary>
    /// The BIN picking number for the product. 
    /// </summary>
    /// <value>The BIN picking number for the product. </value>
    [DataMember(Name="bin_picking_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin_picking_number")]
    public string BinPickingNumber { get; set; }

    /// <summary>
    /// The layout template file used to render this product category. This field is writable only for stores with a Blueprint theme applied. 
    /// </summary>
    /// <value>The layout template file used to render this product category. This field is writable only for stores with a Blueprint theme applied. </value>
    [DataMember(Name="layout_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "layout_file")]
    public string LayoutFile { get; set; }

    /// <summary>
    /// The product UPC code, which is used in feeds for shopping comparison sites and external channel integrations. 
    /// </summary>
    /// <value>The product UPC code, which is used in feeds for shopping comparison sites and external channel integrations. </value>
    [DataMember(Name="upc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upc")]
    public string Upc { get; set; }

    /// <summary>
    /// A comma-separated list of keywords that can be used to locate the product when searching the store. 
    /// </summary>
    /// <value>A comma-separated list of keywords that can be used to locate the product when searching the store. </value>
    [DataMember(Name="search_keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "search_keywords")]
    public string SearchKeywords { get; set; }

    /// <summary>
    /// Availability of the product. Availability options are: `available` - the product can be purchased on the storefront; `disabled` - the product is listed in the storefront, but cannot be purchased; `preorder` - the product is listed for pre-orders. 
    /// </summary>
    /// <value>Availability of the product. Availability options are: `available` - the product can be purchased on the storefront; `disabled` - the product is listed in the storefront, but cannot be purchased; `preorder` - the product is listed for pre-orders. </value>
    [DataMember(Name="availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability")]
    public string Availability { get; set; }

    /// <summary>
    /// Availability text displayed on the checkout page, under the product title. Tells the customer how long it will normally take to ship this product, such as: 'Usually ships in 24 hours.' 
    /// </summary>
    /// <value>Availability text displayed on the checkout page, under the product title. Tells the customer how long it will normally take to ship this product, such as: 'Usually ships in 24 hours.' </value>
    [DataMember(Name="availability_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability_description")]
    public string AvailabilityDescription { get; set; }

    /// <summary>
    /// Type of gift-wrapping options. Values: `any` - allow any gift-wrapping options in the store; `none` - disallow gift-wrapping on the product; `list` – provide a list of IDs in the `gift_wrapping_options_list` field. 
    /// </summary>
    /// <value>Type of gift-wrapping options. Values: `any` - allow any gift-wrapping options in the store; `none` - disallow gift-wrapping on the product; `list` – provide a list of IDs in the `gift_wrapping_options_list` field. </value>
    [DataMember(Name="gift_wrapping_options_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gift_wrapping_options_type")]
    public string GiftWrappingOptionsType { get; set; }

    /// <summary>
    /// A list of gift-wrapping option IDs. 
    /// </summary>
    /// <value>A list of gift-wrapping option IDs. </value>
    [DataMember(Name="gift_wrapping_options_list", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gift_wrapping_options_list")]
    public List<int?> GiftWrappingOptionsList { get; set; }

    /// <summary>
    /// Priority to give this product when included in product lists on category pages and in search results. Lower integers will place the product closer to the top of the results. 
    /// </summary>
    /// <value>Priority to give this product when included in product lists on category pages and in search results. Lower integers will place the product closer to the top of the results. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// The product condition. Will be shown on the product page if the `is_condition_shown` field's value is `true`. Possible values: `New`, `Used`, `Refurbished`. 
    /// </summary>
    /// <value>The product condition. Will be shown on the product page if the `is_condition_shown` field's value is `true`. Possible values: `New`, `Used`, `Refurbished`. </value>
    [DataMember(Name="condition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "condition")]
    public string Condition { get; set; }

    /// <summary>
    /// Flag used to determine whether the product condition is shown to the customer on the product page. 
    /// </summary>
    /// <value>Flag used to determine whether the product condition is shown to the customer on the product page. </value>
    [DataMember(Name="is_condition_shown", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_condition_shown")]
    public bool? IsConditionShown { get; set; }

    /// <summary>
    /// The minimum quantity an order must contain, to be eligible to purchase this product. 
    /// </summary>
    /// <value>The minimum quantity an order must contain, to be eligible to purchase this product. </value>
    [DataMember(Name="order_quantity_minimum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_quantity_minimum")]
    public int? OrderQuantityMinimum { get; set; }

    /// <summary>
    /// The maximum quantity an order can contain when purchasing the product. 
    /// </summary>
    /// <value>The maximum quantity an order can contain when purchasing the product. </value>
    [DataMember(Name="order_quantity_maximum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_quantity_maximum")]
    public int? OrderQuantityMaximum { get; set; }

    /// <summary>
    /// Custom title for the product page. If not defined, the product name will be used as the meta title. 
    /// </summary>
    /// <value>Custom title for the product page. If not defined, the product name will be used as the meta title. </value>
    [DataMember(Name="page_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page_title")]
    public string PageTitle { get; set; }

    /// <summary>
    /// Custom meta keywords for the product page. If not defined, the store's default keywords will be used. 
    /// </summary>
    /// <value>Custom meta keywords for the product page. If not defined, the store's default keywords will be used. </value>
    [DataMember(Name="meta_keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta_keywords")]
    public List<string> MetaKeywords { get; set; }

    /// <summary>
    /// Custom meta description for the product page. If not defined, the store's default meta description will be used. 
    /// </summary>
    /// <value>Custom meta description for the product page. If not defined, the store's default meta description will be used. </value>
    [DataMember(Name="meta_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta_description")]
    public string MetaDescription { get; set; }

    /// <summary>
    /// The number of times the product has been viewed. 
    /// </summary>
    /// <value>The number of times the product has been viewed. </value>
    [DataMember(Name="view_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view_count")]
    public int? ViewCount { get; set; }

    /// <summary>
    /// Pre-order release date. See the `availability` field for details on setting a product's availability to accept pre-orders. 
    /// </summary>
    /// <value>Pre-order release date. See the `availability` field for details on setting a product's availability to accept pre-orders. </value>
    [DataMember(Name="preorder_release_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preorder_release_date")]
    public DateTime? PreorderReleaseDate { get; set; }

    /// <summary>
    /// Custom expected-date message to display on the product page. If undefined, the message defaults to the storewide setting. Can contain the `%%DATE%%` placeholder, which will be substituted for the release date. 
    /// </summary>
    /// <value>Custom expected-date message to display on the product page. If undefined, the message defaults to the storewide setting. Can contain the `%%DATE%%` placeholder, which will be substituted for the release date. </value>
    [DataMember(Name="preorder_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preorder_message")]
    public string PreorderMessage { get; set; }

    /// <summary>
    /// If set to true then on the preorder release date the preorder status will automatically be removed.   If set to false, then on the release date the preorder status **will not** be removed. It will need to be changed manually either in the control panel or using the API. Using the API set `availability` to `available`. 
    /// </summary>
    /// <value>If set to true then on the preorder release date the preorder status will automatically be removed.   If set to false, then on the release date the preorder status **will not** be removed. It will need to be changed manually either in the control panel or using the API. Using the API set `availability` to `available`. </value>
    [DataMember(Name="is_preorder_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_preorder_only")]
    public bool? IsPreorderOnly { get; set; }

    /// <summary>
    /// False by default, indicating that this product's price should be shown on the product page. If set to `true`, the price is hidden. (NOTE: To successfully set `is_price_hidden` to `true`, the `availability` value must be `disabled`.) 
    /// </summary>
    /// <value>False by default, indicating that this product's price should be shown on the product page. If set to `true`, the price is hidden. (NOTE: To successfully set `is_price_hidden` to `true`, the `availability` value must be `disabled`.) </value>
    [DataMember(Name="is_price_hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_price_hidden")]
    public bool? IsPriceHidden { get; set; }

    /// <summary>
    /// By default, an empty string. If `is_price_hidden` is `true`, the value of `price_hidden_label` is displayed instead of the price. (NOTE: To successfully set a non-empty string value with `is_price_hidden` set to `true`, the `availability` value must be `disabled`.) 
    /// </summary>
    /// <value>By default, an empty string. If `is_price_hidden` is `true`, the value of `price_hidden_label` is displayed instead of the price. (NOTE: To successfully set a non-empty string value with `is_price_hidden` set to `true`, the `availability` value must be `disabled`.) </value>
    [DataMember(Name="price_hidden_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_hidden_label")]
    public string PriceHiddenLabel { get; set; }

    /// <summary>
    /// Gets or Sets CustomUrl
    /// </summary>
    [DataMember(Name="custom_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_url")]
    public CustomUrlFull1 CustomUrl { get; set; }

    /// <summary>
    /// Type of product, defaults to `product`. 
    /// </summary>
    /// <value>Type of product, defaults to `product`. </value>
    [DataMember(Name="open_graph_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_graph_type")]
    public string OpenGraphType { get; set; }

    /// <summary>
    /// Title of the product, if not specified the product name will be used instead. 
    /// </summary>
    /// <value>Title of the product, if not specified the product name will be used instead. </value>
    [DataMember(Name="open_graph_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_graph_title")]
    public string OpenGraphTitle { get; set; }

    /// <summary>
    /// Description to use for the product, if not specified then the meta_description will be used instead. 
    /// </summary>
    /// <value>Description to use for the product, if not specified then the meta_description will be used instead. </value>
    [DataMember(Name="open_graph_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_graph_description")]
    public string OpenGraphDescription { get; set; }

    /// <summary>
    /// Flag to determine if product description or open graph description is used. 
    /// </summary>
    /// <value>Flag to determine if product description or open graph description is used. </value>
    [DataMember(Name="open_graph_use_meta_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_graph_use_meta_description")]
    public bool? OpenGraphUseMetaDescription { get; set; }

    /// <summary>
    /// Flag to determine if product name or open graph name is used. 
    /// </summary>
    /// <value>Flag to determine if product name or open graph name is used. </value>
    [DataMember(Name="open_graph_use_product_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_graph_use_product_name")]
    public bool? OpenGraphUseProductName { get; set; }

    /// <summary>
    /// Flag to determine if product image or open graph image is used. 
    /// </summary>
    /// <value>Flag to determine if product image or open graph image is used. </value>
    [DataMember(Name="open_graph_use_image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_graph_use_image")]
    public bool? OpenGraphUseImage { get; set; }

    /// <summary>
    /// The brand can be created during a product PUT or POST request. If the brand already exists then the product will be added. If not the brand will be created and the product added. If using `brand_name` it performs a fuzzy match and adds the brand. eg. \"Common Good\" and \"Common good\" are the same. Brand name does not return as part of a product response. Only the `brand_id`.
    /// </summary>
    /// <value>The brand can be created during a product PUT or POST request. If the brand already exists then the product will be added. If not the brand will be created and the product added. If using `brand_name` it performs a fuzzy match and adds the brand. eg. \"Common Good\" and \"Common good\" are the same. Brand name does not return as part of a product response. Only the `brand_id`.</value>
    [DataMember(Name="brand_name or brand_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand_name or brand_id")]
    public string BrandNameOrBrandId { get; set; }

    /// <summary>
    /// Global Trade Item Number
    /// </summary>
    /// <value>Global Trade Item Number</value>
    [DataMember(Name="gtin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gtin")]
    public string Gtin { get; set; }

    /// <summary>
    /// Manufacturer Part Number
    /// </summary>
    /// <value>Manufacturer Part Number</value>
    [DataMember(Name="mpn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mpn")]
    public string Mpn { get; set; }

    /// <summary>
    /// The total rating for the product. 
    /// </summary>
    /// <value>The total rating for the product. </value>
    [DataMember(Name="reviews_rating_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviews_rating_sum")]
    public int? ReviewsRatingSum { get; set; }

    /// <summary>
    /// The number of times the product has been rated. 
    /// </summary>
    /// <value>The number of times the product has been rated. </value>
    [DataMember(Name="reviews_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviews_count")]
    public int? ReviewsCount { get; set; }

    /// <summary>
    /// The total quantity of this product sold. 
    /// </summary>
    /// <value>The total quantity of this product sold. </value>
    [DataMember(Name="total_sold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_sold")]
    public int? TotalSold { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public List<object> CustomFields { get; set; }

    /// <summary>
    /// Gets or Sets BulkPricingRules
    /// </summary>
    [DataMember(Name="bulk_pricing_rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulk_pricing_rules")]
    public List<BulkPricingRuleFull1> BulkPricingRules { get; set; }

    /// <summary>
    /// Gets or Sets Variants
    /// </summary>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variants")]
    public List<object> Variants { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<object> Images { get; set; }

    /// <summary>
    /// Common ProductImage properties.
    /// </summary>
    /// <value>Common ProductImage properties.</value>
    [DataMember(Name="primary_image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary_image")]
    public object PrimaryImage { get; set; }

    /// <summary>
    /// Gets or Sets Videos
    /// </summary>
    [DataMember(Name="videos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "videos")]
    public List<object> Videos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductBase1 {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Depth: ").Append(Depth).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
      sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
      sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
      sb.Append("  TaxClassId: ").Append(TaxClassId).Append("\n");
      sb.Append("  ProductTaxCode: ").Append(ProductTaxCode).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  BrandId: ").Append(BrandId).Append("\n");
      sb.Append("  InventoryLevel: ").Append(InventoryLevel).Append("\n");
      sb.Append("  InventoryWarningLevel: ").Append(InventoryWarningLevel).Append("\n");
      sb.Append("  InventoryTracking: ").Append(InventoryTracking).Append("\n");
      sb.Append("  FixedCostShippingPrice: ").Append(FixedCostShippingPrice).Append("\n");
      sb.Append("  IsFreeShipping: ").Append(IsFreeShipping).Append("\n");
      sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
      sb.Append("  IsFeatured: ").Append(IsFeatured).Append("\n");
      sb.Append("  RelatedProducts: ").Append(RelatedProducts).Append("\n");
      sb.Append("  Warranty: ").Append(Warranty).Append("\n");
      sb.Append("  BinPickingNumber: ").Append(BinPickingNumber).Append("\n");
      sb.Append("  LayoutFile: ").Append(LayoutFile).Append("\n");
      sb.Append("  Upc: ").Append(Upc).Append("\n");
      sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
      sb.Append("  Availability: ").Append(Availability).Append("\n");
      sb.Append("  AvailabilityDescription: ").Append(AvailabilityDescription).Append("\n");
      sb.Append("  GiftWrappingOptionsType: ").Append(GiftWrappingOptionsType).Append("\n");
      sb.Append("  GiftWrappingOptionsList: ").Append(GiftWrappingOptionsList).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Condition: ").Append(Condition).Append("\n");
      sb.Append("  IsConditionShown: ").Append(IsConditionShown).Append("\n");
      sb.Append("  OrderQuantityMinimum: ").Append(OrderQuantityMinimum).Append("\n");
      sb.Append("  OrderQuantityMaximum: ").Append(OrderQuantityMaximum).Append("\n");
      sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
      sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
      sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
      sb.Append("  ViewCount: ").Append(ViewCount).Append("\n");
      sb.Append("  PreorderReleaseDate: ").Append(PreorderReleaseDate).Append("\n");
      sb.Append("  PreorderMessage: ").Append(PreorderMessage).Append("\n");
      sb.Append("  IsPreorderOnly: ").Append(IsPreorderOnly).Append("\n");
      sb.Append("  IsPriceHidden: ").Append(IsPriceHidden).Append("\n");
      sb.Append("  PriceHiddenLabel: ").Append(PriceHiddenLabel).Append("\n");
      sb.Append("  CustomUrl: ").Append(CustomUrl).Append("\n");
      sb.Append("  OpenGraphType: ").Append(OpenGraphType).Append("\n");
      sb.Append("  OpenGraphTitle: ").Append(OpenGraphTitle).Append("\n");
      sb.Append("  OpenGraphDescription: ").Append(OpenGraphDescription).Append("\n");
      sb.Append("  OpenGraphUseMetaDescription: ").Append(OpenGraphUseMetaDescription).Append("\n");
      sb.Append("  OpenGraphUseProductName: ").Append(OpenGraphUseProductName).Append("\n");
      sb.Append("  OpenGraphUseImage: ").Append(OpenGraphUseImage).Append("\n");
      sb.Append("  BrandNameOrBrandId: ").Append(BrandNameOrBrandId).Append("\n");
      sb.Append("  Gtin: ").Append(Gtin).Append("\n");
      sb.Append("  Mpn: ").Append(Mpn).Append("\n");
      sb.Append("  ReviewsRatingSum: ").Append(ReviewsRatingSum).Append("\n");
      sb.Append("  ReviewsCount: ").Append(ReviewsCount).Append("\n");
      sb.Append("  TotalSold: ").Append(TotalSold).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
      sb.Append("  BulkPricingRules: ").Append(BulkPricingRules).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  PrimaryImage: ").Append(PrimaryImage).Append("\n");
      sb.Append("  Videos: ").Append(Videos).Append("\n");
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
