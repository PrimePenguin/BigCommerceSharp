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
    public interface IOrderStatusApi
    {
        /// <summary>
        /// Get a Single Order Status by Id Returns a single order status.  **Order Status Descriptions:** |Status ID | Name  | Description | |- -|- -|- -| | 0 | Incomplete  | An incomplete order happens when a shopper reached the payment page, but did not complete the transaction. | | 1 | Pending |Customer started the checkout process, but did not complete it. | | 2 | Shipped | Order has been shipped, but receipt has not been confirmed; seller has used the Ship Items action. | | 3 | Partially Shipped | Only some items in the order have been shipped, due to some products being pre-order only or other reasons. | | 4 | Refunded | Seller has used the Refund action. | | 5 | Cancelled | Seller has cancelled an order, due to a stock inconsistency or other reasons. | | 6 |Declined | Seller has marked the order as declined for lack of manual payment, or other reasons. | | 7 | Awaiting Payment | Customer has completed checkout process, but payment has yet to be confirmed. | | 8 | Awaiting Pickup | Order has been pulled, and is awaiting customer pickup from a seller-specified location. | | 9 | Awaiting Shipment | Order has been pulled and packaged, and is awaiting collection from a shipping provider. | | 10 | Completed | Client has paid for their digital product and their file(s) are available for download. | | 11 | Awaiting Fulfillment | Customer has completed the checkout process and payment has been confirmed. | | 12 | Manual Verification Required | Order on hold while some aspect needs to be manually confirmed. | | 13 | Disputed | Customer has initiated a dispute resolution process for the PayPal transaction that paid for the order. | | 14 | Partially Refunded | Seller has partially refunded the order. |
        /// </summary>
        /// <param name="statusId">The staus ID of the order. You can get the status id from the &#x60;/orders&#x60; endpoints.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetAOrderStatus (int? statusId, string accept, string contentType);
        /// <summary>
        /// Get All Order Statuses Returns a Collection of All Order Statuses.  **Order Status Descriptions:** |Status ID | Name  | Description | |- -|- -|- -| | 0 | Incomplete  | An incomplete order happens when a shopper reached the payment page, but did not complete the transaction. | | 1 | Pending |Customer started the checkout process, but did not complete it. | | 2 | Shipped | Order has been shipped, but receipt has not been confirmed; seller has used the Ship Items action. | | 3 | Partially Shipped | Only some items in the order have been shipped, due to some products being pre-order only or other reasons. | | 4 | Refunded | Seller has used the Refund action. | | 5 | Cancelled | Seller has cancelled an order, due to a stock inconsistency or other reasons. | | 6 |Declined | Seller has marked the order as declined for lack of manual payment, or other reasons. | | 7 | Awaiting Payment | Customer has completed checkout process, but payment has yet to be confirmed. | | 8 | Awaiting Pickup | Order has been pulled, and is awaiting customer pickup from a seller-specified location. | | 9 | Awaiting Shipment | Order has been pulled and packaged, and is awaiting collection from a shipping provider. | | 10 | Completed | Client has paid for their digital product and their file(s) are available for download. | | 11 | Awaiting Fulfillment | Customer has completed the checkout process and payment has been confirmed. | | 12 | Manual Verification Required | Order on hold while some aspect needs to be manually confirmed. | | 13 | Disputed | Customer has initiated a dispute resolution process for the PayPal transaction that paid for the order. | | 14 | Partially Refunded | Seller has partially refunded the order. |
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetOrderStatus (string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderStatusApi : IOrderStatusApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStatusApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderStatusApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderStatusApi(String basePath)
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
        /// Get a Single Order Status by Id Returns a single order status.  **Order Status Descriptions:** |Status ID | Name  | Description | |- -|- -|- -| | 0 | Incomplete  | An incomplete order happens when a shopper reached the payment page, but did not complete the transaction. | | 1 | Pending |Customer started the checkout process, but did not complete it. | | 2 | Shipped | Order has been shipped, but receipt has not been confirmed; seller has used the Ship Items action. | | 3 | Partially Shipped | Only some items in the order have been shipped, due to some products being pre-order only or other reasons. | | 4 | Refunded | Seller has used the Refund action. | | 5 | Cancelled | Seller has cancelled an order, due to a stock inconsistency or other reasons. | | 6 |Declined | Seller has marked the order as declined for lack of manual payment, or other reasons. | | 7 | Awaiting Payment | Customer has completed checkout process, but payment has yet to be confirmed. | | 8 | Awaiting Pickup | Order has been pulled, and is awaiting customer pickup from a seller-specified location. | | 9 | Awaiting Shipment | Order has been pulled and packaged, and is awaiting collection from a shipping provider. | | 10 | Completed | Client has paid for their digital product and their file(s) are available for download. | | 11 | Awaiting Fulfillment | Customer has completed the checkout process and payment has been confirmed. | | 12 | Manual Verification Required | Order on hold while some aspect needs to be manually confirmed. | | 13 | Disputed | Customer has initiated a dispute resolution process for the PayPal transaction that paid for the order. | | 14 | Partially Refunded | Seller has partially refunded the order. |
        /// </summary>
        /// <param name="statusId">The staus ID of the order. You can get the status id from the &#x60;/orders&#x60; endpoints.</param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 GetAOrderStatus (int? statusId, string accept, string contentType)
        {
            
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling GetAOrderStatus");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAOrderStatus");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAOrderStatus");
            
    
            var path = "/order_statuses/{status_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "status_id" + "}", ApiClient.ParameterToString(statusId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAOrderStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAOrderStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Get All Order Statuses Returns a Collection of All Order Statuses.  **Order Status Descriptions:** |Status ID | Name  | Description | |- -|- -|- -| | 0 | Incomplete  | An incomplete order happens when a shopper reached the payment page, but did not complete the transaction. | | 1 | Pending |Customer started the checkout process, but did not complete it. | | 2 | Shipped | Order has been shipped, but receipt has not been confirmed; seller has used the Ship Items action. | | 3 | Partially Shipped | Only some items in the order have been shipped, due to some products being pre-order only or other reasons. | | 4 | Refunded | Seller has used the Refund action. | | 5 | Cancelled | Seller has cancelled an order, due to a stock inconsistency or other reasons. | | 6 |Declined | Seller has marked the order as declined for lack of manual payment, or other reasons. | | 7 | Awaiting Payment | Customer has completed checkout process, but payment has yet to be confirmed. | | 8 | Awaiting Pickup | Order has been pulled, and is awaiting customer pickup from a seller-specified location. | | 9 | Awaiting Shipment | Order has been pulled and packaged, and is awaiting collection from a shipping provider. | | 10 | Completed | Client has paid for their digital product and their file(s) are available for download. | | 11 | Awaiting Fulfillment | Customer has completed the checkout process and payment has been confirmed. | | 12 | Manual Verification Required | Order on hold while some aspect needs to be manually confirmed. | | 13 | Disputed | Customer has initiated a dispute resolution process for the PayPal transaction that paid for the order. | | 14 | Partially Refunded | Seller has partially refunded the order. |
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>List&lt;Object&gt;</returns>            
        public List<Object> GetOrderStatus (string accept, string contentType)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetOrderStatus");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetOrderStatus");
            
    
            var path = "/order_statuses";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
    }
}
