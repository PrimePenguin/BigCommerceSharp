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
    public interface IOrderMessagesApi
    {
        /// <summary>
        /// Get Order Messages Gets the messages associated with an order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="minId">The minimum order ID.</param>
        /// <param name="maxId">The maximum order ID.</param>
        /// <param name="customerId">Customer ID</param>
        /// <param name="minDateCreated">Minimum date the order was created in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param>
        /// <param name="maxDateCreated">Maximum date the order was created in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param>
        /// <param name="isFlagged">If the message is [flagged](https://support.bigcommerce.com/s/article/Communicating-with-Customers#Messages).</param>
        /// <param name="status">Status of the order message.</param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <returns>List&lt;InlineResponse2001&gt;</returns>
        List<InlineResponse2001> GetOrderMessages (string orderId, string accept, string contentType, int? minId, int? maxId, int? customerId, string minDateCreated, string maxDateCreated, bool? isFlagged, string status, decimal? page, decimal? limit);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderMessagesApi : IOrderMessagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMessagesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderMessagesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderMessagesApi(String basePath)
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
        /// Get Order Messages Gets the messages associated with an order.
        /// </summary>
        /// <param name="orderId"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="minId">The minimum order ID.</param> 
        /// <param name="maxId">The maximum order ID.</param> 
        /// <param name="customerId">Customer ID</param> 
        /// <param name="minDateCreated">Minimum date the order was created in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param> 
        /// <param name="maxDateCreated">Maximum date the order was created in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param> 
        /// <param name="isFlagged">If the message is [flagged](https://support.bigcommerce.com/s/article/Communicating-with-Customers#Messages).</param> 
        /// <param name="status">Status of the order message.</param> 
        /// <param name="page">The page to return in the response.</param> 
        /// <param name="limit">Number of results to return.</param> 
        /// <returns>List&lt;InlineResponse2001&gt;</returns>            
        public List<InlineResponse2001> GetOrderMessages (string orderId, string accept, string contentType, int? minId, int? maxId, int? customerId, string minDateCreated, string maxDateCreated, bool? isFlagged, string status, decimal? page, decimal? limit)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetOrderMessages");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetOrderMessages");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetOrderMessages");
            
    
            var path = "/orders/{order_id}/messages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (minId != null) queryParams.Add("min_id", ApiClient.ParameterToString(minId)); // query parameter
 if (maxId != null) queryParams.Add("max_id", ApiClient.ParameterToString(maxId)); // query parameter
 if (customerId != null) queryParams.Add("customer_id", ApiClient.ParameterToString(customerId)); // query parameter
 if (minDateCreated != null) queryParams.Add("min_date_created", ApiClient.ParameterToString(minDateCreated)); // query parameter
 if (maxDateCreated != null) queryParams.Add("max_date_created", ApiClient.ParameterToString(maxDateCreated)); // query parameter
 if (isFlagged != null) queryParams.Add("is_flagged", ApiClient.ParameterToString(isFlagged)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderMessages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<InlineResponse2001>) ApiClient.Deserialize(response.Content, typeof(List<InlineResponse2001>), response.Headers);
        }
    
    }
}
