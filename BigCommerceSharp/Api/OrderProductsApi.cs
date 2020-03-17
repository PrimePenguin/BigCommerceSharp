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
    public interface IOrderProductsApi
    {
        /// <summary>
        /// List Order Products Lists all order products on an order using &#x60;order_id&#x60;. By default, items sort from lowest to highest according to a newly created ID, separate from the &#x60;order_id&#x60; and the &#x60;product_id&#x60;.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <returns>List&lt;OrderProducts&gt;</returns>
        List<OrderProducts> GetAllOrderProducts (int? orderId, string accept, string contentType, decimal? page, decimal? limit);
        /// <summary>
        /// Get a Order Product Gets a product line item associated with the order.
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="productId">ID of the product</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OrderProducts</returns>
        OrderProducts GetAnOrderProduct (int? orderId, int? productId, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderProductsApi : IOrderProductsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderProductsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderProductsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderProductsApi(String basePath)
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
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// List Order Products Lists all order products on an order using &#x60;order_id&#x60;. By default, items sort from lowest to highest according to a newly created ID, separate from the &#x60;order_id&#x60; and the &#x60;product_id&#x60;.
        /// </summary>
        /// <param name="orderId">ID of the order</param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="page">The page to return in the response.</param> 
        /// <param name="limit">Number of results to return.</param> 
        /// <returns>List&lt;OrderProducts&gt;</returns>            
        public List<OrderProducts> GetAllOrderProducts (int? orderId, string accept, string contentType, decimal? page, decimal? limit)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAllOrderProducts");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAllOrderProducts");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAllOrderProducts");
            
    
            var path = "/orders/{order_id}/products";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllOrderProducts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllOrderProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<OrderProducts>) ApiClient.Deserialize(response.Content, typeof(List<OrderProducts>), response.Headers);
        }
    
        /// <summary>
        /// Get a Order Product Gets a product line item associated with the order.
        /// </summary>
        /// <param name="orderId">ID of the order</param> 
        /// <param name="productId">ID of the product</param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>OrderProducts</returns>            
        public OrderProducts GetAnOrderProduct (int? orderId, int? productId, string accept, string contentType)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAnOrderProduct");
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetAnOrderProduct");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAnOrderProduct");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAnOrderProduct");
            
    
            var path = "/orders/{order_id}/products/{product_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAnOrderProduct: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAnOrderProduct: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrderProducts) ApiClient.Deserialize(response.Content, typeof(OrderProducts), response.Headers);
        }
    
    }
}
