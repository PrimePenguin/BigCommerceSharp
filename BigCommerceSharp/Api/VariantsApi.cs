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
    public interface IVariantsApi
    {
        /// <summary>
        /// Get All Variants Returns a list of all variants in your catalog. Optional parameters can be passed in.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id. </param>
        /// <param name="sku">Filter items by sku. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <param name="productId">A comma-separated list of ids of Products whose prices were requested. For example: &#x60;?product_id&#x3D;:id&#x60; &#x60;?product_id:in&#x3D;77,80,81&#x60;</param>
        /// <returns>VariantCollectionResponse</returns>
        VariantCollectionResponse GetVariants(string accept, string contentType, int? id, string sku, int? page, int? limit, string includeFields, string excludeFields, string productId);
        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>VariantCollectionResponse</returns>
        VariantCollectionResponse UpdateVariantsBatch(List<object> body, string accept, string contentType);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariantsApi : IVariantsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariantsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariantsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariantsApi(string basePath)
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
        /// Get All Variants Returns a list of all variants in your catalog. Optional parameters can be passed in.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id. </param>
        /// <param name="sku">Filter items by sku. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <param name="productId">A comma-separated list of ids of Products whose prices were requested. For example: &#x60;?product_id&#x3D;:id&#x60; &#x60;?product_id:in&#x3D;77,80,81&#x60;</param>
        /// <returns>VariantCollectionResponse</returns>
        public VariantCollectionResponse GetVariants(string accept, string contentType, int? id, string sku, int? page, int? limit, string includeFields, string excludeFields, string productId)
        {

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetVariants");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetVariants");


            var path = "/catalog/variants";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (sku != null) queryParams.Add("sku", ApiClient.ParameterToString(sku)); // query parameter
            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
            if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
            if (productId != null) queryParams.Add("product_id", ApiClient.ParameterToString(productId)); // query parameter
            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetVariants: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetVariants: " + response.ErrorMessage, response.ErrorMessage);

            return (VariantCollectionResponse)ApiClient.Deserialize(response.Content, typeof(VariantCollectionResponse), response.Headers);
        }

        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>VariantCollectionResponse</returns>
        public VariantCollectionResponse UpdateVariantsBatch(List<object> body, string accept, string contentType)
        {

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateVariantsBatch");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateVariantsBatch");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateVariantsBatch");


            var path = "/catalog/variants";
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
            var response = (RestResponse)ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateVariantsBatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateVariantsBatch: " + response.ErrorMessage, response.ErrorMessage);

            return (VariantCollectionResponse)ApiClient.Deserialize(response.Content, typeof(VariantCollectionResponse), response.Headers);
        }

    }
}
