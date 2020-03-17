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
  public class OrderShipmentPost2 {
    /// <summary>
    /// ID of the desired `shipping_address` associated with the shipment.
    /// </summary>
    /// <value>ID of the desired `shipping_address` associated with the shipment.</value>
    [DataMember(Name="order_address_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_address_id")]
    public int? OrderAddressId { get; set; }

    /// <summary>
    /// Tracking number of the shipment.
    /// </summary>
    /// <value>Tracking number of the shipment.</value>
    [DataMember(Name="tracking_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Extra detail to describe the shipment, with values like: Standard, My Custom Shipping Method Name, etc. Can also be used for live quotes from some shipping providers.
    /// </summary>
    /// <value>Extra detail to describe the shipment, with values like: Standard, My Custom Shipping Method Name, etc. Can also be used for live quotes from some shipping providers.</value>
    [DataMember(Name="shipping_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_method")]
    public string ShippingMethod { get; set; }

    /// <summary>
    /// Enum of the BigCommerce shipping-carrier integration/module. (Note: This property should be included in a POST request to create a shipment object. If it is omitted from the request, the property’s value will default to custom, and no tracking link will be generated in the email. To avoid this behavior, you can pass the property as an empty string.)
    /// </summary>
    /// <value>Enum of the BigCommerce shipping-carrier integration/module. (Note: This property should be included in a POST request to create a shipment object. If it is omitted from the request, the property’s value will default to custom, and no tracking link will be generated in the email. To avoid this behavior, you can pass the property as an empty string.)</value>
    [DataMember(Name="shipping_provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_provider")]
    public string ShippingProvider { get; set; }

    /// <summary>
    /// Optional, but if you include it, its value must refer/map to the same carrier service as the `shipping_provider` value.
    /// </summary>
    /// <value>Optional, but if you include it, its value must refer/map to the same carrier service as the `shipping_provider` value.</value>
    [DataMember(Name="tracking_carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_carrier")]
    public string TrackingCarrier { get; set; }

    /// <summary>
    /// Comments the shipper wishes to add.
    /// </summary>
    /// <value>Comments the shipper wishes to add.</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }

    /// <summary>
    /// The items in the shipment. This object has the following members, all integer: order_product_id (required), quantity (required), product_id (read-only). A sample items value might be: [ {\"order_product_id\":16,\"product_id\": 0,\"quantity\":2} ]
    /// </summary>
    /// <value>The items in the shipment. This object has the following members, all integer: order_product_id (required), quantity (required), product_id (read-only). A sample items value might be: [ {\"order_product_id\":16,\"product_id\": 0,\"quantity\":2} ]</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<OrdersorderIdshipmentsItems> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderShipmentPost2 {\n");
      sb.Append("  OrderAddressId: ").Append(OrderAddressId).Append("\n");
      sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
      sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
      sb.Append("  ShippingProvider: ").Append(ShippingProvider).Append("\n");
      sb.Append("  TrackingCarrier: ").Append(TrackingCarrier).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
