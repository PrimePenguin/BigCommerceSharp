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
    public interface IOrderShippingAddressesQuotesApi
    {
        /// <summary>
        /// Get All Shipping Quotes Gets any shipping quotes assocated to an order.  This is a read only enpoint and the output can vary based on the shipping quote. A shipping quote can only be generated using the storefront at this time. Orders that are created in the control panel or via api return a 204 for this endpoint since a shipping quote is not generated during that process.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="shippingAddressId">Shipping address ID</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ShippingQuotes</returns>
        ShippingQuotes GetShippingQuotes (int? orderId, int? shippingAddressId, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderShippingAddressesQuotesApi : IOrderShippingAddressesQuotesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShippingAddressesQuotesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderShippingAddressesQuotesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShippingAddressesQuotesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderShippingAddressesQuotesApi(string basePath)
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
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get All Shipping Quotes Gets any shipping quotes assocated to an order.  This is a read only enpoint and the output can vary based on the shipping quote. A shipping quote can only be generated using the storefront at this time. Orders that are created in the control panel or via api return a 204 for this endpoint since a shipping quote is not generated during that process.
        /// </summary>
        /// <param name="orderId">ID of the order</param> 
        /// <param name="shippingAddressId">Shipping address ID</param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>ShippingQuotes</returns>            
        public ShippingQuotes GetShippingQuotes (int? orderId, int? shippingAddressId, string accept, string contentType)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetShippingQuotes");
            
            // verify the required parameter 'shippingAddressId' is set
            if (shippingAddressId == null) throw new ApiException(400, "Missing required parameter 'shippingAddressId' when calling GetShippingQuotes");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetShippingQuotes");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetShippingQuotes");
            
    
            var path = "/orders/{order_id}/shipping_addresses/{shipping_address_id}/shipping_quotes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
path = path.Replace("{" + "shipping_address_id" + "}", ApiClient.ParameterToString(shippingAddressId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingQuotes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingQuotes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ShippingQuotes) ApiClient.Deserialize(response.Content, typeof(ShippingQuotes), response.Headers);
        }
    
    }
}
