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
    public interface IWebhooksApi
    {
        /// <summary>
        /// Create a Webhook Creates a webhook. Only one webhook at a time can be created. Custom headers can be added.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>WebhookFull1</returns>
        WebhookFull1 CreateWebhooks (WebhookBase1 body, string accept, string contentType);
        /// <summary>
        /// Delete a Webhook Deletes a webhook. Only one webhook at a time can be deleted. When a webhook is deleted, it is returned in the response as a 200 OK.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>WebhookFull1</returns>
        WebhookFull1 DeleteAWebhook (string id, string accept, string contentType);
        /// <summary>
        /// Get Webhooks Returns a list of all webhooks on a store associated to the &#x60;client_id&#x60; used to authenticate the request.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;WebhookFull1&gt;</returns>
        List<WebhookFull1> GetAllWebhooks (string accept, string contentType);
        /// <summary>
        /// Get a Webhook Return a webhook by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>WebhookFull1</returns>
        WebhookFull1 GetWebhook (string id, string accept, string contentType);
        /// <summary>
        /// Update a Webhook Updates a webhook. Custom headers can be added.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>WebhookFull1</returns>
        WebhookFull1 UpdateAWebhook (string id, WebhookBase2 body, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi : IWebhooksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebhooksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi(String basePath)
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
        /// Create a Webhook Creates a webhook. Only one webhook at a time can be created. Custom headers can be added.
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>WebhookFull1</returns>            
        public WebhookFull1 CreateWebhooks (WebhookBase1 body, string accept, string contentType)
        {
            
    
            var path = "/hooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWebhooks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWebhooks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebhookFull1) ApiClient.Deserialize(response.Content, typeof(WebhookFull1), response.Headers);
        }
    
        /// <summary>
        /// Delete a Webhook Deletes a webhook. Only one webhook at a time can be deleted. When a webhook is deleted, it is returned in the response as a 200 OK.
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>WebhookFull1</returns>            
        public WebhookFull1 DeleteAWebhook (string id, string accept, string contentType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAWebhook");
            
    
            var path = "/hooks/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebhookFull1) ApiClient.Deserialize(response.Content, typeof(WebhookFull1), response.Headers);
        }
    
        /// <summary>
        /// Get Webhooks Returns a list of all webhooks on a store associated to the &#x60;client_id&#x60; used to authenticate the request.
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>List&lt;WebhookFull1&gt;</returns>            
        public List<WebhookFull1> GetAllWebhooks (string accept, string contentType)
        {
            
    
            var path = "/hooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllWebhooks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllWebhooks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<WebhookFull1>) ApiClient.Deserialize(response.Content, typeof(List<WebhookFull1>), response.Headers);
        }
    
        /// <summary>
        /// Get a Webhook Return a webhook by ID.
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>WebhookFull1</returns>            
        public WebhookFull1 GetWebhook (string id, string accept, string contentType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetWebhook");
            
    
            var path = "/hooks/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebhookFull1) ApiClient.Deserialize(response.Content, typeof(WebhookFull1), response.Headers);
        }
    
        /// <summary>
        /// Update a Webhook Updates a webhook. Custom headers can be added.
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="body"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>WebhookFull1</returns>            
        public WebhookFull1 UpdateAWebhook (string id, WebhookBase2 body, string accept, string contentType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAWebhook");
            
    
            var path = "/hooks/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebhookFull1) ApiClient.Deserialize(response.Content, typeof(WebhookFull1), response.Headers);
        }
    
    }
}
