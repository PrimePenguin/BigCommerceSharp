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
    public interface ICustomerImpersonationTokenApi
    {
        /// <summary>
        /// Create a Token Creates a Storefront API token that allows for customer impersonation.  **Required Scopes** * &#x60;Manage&#x60; &#x60;Storefront API Customer Impersonation Tokens&#x60;  **Headers**: * &#x60;X-Bc-Customer-Id&#x60; - The ID of the Customer to impersonate
        /// </summary>
        /// <param name="xBcCustomerId">Ther Customer ID for the customer to impersonate</param>
        /// <param name="body"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 CreateTokenWithCustomerImpersonation (int? xBcCustomerId, Body body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerImpersonationTokenApi : ICustomerImpersonationTokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerImpersonationTokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomerImpersonationTokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerImpersonationTokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerImpersonationTokenApi(String basePath)
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
        /// Create a Token Creates a Storefront API token that allows for customer impersonation.  **Required Scopes** * &#x60;Manage&#x60; &#x60;Storefront API Customer Impersonation Tokens&#x60;  **Headers**: * &#x60;X-Bc-Customer-Id&#x60; - The ID of the Customer to impersonate
        /// </summary>
        /// <param name="xBcCustomerId">Ther Customer ID for the customer to impersonate</param>
        /// <param name="body"></param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 CreateTokenWithCustomerImpersonation (int? xBcCustomerId, Body body)
        {

            // verify the required parameter 'xBcCustomerId' is set
            if (xBcCustomerId == null) throw new ApiException(400, "Missing required parameter 'xBcCustomerId' when calling CreateTokenWithCustomerImpersonation");


            var path = "/storefront/api-token-customer-impersonation";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                         if (xBcCustomerId != null) headerParams.Add("X-Bc-Customer-Id", ApiClient.ParameterToString(xBcCustomerId)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTokenWithCustomerImpersonation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTokenWithCustomerImpersonation: " + response.ErrorMessage, response.ErrorMessage);

            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }

    }
}
