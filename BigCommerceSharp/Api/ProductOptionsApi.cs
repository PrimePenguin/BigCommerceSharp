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
    public class ProductOptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductOptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductOptionsApi(string basePath)
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
        /// Create a Product Option Creates a *Variant Option*.  **Required Fields** * display_name * type * option_values  **Read-Only Fields** * id  **Notes**  * Only one variant option at a time can be created; individual variant options will contain an array of multiple values.  * There are several examples listed below that create options, but the SKU’s are not updated and they are not a variant on the product. Variant SKUs must be created with a separate request. * Variant options will show on the storefront as an option that can be selected by the customer. A request like this could be used to add new choices to a variant that has already been created. * If more than one variant needs to be created use the [Create a Product](/api-reference/catalog/catalog-api/products/createproduct) endpoint.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="option"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OptionResponse</returns>
        public OptionResponse CreateOption(int? productId, object option, string accept, string contentType)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling CreateOption");

            // verify the required parameter 'option' is set
            if (option == null) throw new ApiException(400, "Missing required parameter 'option' when calling CreateOption");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateOption");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateOption");


            var path = "/catalog/products/{product_id}/options";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(option); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateOption: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateOption: " + response.ErrorMessage, response.ErrorMessage);

            return (OptionResponse)ApiClient.Deserialize(response.Content, typeof(OptionResponse), response.Headers);
        }

        /// <summary>
        /// Delete a Product Option Deletes a *Variant Option*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteOptionById(int? productId, int? optionId, string accept, string contentType)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling DeleteOptionById");

            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling DeleteOptionById");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteOptionById");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteOptionById");


            var path = "/catalog/products/{product_id}/options/{option_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));

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
                throw new ApiException((int)response.StatusCode, "Error calling DeleteOptionById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteOptionById: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get a Product Option Returns a single *Variant Option*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>OptionResponse1</returns>
        public OptionResponse1 GetOptionById(int? productId, int? optionId, string contentType, string accept, string includeFields, string excludeFields)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetOptionById");

            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling GetOptionById");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetOptionById");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetOptionById");


            var path = "/catalog/products/{product_id}/options/{option_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
            if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetOptionById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetOptionById: " + response.ErrorMessage, response.ErrorMessage);

            return (OptionResponse1)ApiClient.Deserialize(response.Content, typeof(OptionResponse1), response.Headers);
        }

        /// <summary>
        /// Get all Product Options Returns a list of product *Variant Options*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>OptionCollectionResponse</returns>
        public OptionCollectionResponse GetOptions(int? productId, int? page, int? limit, string includeFields, string excludeFields)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetOptions");


            var path = "/catalog/products/{product_id}/options";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
            if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetOptions: " + response.ErrorMessage, response.ErrorMessage);

            return (OptionCollectionResponse)ApiClient.Deserialize(response.Content, typeof(OptionCollectionResponse), response.Headers);
        }

        /// <summary>
        /// Update a Product Option Updates a *Variant Option*.  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="option"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OptionResponse2</returns>
        public OptionResponse2 UpdateOption(int? productId, int? optionId, object option, string accept, string contentType)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling UpdateOption");

            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling UpdateOption");

            // verify the required parameter 'option' is set
            if (option == null) throw new ApiException(400, "Missing required parameter 'option' when calling UpdateOption");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateOption");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateOption");


            var path = "/catalog/products/{product_id}/options/{option_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(option); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateOption: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateOption: " + response.ErrorMessage, response.ErrorMessage);

            return (OptionResponse2)ApiClient.Deserialize(response.Content, typeof(OptionResponse2), response.Headers);
        }

    }
}
