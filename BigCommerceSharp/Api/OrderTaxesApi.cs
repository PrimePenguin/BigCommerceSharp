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
    public interface IOrderTaxesApi
    {
        /// <summary>
        /// Get All Order Taxes Gets all order taxes using &#x60;order_id&#x60;. Each tax applied to an order. This information can be useful for reporting purposes. Pass in the query parameter &#x60;?details&#x3D;true&#x60; to return extra details about order taxes. &#x60;order_product_id&#x60; and &#x60;line_item_type&#x60; are also returned  All values are read-only.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <param name="details">To return detailed tax information, pass in the details query.</param>
        /// <returns>List&lt;OrderTaxes&gt;</returns>
        List<OrderTaxes> GetOrderTaxes (int? orderId, string accept, string contentType, decimal? page, decimal? limit, string details);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderTaxesApi : IOrderTaxesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTaxesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderTaxesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTaxesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderTaxesApi(string basePath)
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
        /// Get All Order Taxes Gets all order taxes using &#x60;order_id&#x60;. Each tax applied to an order. This information can be useful for reporting purposes. Pass in the query parameter &#x60;?details&#x3D;true&#x60; to return extra details about order taxes. &#x60;order_product_id&#x60; and &#x60;line_item_type&#x60; are also returned  All values are read-only.
        /// </summary>
        /// <param name="orderId">ID of the order</param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="page">The page to return in the response.</param> 
        /// <param name="limit">Number of results to return.</param> 
        /// <param name="details">To return detailed tax information, pass in the details query.</param> 
        /// <returns>List&lt;OrderTaxes&gt;</returns>            
        public List<OrderTaxes> GetOrderTaxes (int? orderId, string accept, string contentType, decimal? page, decimal? limit, string details)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetOrderTaxes");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetOrderTaxes");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetOrderTaxes");
            
    
            var path = "/orders/{order_id}/taxes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
    
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (details != null) queryParams.Add("details", ApiClient.ParameterToString(details)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderTaxes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderTaxes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<OrderTaxes>) ApiClient.Deserialize(response.Content, typeof(List<OrderTaxes>), response.Headers);
        }
    
    }
}
