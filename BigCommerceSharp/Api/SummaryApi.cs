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
    public interface ISummaryApi
    {
        /// <summary>
        /// Get a Catalog Summary Returns a lightweight inventory summary from the BigCommerce Catalog.  The inventory summary includes: * \&quot;inventory_count\&quot; * \&quot;variant_count\&quot; * \&quot;inventory_value\&quot; * \&quot;highest_variant_price\&quot; * \&quot;average_variant_price\&quot; * \&quot;lowest_variant_price\&quot; * \&quot;oldest_variant_date\&quot; * \&quot;newest_variant_date\&quot; * \&quot;primary_category_id\&quot; * \&quot;primary_category_name\&quot;
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>CatalogSummaryResponse</returns>
        CatalogSummaryResponse GetCatalogSummary (string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SummaryApi : ISummaryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SummaryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SummaryApi(string basePath)
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
        /// Get a Catalog Summary Returns a lightweight inventory summary from the BigCommerce Catalog.  The inventory summary includes: * \&quot;inventory_count\&quot; * \&quot;variant_count\&quot; * \&quot;inventory_value\&quot; * \&quot;highest_variant_price\&quot; * \&quot;average_variant_price\&quot; * \&quot;lowest_variant_price\&quot; * \&quot;oldest_variant_date\&quot; * \&quot;newest_variant_date\&quot; * \&quot;primary_category_id\&quot; * \&quot;primary_category_name\&quot;
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>CatalogSummaryResponse</returns>            
        public CatalogSummaryResponse GetCatalogSummary (string accept, string contentType)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetCatalogSummary");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetCatalogSummary");
            
    
            var path = "/catalog/summary";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCatalogSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCatalogSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CatalogSummaryResponse) ApiClient.Deserialize(response.Content, typeof(CatalogSummaryResponse), response.Headers);
        }
    
    }
}
