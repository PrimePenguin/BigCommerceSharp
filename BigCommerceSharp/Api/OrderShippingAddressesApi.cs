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
    public class OrderShippingAddressesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShippingAddressesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderShippingAddressesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShippingAddressesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderShippingAddressesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Get a Shipping Address Gets a shipping address associated with an order.  Returned in the response is shipping_quotes object. Please use the Get Shipping Quotes Endpoint. Using the response will return a 204 for the shipping quote.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="id"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OrderShippingAddress</returns>
        public OrderShippingAddress GetAShippingAddress(string orderId, string id)
        {

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAShippingAddress");

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAShippingAddress");

            var path = "/orders/{order_id}/shipping_addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAShippingAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAShippingAddress: " + response.ErrorMessage, response.ErrorMessage);

            return (OrderShippingAddress)ApiClient.Deserialize(response.Content, typeof(OrderShippingAddress), response.Headers);
        }

        /// <summary>
        /// Get a List of Order Shipping Addresses Get all shipping addresses on an order using the &#x60;order_id&#x60;.  Returned in the response is shipping_quotes object. Please use the Get Shipping Quotes Endpoint. Using the response will return a 204 for the shipping quote.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <returns>List&lt;OrderShippingAddress&gt;</returns>
        public List<OrderShippingAddress> GetAllShippingAddresses(int? orderId, decimal? page, decimal? limit)
        {

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAllShippingAddresses");


            var path = "/orders/{order_id}/shipping_addresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllShippingAddresses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllShippingAddresses: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrderShippingAddress>)ApiClient.Deserialize(response.Content, typeof(List<OrderShippingAddress>), response.Headers);
        }

    }
}
