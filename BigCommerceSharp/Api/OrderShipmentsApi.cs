using System.Collections.Generic;
using BigCommerceSharp.Client;
using BigCommerceSharp.Model;
using RestSharp;

namespace BigCommerceSharp.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderShipmentsApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderShipmentsApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderShipmentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderShipmentsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public OrderShipmentsApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Create a New Order Shipment Creates an *Order Shipment*. To learn how to create an Order Shipment, see [Orders
        ///     Overview](/api-docs/orders/orders-api-overview#orders-api-overview_create-order-shipment).  **Required Fields** *
        ///     order_address_id *   items *   shipping_provider  **Notes** &#x60;tracking_carrier&#x60; is optional, but if you
        ///     include it, its value must refer/map to the same carrier service as the &#x60;shipping_provider&#x60; value.
        ///     Acceptable values for &#x60;tracking_carrier&#x60; are an empty string (&#x60;\&quot;\&quot;&#x60;), or one of the
        ///     valid tracking-carrier values viewable
        ///     [here](https://docs.google.com/spreadsheets/d/1w9c_aECSCGyf-oOrvGeUniDl-ARGKemfZl0qSsav8D4/pubhtml?gid&#x3D;0&amp;
        ///     single&#x3D;true) and downloadable as a .CSV file
        ///     [here](https://docs.google.com/spreadsheets/d/1mTueEynfcEmwsU2y2Jd2MX-8GKwNZrmlRMBcIElg9aY/pub?gid&#x3D;0&amp;
        ///     single&#x3D;true&amp;output&#x3D;csv).
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>OrderShipment1</returns>
        public OrderShipment1 CreateOrderShipments(int? orderId, string accept, string contentType,
            OrderShipmentPost1 body)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling CreateOrderShipments");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CreateOrderShipments");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400,
                    "Missing required parameter 'contentType' when calling CreateOrderShipments");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CreateOrderShipments");


            var path = "/orders/{order_id}/shipments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling CreateOrderShipments: " + response.Content, response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling CreateOrderShipments: " + response.ErrorMessage, response.ErrorMessage);

            return (OrderShipment1)ApiClient.Deserialize(response.Content, typeof(OrderShipment1), response.Headers);
        }

        /// <summary>
        ///     Delete All Order Shipments Deletes all shipments associated with an order.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteAllOrderShipments(int? orderId, string accept, string contentType)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400,
                    "Missing required parameter 'orderId' when calling DeleteAllOrderShipments");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteAllOrderShipments");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400,
                    "Missing required parameter 'contentType' when calling DeleteAllOrderShipments");


            var path = "/orders/{order_id}/shipments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling DeleteAllOrderShipments: " + response.Content, response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling DeleteAllOrderShipments: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        ///     Delete an Order Shipment Deletes a shipment associated with an order.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteOrderShipment(int? orderId, int? shipmentId, string accept, string contentType)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling DeleteOrderShipment");

            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling DeleteOrderShipment");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteOrderShipment");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400,
                    "Missing required parameter 'contentType' when calling DeleteOrderShipment");


            var path = "/orders/{order_id}/shipments/{shipment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
            path = path.Replace("{" + "shipment_id" + "}", ApiClient.ParameterToString(shipmentId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling DeleteOrderShipment: " + response.Content, response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling DeleteOrderShipment: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        ///     Get a List of Order Shipments Gets a list of all shipments on an order.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <returns>List&lt;OrderShipment&gt;</returns>
        public List<OrderShipment> GetAllOrderShipments(int? orderId, string accept, string contentType, decimal? page,
            decimal? limit)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAllOrderShipments");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling GetAllOrderShipments");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400,
                    "Missing required parameter 'contentType' when calling GetAllOrderShipments");


            var path = "/orders/{order_id}/shipments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetAllOrderShipments: " + response.Content, response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetAllOrderShipments: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrderShipment>)ApiClient.Deserialize(response.Content, typeof(List<OrderShipment>),
                response.Headers);
        }

        /// <summary>
        ///     Get a Count of Shipments Per Order Gets a count of the number of shipments that have been made for a single order.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OrderCountResponse</returns>
        public OrderCountResponse GetCountShipments(int? orderId, string accept, string contentType)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling GetCountShipments");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling GetCountShipments");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling GetCountShipments");


            var path = "/orders/{order_id}/shipments/count";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetCountShipments: " + response.Content, response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetCountShipments: " + response.ErrorMessage, response.ErrorMessage);

            return (OrderCountResponse)ApiClient.Deserialize(response.Content, typeof(OrderCountResponse),
                response.Headers);
        }

        /// <summary>
        ///     Get a Shipment Gets an order shipment.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OrderShipment1</returns>
        public OrderShipment1 GetOrderShipment(int? orderId, int? shipmentId, string accept, string contentType)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling GetOrderShipment");

            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling GetOrderShipment");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling GetOrderShipment");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling GetOrderShipment");


            var path = "/orders/{order_id}/shipments/{shipment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
            path = path.Replace("{" + "shipment_id" + "}", ApiClient.ParameterToString(shipmentId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetOrderShipment: " + response.Content,
                    response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetOrderShipment: " + response.ErrorMessage, response.ErrorMessage);

            return (OrderShipment1)ApiClient.Deserialize(response.Content, typeof(OrderShipment1), response.Headers);
        }

        /// <summary>
        ///     Update a Shipment Updates an existing shipment associated with an order.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>OrderShipment1</returns>
        public OrderShipment1 UpdateOrderShipment(int? orderId, int? shipmentId, string accept, string contentType,
            OrderShipmentPost2 body)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling UpdateOrderShipment");

            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling UpdateOrderShipment");

            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateOrderShipment");

            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400,
                    "Missing required parameter 'contentType' when calling UpdateOrderShipment");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrderShipment");


            var path = "/orders/{order_id}/shipments/{shipment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
            path = path.Replace("{" + "shipment_id" + "}", ApiClient.ParameterToString(shipmentId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null)
                headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams,
                formParams, fileParams, authSettings);

            if ((int)response.StatusCode >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling UpdateOrderShipment: " + response.Content, response.Content);
            if ((int)response.StatusCode == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling UpdateOrderShipment: " + response.ErrorMessage, response.ErrorMessage);

            return (OrderShipment1)ApiClient.Deserialize(response.Content, typeof(OrderShipment1), response.Headers);
        }

        /// <summary>
        ///     Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath)
        {
            ApiClient.BasePath = basePath;
        }

        /// <summary>
        ///     Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath)
        {
            return ApiClient.BasePath;
        }
    }
}