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
    public class OrderRefundsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRefundsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderRefundsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRefundsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderRefundsApi(string basePath)
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
        /// Get Refunds for Order Returns a list of refunds ordered by refund ID in ascending order for the given order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>InlineResponse200</returns>
        public OrderRefundResponse GetOrderRefunds(string orderId)
        {

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling Getorderrefunds");


            var path = "/orders/{order_id}/payment_actions/refunds";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Getorderrefunds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Getorderrefunds: " + response.ErrorMessage, response.ErrorMessage);

            return (OrderRefundResponse)ApiClient.Deserialize(response.Content, typeof(OrderRefundResponse), response.Headers);
        }

        /// <summary>
        /// Get All Refunds Returns a list of refunds ordered by refund ID in ascending order.
        /// </summary>
        /// <param name="orderIdin">Filter by order_ids</param>
        /// <param name="idin">Filter by resource ids</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="createdmin">Filter results so they are later than or equal to provided date.   Must be in url-encoded RFC 3339 format. e.g. &#x60;2020-01-15T01:02:34-01:00&#x60; is RFC-3339 format.  Url-encoded this will be &#x60;2020-01-15T01%3A02%3A34%2B01%3A00&#x60;</param>
        /// <param name="createdmax">Filter results so they are earlier than or equal to provided date.   Must be in url-encoded RFC 3339 format. e.g. &#x60;2020-01-15T01:02:34-01:00&#x60; is RFC-3339 format.  Url-encoded this will be &#x60;2020-01-15T01%3A02%3A34%2B01%3A00&#x60;</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 Getrefunds(List<int?> orderIdin, List<int?> idin, string accept, string contentType, DateTime? createdmin, DateTime? createdmax)
        {


            var path = "/orders/payment_actions/refunds";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (orderIdin != null) queryParams.Add("order_id:in", ApiClient.ParameterToString(orderIdin)); // query parameter
            if (idin != null) queryParams.Add("id:in", ApiClient.ParameterToString(idin)); // query parameter
            if (createdmin != null) queryParams.Add("created:min", ApiClient.ParameterToString(createdmin)); // query parameter
            if (createdmax != null) queryParams.Add("created:max", ApiClient.ParameterToString(createdmax)); // query parameter
            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Getrefunds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Getrefunds: " + response.ErrorMessage, response.ErrorMessage);

            return (InlineResponse200)ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }

        /// <summary>
        /// Create a Refund Creates a refund.
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>InlineResponse2011</returns>
        public InlineResponse2011 Postrefund(int? orderId, RefundRequest body, string accept, string contentType)
        {

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling Postrefund");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Postrefund");


            var path = "/orders/{order_id}/payment_actions/refunds";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

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
                throw new ApiException((int)response.StatusCode, "Error calling Postrefund: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Postrefund: " + response.ErrorMessage, response.ErrorMessage);

            return (InlineResponse2011)ApiClient.Deserialize(response.Content, typeof(InlineResponse2011), response.Headers);
        }

        /// <summary>
        /// Create a Refund Quote Calculate the tax amount, total refund amount and get availble payment options for an order refund by providing items and costs or quantities to refund.
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>InlineResponse201</returns>
        public InlineResponse201 Postrefundquote(int? orderId, RefundQuoteRequest body, string accept, string contentType)
        {

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling Postrefundquote");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Postrefundquote");


            var path = "/orders/{order_id}/payment_actions/refund_quotes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

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
                throw new ApiException((int)response.StatusCode, "Error calling Postrefundquote: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Postrefundquote: " + response.ErrorMessage, response.ErrorMessage);

            return (InlineResponse201)ApiClient.Deserialize(response.Content, typeof(InlineResponse201), response.Headers);
        }

    }
}
