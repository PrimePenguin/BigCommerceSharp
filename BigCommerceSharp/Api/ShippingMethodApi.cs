using System;
using System.Collections.Generic;
using BigCommerceSharp.Client;
using BigCommerceSharp.Model;
using RestSharp;

namespace BigCommerceSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShippingMethodApi
    {
        /// <summary>
        /// Create a Shipping Method Creates a *Shipping Method* within a shipping zone. Real Time Carrier Connections are also supported by this endpoint.   ## Carrier Configurations – Current  This section provides a sample request and a carrier-specific object/property model, for each supported carrier.   ### USPS by Endicia  #### Sample Request   &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;USPS by Endicia\&quot;,     \&quot;type\&quot;: \&quot;endicia\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot; : [\&quot;PriorityExpress\&quot;,\&quot;Priority\&quot;, \&quot;PriorityMailExpressInternational\&quot;],    \&quot;packaging_type\&quot; : \&quot;LargeFlatRateBox\&quot;,             \&quot;show_transit_time\&quot; : true         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  ### USPS by Endicia Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | PriorityExpress &lt;br&gt; PriorityMailExpressInternational &lt;br&gt; FirstClassPackageInternationalService &lt;br&gt; Priority &lt;br&gt; PriorityMailInternational &lt;br&gt; First &lt;br&gt; ParcelSelect &lt;br&gt; MediaMail | | packaging_type | array | FlatRateLegalEnvelope &lt;br&gt; FlatRatePaddedEnvelope &lt;br&gt; Parcel &lt;br&gt; SmallFlatRateBox &lt;br&gt; MediumFlatRateBox &lt;br&gt; LargeFlatRateBox &lt;br&gt; FlatRateEnvelope &lt;br&gt; RegionalRateBoxA &lt;br&gt; RegionalRateBoxB | |show_transit_time | boolean | true &lt;br&gt; false |   ### FedEx  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;FEDEX\&quot;,     \&quot;type\&quot;: \&quot;fedex\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;PRIORITY_OVERNIGHT\&quot;,     \&quot;FEDEX_2_DAY\&quot;             ],             \&quot;dropoff_type\&quot;: \&quot;REGULAR_PICKUP\&quot;,             \&quot;packaging_type\&quot;: \&quot;FEDEX_ENVELOPE\&quot;,             \&quot;packing_method\&quot;: \&quot;SEPARATE\&quot;,             \&quot;rate_type\&quot;: \&quot;NONE\&quot;,             \&quot;include_package_value\&quot;: true,             \&quot;destination_type\&quot;: \&quot;residential\&quot;         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### FedEx Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | PRIORITY_OVERNIGHT &lt;br&gt; STANDARD_OVERNIGHT &lt;br&gt; FIRST_OVERNIGHT &lt;br&gt; FEDEX_2_DAY &lt;br&gt; FEDEX_EXPRESS_SAVER &lt;br&gt; INTERNATIONAL_PRIORITY &lt;br&gt; INTERNATIONAL_ECONOMY &lt;br&gt; INTERNATIONAL_FIRST &lt;br&gt; FEDEX_1_DAY_FREIGHT &lt;br&gt; FEDEX_2_DAY_FREIGHT &lt;br&gt; FEDEX_3_DAY_FREIGHT &lt;br&gt; FEDEX_GROUND &lt;br&gt; GROUND_HOME_DELIVERY &lt;br&gt; INTERNATIONAL_PRIORITY_FREIGHT &lt;br&gt; INTERNATIONAL_ECONOMY_FREIGHT &lt;br&gt; EUROPE_FIRST_INTERNATIONAL_PRIORITY | | dropoff_type | string | REGULAR_PICKUP &lt;br&gt; REQUEST_COURIER &lt;br&gt; DROP_BOX &lt;br&gt; BUSINESS_SERVICE_CENTER &lt;br&gt; STATION | | packaging_type | string | FEDEX_ENVELOPE  &lt;br&gt; FEDEX_PAK &lt;br&gt; FEDEX_BOX &lt;br&gt; FEDEX_TUBE &lt;br&gt; FEDEX_10KG_BOX &lt;br&gt; FEDEX_25KG_BOX &lt;br&gt; YOUR_PACKAGING | | packing_method | string | SEPARATE &lt;br&gt; COMBINED | | rate_type | string | NONE &lt;br&gt; LIST | | include_package_value | boolean | true &lt;br&gt; false | | destination_type | string | residential &lt;br&gt; business |  ### UPS Ready  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;UPS ready\&quot;,     \&quot;type\&quot;: \&quot;upsready\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;2nd_Day_Air\&quot;,\&quot;Standard\&quot;             ],             \&quot;packaging_type\&quot;: \&quot;21\&quot;,             \&quot;packing_method\&quot;: \&quot;separate\&quot;,             \&quot;include_package_value\&quot;: true,             \&quot;destination_type\&quot;: \&quot;residential\&quot;,             \&quot;show_transit_time\&quot; : true         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### UPS Ready Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | 2nd_Day_Air &lt;br&gt; 2nd_Day_Air_AM &lt;br&gt; 3_Day_Select &lt;br&gt; Expedited  &lt;br&gt; Express &lt;br&gt; Express_Plus &lt;br&gt; Express_Saver &lt;br&gt; Express_Early_AM &lt;br&gt; Ground &lt;br&gt; Next_Day_Air  &lt;br&gt; Next_Day_Air_Early_AM &lt;br&gt; Next_Day_Air_Saver &lt;br&gt; Saver &lt;br&gt; Standard &lt;br&gt; Today_Dedicated_Courier &lt;br&gt; Today_Express &lt;br&gt; Today_Express_Saver &lt;br&gt; Today_Intercity &lt;br&gt; Today_Standard &lt;br&gt; Worldwide_Expedited &lt;br&gt; Worldwide_Express &lt;br&gt; Worldwide_Express_Plus &lt;br&gt; Worldwide_Express_Saver &lt;br&gt; Worldwide_Saver | | destination_type | string | residential &lt;br&gt; business | | packing_method | string | separate &lt;br&gt; combined | | packaging_type | string (only codes allowed) | 21: UPS® Express Box &lt;br&gt; 24: UPS® 25 KG Box &lt;br&gt; 25: UPS® 10 KG Box &lt;br&gt; 30: Pallet &lt;br&gt; 01: UPS® Letter &lt;br&gt; 02: Customer Supplied Package &lt;br&gt; 03: Tube &lt;br&gt; 04: PAK &lt;br&gt; 2a: Small Express Box &lt;br&gt; 2b: Medium Express Box &lt;br&gt; 2c: Large Express Box | | include_package_value | boolean | true &lt;br&gt; false | | show_transit_time | boolean | true &lt;br&gt; false |  ### Canada Post  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Canada Post\&quot;,     \&quot;type\&quot;: \&quot;canadapost\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;DOM.RP\&quot;,\&quot;DOM.EP\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Canada Post Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | DOM.RP &lt;br&gt; DOM.EP &lt;br&gt; DOM.XP &lt;br&gt; DOM.XP.CERT &lt;br&gt; DOM.PC DOM.LIB &lt;br&gt; USA.EP &lt;br&gt; USA.PW.ENV &lt;br&gt; USA.PW.PAK &lt;br&gt; USA.PW.PARCEL &lt;br&gt; USA.SP.AIR &lt;br&gt; USA.TP &lt;br&gt; USA.TP.LVM &lt;br&gt; USA.XP &lt;br&gt; INT.XP &lt;br&gt; INT.IP.AIR &lt;br&gt; INT.IP.SURF &lt;br&gt; INT.PW.ENV &lt;br&gt; INT.PW.PAK &lt;br&gt; INT.PW.PARCEL &lt;br&gt; INT.SP.AIR &lt;br&gt; INT.SP.SURF &lt;br&gt; INT.TP |  ### Australia Post  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Australia Post\&quot;,     \&quot;type\&quot;: \&quot;auspost\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;AUS_PARCEL_REGULAR\&quot;,     \&quot;AUS_PARCEL_EXPRESS\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Australia Post Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | AUS_LETTER_REGULAR_SMALL &lt;br&gt; AUS_LETTER_REGULAR_Large &lt;br&gt; AUS_LETTER_EXPRESS_SMALL &lt;br&gt; AUS_LETTER_EXPRESS_MEDIUM &lt;br&gt; AUS_LETTER_EXPRESS_LARGE &lt;br&gt; AUS_PARCEL_REGULAR &lt;br&gt; AUS_PARCEL_REGULAR_SATCHEL_500G &lt;br&gt; AUS_PARCEL_REGULAR_SATCHEL_3KG &lt;br&gt; AUS_PARCEL_REGULAR_SATCHEL_5KG &lt;br&gt; AUS_PARCEL_EXPRESS &lt;br&gt; AUS_PARCEL_EXPRESS_SATCHEL_500G &lt;br&gt; AUS_PARCEL_EXPRESS_SATCHEL_3KG &lt;br&gt; AUS_PARCEL_EXPRESS_SATCHEL_5KG &lt;br&gt; AUS_PARCEL_COURIER &lt;br&gt; AUS_PARCEL_COURIER_SATCHEL_MEDIUM &lt;br&gt; INT_PARCEL_COR_OWN_PACKAGING &lt;br&gt; INT_PARCEL_EXP_OWN_PACKAGING &lt;br&gt; INT_PARCEL_STD_OWN_PACKAGING &lt;br&gt; INT_PARCEL_AIR_OWN_PACKAGING &lt;br&gt; INT_PARCEL_SEA_OWN_PACKAGING |  ### Royal Mail  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Royal Mail\&quot;,     \&quot;type\&quot;: \&quot;royalmail\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;StandardFirstClass\&quot;,     \&quot;StandardSecondClass\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Royal Mail Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | SpecialDelivery1pm &lt;br&gt; SpecialDelivery9am &lt;br&gt; SpecialDelivery1pmSaturday &lt;br&gt; SpecialDelivery9amSaturday &lt;br&gt; SignedForFirstClass &lt;br&gt; SignedForSecondClass &lt;br&gt; Express9 &lt;br&gt; Express10 &lt;br&gt; ExpressAM &lt;br&gt; Express24 &lt;br&gt; Express48 &lt;br&gt; StandardFirstClass &lt;br&gt; StandardSecondClass &lt;br&gt; InternationalStandard &lt;br&gt; InternationalTracked &lt;br&gt; InternationalEconomy |  ### Zoom2U  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Zoom2U\&quot;,     \&quot;type\&quot;: \&quot;zoom2u\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;3_hour\&quot;,     \&quot;Same_day\&quot;,     \&quot;VIP\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Zoom2U Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | 3_hour &lt;br&gt; Same_day &lt;br&gt; VIP|   ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,  \&quot;type\&quot;: \&quot;perorder\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 7  } }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,  \&quot;type\&quot;: \&quot;peritem\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 8  } }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Rate per Weight\&quot;,  \&quot;type\&quot;: \&quot;weight\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 40,     \&quot;shipping_cost\&quot;: 12    }   ]  } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Per Total or Free\&quot;,  \&quot;type\&quot;: \&quot;total\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;include_order_total_taxes\&quot;: 0,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 5,     \&quot;shipping_cost\&quot;: 5    },    {     \&quot;lower_limit\&quot;: 5,     \&quot;upper_limit\&quot;: 10,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 10,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 10    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 49.99,     \&quot;shipping_cost\&quot;: 15    },    {     \&quot;lower_limit\&quot;: 50,     \&quot;upper_limit\&quot;: 100000,     \&quot;shipping_cost\&quot;: 0    }          ]  } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | | - | - | - | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;lower_limit\&quot;: 0,  \&quot;upper_limit\&quot;: 20,  \&quot;shipping_cost\&quot;: 8 } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingMethodFull1</returns>
        ShippingMethodFull1 CreateAShippingMethod(int? zoneId, string accept, string contentType, ShippingMethodBase1 body);
        /// <summary>
        /// Delete a Shipping Method Deletes an *Shipping Method*. Real Time Carrier Connections can also be deleted.
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="methodId">Id of the shipping method within the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteAShippingMethod(int? zoneId, int? methodId, string accept, string contentType);
        /// <summary>
        /// Get a Shipping Method Returns a single *Shipping Method* in a zone. Real Time Carrier Connections are also supported by this endpoint.    ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,     \&quot;type\&quot;: \&quot;perorder\&quot;,     \&quot;settings\&quot;: {         \&quot;rate\&quot;: 7 }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,     \&quot;type\&quot;: \&quot;peritem\&quot;,     \&quot;settings\&quot;: {         \&quot;rate\&quot;: 8 }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Rate per Weight\&quot;,     \&quot;type\&quot;: \&quot;weight\&quot;,     \&quot;settings\&quot;: {         \&quot;default_cost\&quot;: 12,         \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,         \&quot;range\&quot;: [             {                 \&quot;lower_limit\&quot;: 0,                 \&quot;upper_limit\&quot;: 20,                 \&quot;shipping_cost\&quot;: 8             },             {                 \&quot;lower_limit\&quot;: 20,                 \&quot;upper_limit\&quot;: 40,                 \&quot;shipping_cost\&quot;: 12             }         ]     } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Per Total or Free\&quot;,     \&quot;type\&quot;: \&quot;total\&quot;,     \&quot;settings\&quot;: {         \&quot;default_cost\&quot;: 12,         \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,         \&quot;include_order_total_taxes\&quot;: 0,         \&quot;range\&quot;: [             {                 \&quot;lower_limit\&quot;: 0,                 \&quot;upper_limit\&quot;: 5,                 \&quot;shipping_cost\&quot;: 5             },             {                 \&quot;lower_limit\&quot;: 5,                 \&quot;upper_limit\&quot;: 10,                 \&quot;shipping_cost\&quot;: 8             },             {                 \&quot;lower_limit\&quot;: 10,                 \&quot;upper_limit\&quot;: 20,                 \&quot;shipping_cost\&quot;: 10             },             {                 \&quot;lower_limit\&quot;: 20,                 \&quot;upper_limit\&quot;: 49.99,                 \&quot;shipping_cost\&quot;: 15             },             {                 \&quot;lower_limit\&quot;: 50,                 \&quot;upper_limit\&quot;: 100000,                 \&quot;shipping_cost\&quot;: 0             }                ]     } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | | - | - | - | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;json {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 8 } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="methodId">Id of the shipping method within the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ShippingMethod1</returns>
        ShippingMethod1 GetAShippingMethod(int? zoneId, int? methodId, string accept, string contentType);
        /// <summary>
        /// Get All Shipping Methods in a Zone Returns a list of *Shipping Methods* in a zone. Default sorting is by shipping-method id, from lowest to highest.
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;ShippingMethod&gt;</returns>
        List<ShippingMethod> GetShippingMethodsZone(int? zoneId, string accept, string contentType);
        /// <summary>
        /// Update a Shipping Method Updates a *Shipping Method* in a zone. Real Time Carrier Connections are also supported by this endpoint.   **Read Only Fields** * id  ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,  \&quot;type\&quot;: \&quot;perorder\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 7  } }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,  \&quot;type\&quot;: \&quot;peritem\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 8  } }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Rate per Weight\&quot;,  \&quot;type\&quot;: \&quot;weight\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 40,     \&quot;shipping_cost\&quot;: 12    }   ]  } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Per Total or Free\&quot;,  \&quot;type\&quot;: \&quot;total\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;include_order_total_taxes\&quot;: 0,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 5,     \&quot;shipping_cost\&quot;: 5    },    {     \&quot;lower_limit\&quot;: 5,     \&quot;upper_limit\&quot;: 10,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 10,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 10    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 49.99,     \&quot;shipping_cost\&quot;: 15    },    {     \&quot;lower_limit\&quot;: 50,     \&quot;upper_limit\&quot;: 100000,     \&quot;shipping_cost\&quot;: 0    }          ]  } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | | - | - | - | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;lower_limit\&quot;: 0,  \&quot;upper_limit\&quot;: 20,  \&quot;shipping_cost\&quot;: 8 } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="methodId">Id of the shipping method within the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingMethodFull1</returns>
        ShippingMethodFull1 UpdateAShippingMethod(int? zoneId, int? methodId, string accept, string contentType, ShippingMethodBase2 body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingMethodApi : IShippingMethodApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethodApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingMethodApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethodApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingMethodApi(string basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Create a Shipping Method Creates a *Shipping Method* within a shipping zone. Real Time Carrier Connections are also supported by this endpoint.   ## Carrier Configurations – Current  This section provides a sample request and a carrier-specific object/property model, for each supported carrier.   ### USPS by Endicia  #### Sample Request   &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;USPS by Endicia\&quot;,     \&quot;type\&quot;: \&quot;endicia\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot; : [\&quot;PriorityExpress\&quot;,\&quot;Priority\&quot;, \&quot;PriorityMailExpressInternational\&quot;],    \&quot;packaging_type\&quot; : \&quot;LargeFlatRateBox\&quot;,             \&quot;show_transit_time\&quot; : true         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  ### USPS by Endicia Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | PriorityExpress &lt;br&gt; PriorityMailExpressInternational &lt;br&gt; FirstClassPackageInternationalService &lt;br&gt; Priority &lt;br&gt; PriorityMailInternational &lt;br&gt; First &lt;br&gt; ParcelSelect &lt;br&gt; MediaMail | | packaging_type | array | FlatRateLegalEnvelope &lt;br&gt; FlatRatePaddedEnvelope &lt;br&gt; Parcel &lt;br&gt; SmallFlatRateBox &lt;br&gt; MediumFlatRateBox &lt;br&gt; LargeFlatRateBox &lt;br&gt; FlatRateEnvelope &lt;br&gt; RegionalRateBoxA &lt;br&gt; RegionalRateBoxB | |show_transit_time | boolean | true &lt;br&gt; false |   ### FedEx  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;FEDEX\&quot;,     \&quot;type\&quot;: \&quot;fedex\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;PRIORITY_OVERNIGHT\&quot;,     \&quot;FEDEX_2_DAY\&quot;             ],             \&quot;dropoff_type\&quot;: \&quot;REGULAR_PICKUP\&quot;,             \&quot;packaging_type\&quot;: \&quot;FEDEX_ENVELOPE\&quot;,             \&quot;packing_method\&quot;: \&quot;SEPARATE\&quot;,             \&quot;rate_type\&quot;: \&quot;NONE\&quot;,             \&quot;include_package_value\&quot;: true,             \&quot;destination_type\&quot;: \&quot;residential\&quot;         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### FedEx Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | PRIORITY_OVERNIGHT &lt;br&gt; STANDARD_OVERNIGHT &lt;br&gt; FIRST_OVERNIGHT &lt;br&gt; FEDEX_2_DAY &lt;br&gt; FEDEX_EXPRESS_SAVER &lt;br&gt; INTERNATIONAL_PRIORITY &lt;br&gt; INTERNATIONAL_ECONOMY &lt;br&gt; INTERNATIONAL_FIRST &lt;br&gt; FEDEX_1_DAY_FREIGHT &lt;br&gt; FEDEX_2_DAY_FREIGHT &lt;br&gt; FEDEX_3_DAY_FREIGHT &lt;br&gt; FEDEX_GROUND &lt;br&gt; GROUND_HOME_DELIVERY &lt;br&gt; INTERNATIONAL_PRIORITY_FREIGHT &lt;br&gt; INTERNATIONAL_ECONOMY_FREIGHT &lt;br&gt; EUROPE_FIRST_INTERNATIONAL_PRIORITY | | dropoff_type | string | REGULAR_PICKUP &lt;br&gt; REQUEST_COURIER &lt;br&gt; DROP_BOX &lt;br&gt; BUSINESS_SERVICE_CENTER &lt;br&gt; STATION | | packaging_type | string | FEDEX_ENVELOPE  &lt;br&gt; FEDEX_PAK &lt;br&gt; FEDEX_BOX &lt;br&gt; FEDEX_TUBE &lt;br&gt; FEDEX_10KG_BOX &lt;br&gt; FEDEX_25KG_BOX &lt;br&gt; YOUR_PACKAGING | | packing_method | string | SEPARATE &lt;br&gt; COMBINED | | rate_type | string | NONE &lt;br&gt; LIST | | include_package_value | boolean | true &lt;br&gt; false | | destination_type | string | residential &lt;br&gt; business |  ### UPS Ready  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;UPS ready\&quot;,     \&quot;type\&quot;: \&quot;upsready\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;2nd_Day_Air\&quot;,\&quot;Standard\&quot;             ],             \&quot;packaging_type\&quot;: \&quot;21\&quot;,             \&quot;packing_method\&quot;: \&quot;separate\&quot;,             \&quot;include_package_value\&quot;: true,             \&quot;destination_type\&quot;: \&quot;residential\&quot;,             \&quot;show_transit_time\&quot; : true         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### UPS Ready Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | 2nd_Day_Air &lt;br&gt; 2nd_Day_Air_AM &lt;br&gt; 3_Day_Select &lt;br&gt; Expedited  &lt;br&gt; Express &lt;br&gt; Express_Plus &lt;br&gt; Express_Saver &lt;br&gt; Express_Early_AM &lt;br&gt; Ground &lt;br&gt; Next_Day_Air  &lt;br&gt; Next_Day_Air_Early_AM &lt;br&gt; Next_Day_Air_Saver &lt;br&gt; Saver &lt;br&gt; Standard &lt;br&gt; Today_Dedicated_Courier &lt;br&gt; Today_Express &lt;br&gt; Today_Express_Saver &lt;br&gt; Today_Intercity &lt;br&gt; Today_Standard &lt;br&gt; Worldwide_Expedited &lt;br&gt; Worldwide_Express &lt;br&gt; Worldwide_Express_Plus &lt;br&gt; Worldwide_Express_Saver &lt;br&gt; Worldwide_Saver | | destination_type | string | residential &lt;br&gt; business | | packing_method | string | separate &lt;br&gt; combined | | packaging_type | string (only codes allowed) | 21: UPS® Express Box &lt;br&gt; 24: UPS® 25 KG Box &lt;br&gt; 25: UPS® 10 KG Box &lt;br&gt; 30: Pallet &lt;br&gt; 01: UPS® Letter &lt;br&gt; 02: Customer Supplied Package &lt;br&gt; 03: Tube &lt;br&gt; 04: PAK &lt;br&gt; 2a: Small Express Box &lt;br&gt; 2b: Medium Express Box &lt;br&gt; 2c: Large Express Box | | include_package_value | boolean | true &lt;br&gt; false | | show_transit_time | boolean | true &lt;br&gt; false |  ### Canada Post  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Canada Post\&quot;,     \&quot;type\&quot;: \&quot;canadapost\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;DOM.RP\&quot;,\&quot;DOM.EP\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Canada Post Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | DOM.RP &lt;br&gt; DOM.EP &lt;br&gt; DOM.XP &lt;br&gt; DOM.XP.CERT &lt;br&gt; DOM.PC DOM.LIB &lt;br&gt; USA.EP &lt;br&gt; USA.PW.ENV &lt;br&gt; USA.PW.PAK &lt;br&gt; USA.PW.PARCEL &lt;br&gt; USA.SP.AIR &lt;br&gt; USA.TP &lt;br&gt; USA.TP.LVM &lt;br&gt; USA.XP &lt;br&gt; INT.XP &lt;br&gt; INT.IP.AIR &lt;br&gt; INT.IP.SURF &lt;br&gt; INT.PW.ENV &lt;br&gt; INT.PW.PAK &lt;br&gt; INT.PW.PARCEL &lt;br&gt; INT.SP.AIR &lt;br&gt; INT.SP.SURF &lt;br&gt; INT.TP |  ### Australia Post  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Australia Post\&quot;,     \&quot;type\&quot;: \&quot;auspost\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;AUS_PARCEL_REGULAR\&quot;,     \&quot;AUS_PARCEL_EXPRESS\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Australia Post Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | AUS_LETTER_REGULAR_SMALL &lt;br&gt; AUS_LETTER_REGULAR_Large &lt;br&gt; AUS_LETTER_EXPRESS_SMALL &lt;br&gt; AUS_LETTER_EXPRESS_MEDIUM &lt;br&gt; AUS_LETTER_EXPRESS_LARGE &lt;br&gt; AUS_PARCEL_REGULAR &lt;br&gt; AUS_PARCEL_REGULAR_SATCHEL_500G &lt;br&gt; AUS_PARCEL_REGULAR_SATCHEL_3KG &lt;br&gt; AUS_PARCEL_REGULAR_SATCHEL_5KG &lt;br&gt; AUS_PARCEL_EXPRESS &lt;br&gt; AUS_PARCEL_EXPRESS_SATCHEL_500G &lt;br&gt; AUS_PARCEL_EXPRESS_SATCHEL_3KG &lt;br&gt; AUS_PARCEL_EXPRESS_SATCHEL_5KG &lt;br&gt; AUS_PARCEL_COURIER &lt;br&gt; AUS_PARCEL_COURIER_SATCHEL_MEDIUM &lt;br&gt; INT_PARCEL_COR_OWN_PACKAGING &lt;br&gt; INT_PARCEL_EXP_OWN_PACKAGING &lt;br&gt; INT_PARCEL_STD_OWN_PACKAGING &lt;br&gt; INT_PARCEL_AIR_OWN_PACKAGING &lt;br&gt; INT_PARCEL_SEA_OWN_PACKAGING |  ### Royal Mail  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Royal Mail\&quot;,     \&quot;type\&quot;: \&quot;royalmail\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;StandardFirstClass\&quot;,     \&quot;StandardSecondClass\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Royal Mail Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | SpecialDelivery1pm &lt;br&gt; SpecialDelivery9am &lt;br&gt; SpecialDelivery1pmSaturday &lt;br&gt; SpecialDelivery9amSaturday &lt;br&gt; SignedForFirstClass &lt;br&gt; SignedForSecondClass &lt;br&gt; Express9 &lt;br&gt; Express10 &lt;br&gt; ExpressAM &lt;br&gt; Express24 &lt;br&gt; Express48 &lt;br&gt; StandardFirstClass &lt;br&gt; StandardSecondClass &lt;br&gt; InternationalStandard &lt;br&gt; InternationalTracked &lt;br&gt; InternationalEconomy |  ### Zoom2U  #### Sample Request  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Zoom2U\&quot;,     \&quot;type\&quot;: \&quot;zoom2u\&quot;,     \&quot;settings\&quot;: {         \&quot;carrier_options\&quot;: {             \&quot;delivery_services\&quot;: [                 \&quot;3_hour\&quot;,     \&quot;Same_day\&quot;,     \&quot;VIP\&quot;             ]         }     },     \&quot;enabled\&quot;: true } &#x60;&#x60;&#x60;  #### Zoom2U Object Properties  | Property | Type | Values | | - | - | - | | delivery_services | array | 3_hour &lt;br&gt; Same_day &lt;br&gt; VIP|   ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,  \&quot;type\&quot;: \&quot;perorder\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 7  } }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,  \&quot;type\&quot;: \&quot;peritem\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 8  } }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Rate per Weight\&quot;,  \&quot;type\&quot;: \&quot;weight\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 40,     \&quot;shipping_cost\&quot;: 12    }   ]  } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Per Total or Free\&quot;,  \&quot;type\&quot;: \&quot;total\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;include_order_total_taxes\&quot;: 0,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 5,     \&quot;shipping_cost\&quot;: 5    },    {     \&quot;lower_limit\&quot;: 5,     \&quot;upper_limit\&quot;: 10,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 10,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 10    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 49.99,     \&quot;shipping_cost\&quot;: 15    },    {     \&quot;lower_limit\&quot;: 50,     \&quot;upper_limit\&quot;: 100000,     \&quot;shipping_cost\&quot;: 0    }          ]  } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | | - | - | - | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;lower_limit\&quot;: 0,  \&quot;upper_limit\&quot;: 20,  \&quot;shipping_cost\&quot;: 8 } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingMethodFull1</returns>
        public ShippingMethodFull1 CreateAShippingMethod(int? zoneId, string accept, string contentType, ShippingMethodBase1 body)
        {

            // verify the required parameter 'zoneId' is set
            if (zoneId == null) throw new ApiException(400, "Missing required parameter 'zoneId' when calling CreateAShippingMethod");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateAShippingMethod");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateAShippingMethod");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAShippingMethod");


            var path = "/shipping/zones/{zone_id}/methods";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "zone_id" + "}", ApiClient.ParameterToString(zoneId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAShippingMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAShippingMethod: " + response.ErrorMessage, response.ErrorMessage);

            return (ShippingMethodFull1)ApiClient.Deserialize(response.Content, typeof(ShippingMethodFull1), response.Headers);
        }

        /// <summary>
        /// Delete a Shipping Method Deletes an *Shipping Method*. Real Time Carrier Connections can also be deleted.
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="methodId">Id of the shipping method within the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteAShippingMethod(int? zoneId, int? methodId, string accept, string contentType)
        {

            // verify the required parameter 'zoneId' is set
            if (zoneId == null) throw new ApiException(400, "Missing required parameter 'zoneId' when calling DeleteAShippingMethod");

            // verify the required parameter 'methodId' is set
            if (methodId == null) throw new ApiException(400, "Missing required parameter 'methodId' when calling DeleteAShippingMethod");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteAShippingMethod");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteAShippingMethod");


            var path = "/shipping/zones/{zone_id}/methods/{method_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "zone_id" + "}", ApiClient.ParameterToString(zoneId));
            path = path.Replace("{" + "method_id" + "}", ApiClient.ParameterToString(methodId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAShippingMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAShippingMethod: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get a Shipping Method Returns a single *Shipping Method* in a zone. Real Time Carrier Connections are also supported by this endpoint.    ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,     \&quot;type\&quot;: \&quot;perorder\&quot;,     \&quot;settings\&quot;: {         \&quot;rate\&quot;: 7 }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,     \&quot;type\&quot;: \&quot;peritem\&quot;,     \&quot;settings\&quot;: {         \&quot;rate\&quot;: 8 }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Rate per Weight\&quot;,     \&quot;type\&quot;: \&quot;weight\&quot;,     \&quot;settings\&quot;: {         \&quot;default_cost\&quot;: 12,         \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,         \&quot;range\&quot;: [             {                 \&quot;lower_limit\&quot;: 0,                 \&quot;upper_limit\&quot;: 20,                 \&quot;shipping_cost\&quot;: 8             },             {                 \&quot;lower_limit\&quot;: 20,                 \&quot;upper_limit\&quot;: 40,                 \&quot;shipping_cost\&quot;: 12             }         ]     } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60;json {     \&quot;name\&quot;: \&quot;Per Total or Free\&quot;,     \&quot;type\&quot;: \&quot;total\&quot;,     \&quot;settings\&quot;: {         \&quot;default_cost\&quot;: 12,         \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,         \&quot;include_order_total_taxes\&quot;: 0,         \&quot;range\&quot;: [             {                 \&quot;lower_limit\&quot;: 0,                 \&quot;upper_limit\&quot;: 5,                 \&quot;shipping_cost\&quot;: 5             },             {                 \&quot;lower_limit\&quot;: 5,                 \&quot;upper_limit\&quot;: 10,                 \&quot;shipping_cost\&quot;: 8             },             {                 \&quot;lower_limit\&quot;: 10,                 \&quot;upper_limit\&quot;: 20,                 \&quot;shipping_cost\&quot;: 10             },             {                 \&quot;lower_limit\&quot;: 20,                 \&quot;upper_limit\&quot;: 49.99,                 \&quot;shipping_cost\&quot;: 15             },             {                 \&quot;lower_limit\&quot;: 50,                 \&quot;upper_limit\&quot;: 100000,                 \&quot;shipping_cost\&quot;: 0             }                ]     } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | | - | - | - | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;json {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 8 } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="methodId">Id of the shipping method within the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ShippingMethod1</returns>
        public ShippingMethod1 GetAShippingMethod(int? zoneId, int? methodId, string accept, string contentType)
        {

            // verify the required parameter 'zoneId' is set
            if (zoneId == null) throw new ApiException(400, "Missing required parameter 'zoneId' when calling GetAShippingMethod");

            // verify the required parameter 'methodId' is set
            if (methodId == null) throw new ApiException(400, "Missing required parameter 'methodId' when calling GetAShippingMethod");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAShippingMethod");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAShippingMethod");


            var path = "/shipping/zones/{zone_id}/methods/{method_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "zone_id" + "}", ApiClient.ParameterToString(zoneId));
            path = path.Replace("{" + "method_id" + "}", ApiClient.ParameterToString(methodId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAShippingMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAShippingMethod: " + response.ErrorMessage, response.ErrorMessage);

            return (ShippingMethod1)ApiClient.Deserialize(response.Content, typeof(ShippingMethod1), response.Headers);
        }

        /// <summary>
        /// Get All Shipping Methods in a Zone Returns a list of *Shipping Methods* in a zone. Default sorting is by shipping-method id, from lowest to highest.
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;ShippingMethod&gt;</returns>
        public List<ShippingMethod> GetShippingMethodsZone(int? zoneId, string accept, string contentType)
        {

            // verify the required parameter 'zoneId' is set
            if (zoneId == null) throw new ApiException(400, "Missing required parameter 'zoneId' when calling GetShippingMethodsZone");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetShippingMethodsZone");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetShippingMethodsZone");


            var path = "/shipping/zones/{zone_id}/methods";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "zone_id" + "}", ApiClient.ParameterToString(zoneId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetShippingMethodsZone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetShippingMethodsZone: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ShippingMethod>)ApiClient.Deserialize(response.Content, typeof(List<ShippingMethod>), response.Headers);
        }

        /// <summary>
        /// Update a Shipping Method Updates a *Shipping Method* in a zone. Real Time Carrier Connections are also supported by this endpoint.   **Read Only Fields** * id  ### Settings Objects   A shipping method&#39;s &#x60;type&#x60; and &#x60;settings&#x60; properties can match one of the following models:  ### perorder Object – Properties   Object model for flat-rate shipping quotes per order.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per order. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Order\&quot;,  \&quot;type\&quot;: \&quot;perorder\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 7  } }, &#x60;&#x60;&#x60;  ### peritem Object – Properties   Object model for flat-rate shipping quotes per item ordered.  | Name | Type | Description | | - | - | - | | rate | number | Flat rate per item. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Flat Rate per Item\&quot;,  \&quot;type\&quot;: \&quot;peritem\&quot;,  \&quot;settings\&quot;: {   \&quot;rate\&quot;: 8  } }, &#x60;&#x60;&#x60;  ### weight Object – Properties   Object model for shipping quotes by weight.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties depend on the default units set in the store&#39;s control panel. |   #### JSON Example      &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Rate per Weight\&quot;,  \&quot;type\&quot;: \&quot;weight\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 40,     \&quot;shipping_cost\&quot;: 12    }   ]  } } &#x60;&#x60;&#x60;  ### total Object – Properties   Object model for shipping quotes by order&#39;s total value.  | Name | Type | Description | | - | - | - | | default_cost | number | Default shipping cost, applied either as a percentage of the order&#39;s total value or as a fixed amount. | | default_cost_type | string | How the default shipping cost is calculated. One of: &#x60;percentage_of_total&#x60; or &#x60;fixed_amount&#x60;. | | include_order_total_taxes | boolean | Whether or not to include taxes on the order&#39;s total value in the shipping-cost calculation. | | range | number | Array of [range](#range) objects. The units for these ranges&#39; &#x60;lower_limit&#x60; and &#x60;upper_limit&#x60; properties are values in the store&#39;s currency. |  #### JSON Example   This example sets free shipping above a certain order total:  &#x60;&#x60;&#x60;json {  \&quot;name\&quot;: \&quot;Per Total or Free\&quot;,  \&quot;type\&quot;: \&quot;total\&quot;,  \&quot;settings\&quot;: {   \&quot;default_cost\&quot;: 12,   \&quot;default_cost_type\&quot;: \&quot;fixed_amount\&quot;,   \&quot;include_order_total_taxes\&quot;: 0,   \&quot;range\&quot;: [    {     \&quot;lower_limit\&quot;: 0,     \&quot;upper_limit\&quot;: 5,     \&quot;shipping_cost\&quot;: 5    },    {     \&quot;lower_limit\&quot;: 5,     \&quot;upper_limit\&quot;: 10,     \&quot;shipping_cost\&quot;: 8    },    {     \&quot;lower_limit\&quot;: 10,     \&quot;upper_limit\&quot;: 20,     \&quot;shipping_cost\&quot;: 10    },    {     \&quot;lower_limit\&quot;: 20,     \&quot;upper_limit\&quot;: 49.99,     \&quot;shipping_cost\&quot;: 15    },    {     \&quot;lower_limit\&quot;: 50,     \&quot;upper_limit\&quot;: 100000,     \&quot;shipping_cost\&quot;: 0    }          ]  } } &#x60;&#x60;&#x60;  ### Range Object – Properties   Object model to define ranges for shipping quotes. Units are defined in the parent object.  | Name | Type | Description | | - | - | - | | lower_limit | number | Lower limit for order total. | | upper_limit | number | Upper limit for order total. | | shipping_cost | number | Shipping cost for orders whose total falls between the lower and upper limits. |  #### JSON Example   &#x60;&#x60;&#x60;json {  \&quot;lower_limit\&quot;: 0,  \&quot;upper_limit\&quot;: 20,  \&quot;shipping_cost\&quot;: 8 } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="zoneId">Id of the shipping zone.</param>
        /// <param name="methodId">Id of the shipping method within the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingMethodFull1</returns>
        public ShippingMethodFull1 UpdateAShippingMethod(int? zoneId, int? methodId, string accept, string contentType, ShippingMethodBase2 body)
        {

            // verify the required parameter 'zoneId' is set
            if (zoneId == null) throw new ApiException(400, "Missing required parameter 'zoneId' when calling UpdateAShippingMethod");

            // verify the required parameter 'methodId' is set
            if (methodId == null) throw new ApiException(400, "Missing required parameter 'methodId' when calling UpdateAShippingMethod");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateAShippingMethod");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateAShippingMethod");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAShippingMethod");


            var path = "/shipping/zones/{zone_id}/methods/{method_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "zone_id" + "}", ApiClient.ParameterToString(zoneId));
            path = path.Replace("{" + "method_id" + "}", ApiClient.ParameterToString(methodId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAShippingMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAShippingMethod: " + response.ErrorMessage, response.ErrorMessage);

            return (ShippingMethodFull1)ApiClient.Deserialize(response.Content, typeof(ShippingMethodFull1), response.Headers);
        }

    }
}
