using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionsApi
    {
        /// <summary>
        /// Get Transactions Returns an **order&#39;s** transactions.   **Usage Notes** * Depending on the payment method, different information will be available (not all payment gateways return full card details or fraud detail). * The test payment gateway does not return any information.
        /// </summary>
        /// <param name="orderId">The ID of the &#x60;Order&#x60; to which the transactions belong. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>TransactionCollectionResponse</returns>
        TransactionCollectionResponse GetTransactions (int? orderId, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
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
        /// Get Transactions Returns an **order&#39;s** transactions.   **Usage Notes** * Depending on the payment method, different information will be available (not all payment gateways return full card details or fraud detail). * The test payment gateway does not return any information.
        /// </summary>
        /// <param name="orderId">The ID of the &#x60;Order&#x60; to which the transactions belong. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>TransactionCollectionResponse</returns>            
        public TransactionCollectionResponse GetTransactions (int? orderId, string accept, string contentType)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetTransactions");
            
    
            var path = "/orders/{order_id}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionCollectionResponse) ApiClient.Deserialize(response.Content, typeof(TransactionCollectionResponse), response.Headers);
        }
    
    }
}
