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
    public interface IAPITokenApi
    {
        /// <summary>
        /// Create a Token Creates a Storefront API token.  **Required Scopes** * &#x60;Manage&#x60; &#x60;Storefront API Tokens&#x60;
        /// </summary>
        /// <param name="body"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 CreateToken (object body);
        /// <summary>
        /// Revoke a Token Revoke access for a Storefront API token.
        /// </summary>
        /// <param name="sfApiToken">An existing JWT token that you want to revoke.</param>
        /// <returns></returns>
        void RevokeToken (string sfApiToken);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class APITokenApi : IAPITokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APITokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public APITokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="APITokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APITokenApi(String basePath)
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
        /// Create a Token Creates a Storefront API token.  **Required Scopes** * &#x60;Manage&#x60; &#x60;Storefront API Tokens&#x60;
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 CreateToken (object body)
        {
            
    
            var path = "/storefront/api-token";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Revoke a Token Revoke access for a Storefront API token.
        /// </summary>
        /// <param name="sfApiToken">An existing JWT token that you want to revoke.</param> 
        /// <returns></returns>            
        public void RevokeToken (string sfApiToken)
        {
            
            // verify the required parameter 'sfApiToken' is set
            if (sfApiToken == null) throw new ApiException(400, "Missing required parameter 'sfApiToken' when calling RevokeToken");
            
    
            var path = "/storefront/api-token";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (sfApiToken != null) headerParams.Add("Sf-Api-Token", ApiClient.ParameterToString(sfApiToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RevokeToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RevokeToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
