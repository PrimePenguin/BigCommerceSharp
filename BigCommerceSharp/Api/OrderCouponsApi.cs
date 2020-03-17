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
    public interface IOrderCouponsApi
    {
        /// <summary>
        /// List Order Coupons Lists all order coupons. Optional parameters can be passed in.  |Type &#x60;int&#x60;|Type Name| |-|-| |&#x60;0&#x60;|&#x60;per_item_discount&#x60;| |&#x60;1&#x60;|&#x60;percentage_discount&#x60;| |&#x60;2&#x60;|&#x60;per_total_discount&#x60;| |&#x60;3&#x60;|&#x60;shipping_discount&#x60;| |&#x60;4&#x60;|&#x60;free_shipping&#x60;| |&#x60;5&#x60;|&#x60;promotion&#x60;|
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <returns>List&lt;OrderCoupons&gt;</returns>
        List<OrderCoupons> GetAllOrderCoupons (int? orderId, string accept, string contentType, decimal? page, decimal? limit);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderCouponsApi : IOrderCouponsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCouponsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderCouponsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCouponsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderCouponsApi(string basePath)
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
        /// List Order Coupons Lists all order coupons. Optional parameters can be passed in.  |Type &#x60;int&#x60;|Type Name| |-|-| |&#x60;0&#x60;|&#x60;per_item_discount&#x60;| |&#x60;1&#x60;|&#x60;percentage_discount&#x60;| |&#x60;2&#x60;|&#x60;per_total_discount&#x60;| |&#x60;3&#x60;|&#x60;shipping_discount&#x60;| |&#x60;4&#x60;|&#x60;free_shipping&#x60;| |&#x60;5&#x60;|&#x60;promotion&#x60;|
        /// </summary>
        /// <param name="orderId">ID of the order</param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="page">The page to return in the response.</param> 
        /// <param name="limit">Number of results to return.</param> 
        /// <returns>List&lt;OrderCoupons&gt;</returns>            
        public List<OrderCoupons> GetAllOrderCoupons (int? orderId, string accept, string contentType, decimal? page, decimal? limit)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAllOrderCoupons");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAllOrderCoupons");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAllOrderCoupons");
            
    
            var path = "/orders/{order_id}/coupons";
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
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllOrderCoupons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllOrderCoupons: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<OrderCoupons>) ApiClient.Deserialize(response.Content, typeof(List<OrderCoupons>), response.Headers);
        }
    
    }
}
