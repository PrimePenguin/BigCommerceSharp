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
    public class OrdersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrdersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrdersApi(string basePath)
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
        /// Create an Order Creates an *Order*. To learn more about creating or updating orders, see [Orders Overview](/api-docs/orders/orders-api-overview).  An order can be created with an existing catalog product or a custom product.  **Required Fields**  *   products *   billing_address
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>Order1</returns>
        public Order1 CreateAnOrder(string accept, string contentType, OrderPost2 body)
        {

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateAnOrder");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateAnOrder");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAnOrder");


            var path = "/orders";
            path = path.Replace("{format}", "json");

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
                throw new ApiException((int)response.StatusCode, "Error calling CreateAnOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAnOrder: " + response.ErrorMessage, response.ErrorMessage);

            return (Order1)ApiClient.Deserialize(response.Content, typeof(Order1), response.Headers);
        }

        /// <summary>
        /// Delete All Orders Archives all orders.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteAllOrders(string accept, string contentType)
        {

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteAllOrders");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteAllOrders");


            var path = "/orders";
            path = path.Replace("{format}", "json");

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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAllOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAllOrders: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Archive an Order Archives an order.  Any attempt to archive an order on a store with automatic tax enabled will fail, and will return &#x60;405 Method not allowed.&#x60;
        /// </summary>
        /// <param name="orderId">ID of the order</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void DeleteAnOrder(int? orderId, string accept, string contentType, object body)
        {

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling DeleteAnOrder");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteAnOrder");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteAnOrder");


            var path = "/orders/{order_id}";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAnOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAnOrder: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get All Orders Gets a list of orders using the filter query. (The default sort is by order id, from lowest to highest.)
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="minId">The minimum order ID.</param>
        /// <param name="maxId">The maximum order ID.</param>
        /// <param name="minTotal">The minimum order total in float format. eg. 12.50</param>
        /// <param name="maxTotal">The maximum order total in float format. eg. 12.50</param>
        /// <param name="customerId">Customer ID</param>
        /// <param name="email">The email of the customer.</param>
        /// <param name="statusId">The staus ID of the order. You can get the status id from the &#x60;/orders&#x60; endpoints.</param>
        /// <param name="cartId">The cart ID of the order.</param>
        /// <param name="paymentMethod">The payment method used on the order.</param>
        /// <param name="minDateCreated">Minimum date the order was created in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param>
        /// <param name="maxDateCreated">Maximum date the order was created in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param>
        /// <param name="minDateModified">Minimum date the order was modified in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param>
        /// <param name="maxDateModified">Maximum date the order was modified in RFC-2822 or ISO-8601.  RFC-2822: &#x60;Thu, 20 Apr 2017 11:32:00 -0400&#x60;  ISO-8601: &#x60;2017-04-20T11:32:00.000-04:00&#x60;</param>
        /// <param name="page">The page to return in the response.</param>
        /// <param name="limit">Number of results to return.</param>
        /// <param name="sort">Direction to sort orders asc or desc. Ex. sort&#x3D;date_created:desc</param>
        /// <param name="isDeleted">If the order was deleted or archived.</param>
        /// <returns>List&lt;Order2&gt;</returns>
        public List<Order2> GetAllOrders(int? minId = null, int? maxId = null, float? minTotal = null, decimal? maxTotal = null, int? customerId = null, string email = null, int? statusId = null, string cartId = null, string paymentMethod = null, string minDateCreated = null, string maxDateCreated = null, string minDateModified = null, string maxDateModified = null, decimal? page = null, decimal? limit = null, string sort = null, bool? isDeleted = null)
        {
            var path = "/orders";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (minId != null) queryParams.Add("min_id", ApiClient.ParameterToString(minId)); // query parameter
            if (maxId != null) queryParams.Add("max_id", ApiClient.ParameterToString(maxId)); // query parameter
            if (minTotal != null) queryParams.Add("min_total", ApiClient.ParameterToString(minTotal)); // query parameter
            if (maxTotal != null) queryParams.Add("max_total", ApiClient.ParameterToString(maxTotal)); // query parameter
            if (customerId != null) queryParams.Add("customer_id", ApiClient.ParameterToString(customerId)); // query parameter
            if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
            if (statusId != null) queryParams.Add("status_id", ApiClient.ParameterToString(statusId)); // query parameter
            if (cartId != null) queryParams.Add("cart_id", ApiClient.ParameterToString(cartId)); // query parameter
            if (paymentMethod != null) queryParams.Add("payment_method", ApiClient.ParameterToString(paymentMethod)); // query parameter
            if (minDateCreated != null) queryParams.Add("min_date_created", ApiClient.ParameterToString(minDateCreated)); // query parameter
            if (maxDateCreated != null) queryParams.Add("max_date_created", ApiClient.ParameterToString(maxDateCreated)); // query parameter
            if (minDateModified != null) queryParams.Add("min_date_modified", ApiClient.ParameterToString(minDateModified)); // query parameter
            if (maxDateModified != null) queryParams.Add("max_date_modified", ApiClient.ParameterToString(maxDateModified)); // query parameter
            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            if (isDeleted != null) queryParams.Add("is_deleted", ApiClient.ParameterToString(isDeleted)); // query parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllOrders: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Order2>)ApiClient.Deserialize(response.Content, typeof(List<Order2>), response.Headers);
        }

        /// <summary>
        /// Get an Order Gets an *Order*. To learn more about creating or updating orders, see [Orders Overview](/api-docs/orders/orders-api-overview).
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="orderId">ID of the order</param>
        /// <param name="body"></param>
        /// <returns>Order1</returns>
        public Order2 GetAnOrder(int? orderId, object body)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetAnOrder");


            var path = "/orders/{order_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAnOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAnOrder: " + response.ErrorMessage, response.ErrorMessage);

            return (Order2)ApiClient.Deserialize(response.Content, typeof(Order2), response.Headers);
        }

        /// <summary>
        /// Get a Count of Orders Gets an array of orders in the store organized by order status.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;OrdersCountResponse&gt;</returns>
        public List<OrdersCountResponse> GetCountOrder(string accept, string contentType)
        {

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetCountOrder");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetCountOrder");


            var path = "/orders/count";
            path = path.Replace("{format}", "json");

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
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCountOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCountOrder: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrdersCountResponse>)ApiClient.Deserialize(response.Content, typeof(List<OrdersCountResponse>), response.Headers);
        }

        /// <summary>
        /// Update an Order Updates an *Order*. To learn more about creating or updating orders, see [Orders Overview](/api-docs/orders/orders-api-overview).
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <param name="orderId">ID of the order</param>
        /// <returns>Order1</returns>
        public Order1 UpdateAnOrder(OrderPost1 body, int? orderId)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAnOrder");

            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling UpdateAnOrder");


            var path = "/orders/{order_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_id" + "}", ApiClient.ParameterToString(orderId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAnOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAnOrder: " + response.ErrorMessage, response.ErrorMessage);

            return (Order1)ApiClient.Deserialize(response.Content, typeof(Order1), response.Headers);
        }

    }
}
