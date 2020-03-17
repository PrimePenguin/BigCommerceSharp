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
    public interface IProductOptionValuesApi
    {
        /// <summary>
        /// Create Product Option Values Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="optionValue"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OptionValueResponse</returns>
        OptionValueResponse CreateOptionValue (int? productId, int? optionId, object optionValue, string accept, string contentType);
        /// <summary>
        /// Delete a Product Option Value Deletea a *Variant Option Value*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteOptionValueById (int? productId, int? optionId, int? valueId, string accept, string contentType);
        /// <summary>
        /// Get a Product Option Value Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>OptionValueResponse</returns>
        OptionValueResponse GetOptionValueById (int? productId, int? optionId, int? valueId, string includeFields, string excludeFields);
        /// <summary>
        /// Get all Product Option Values Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>OptionValueCollectionResponse</returns>
        OptionValueCollectionResponse GetOptionValues (int? productId, int? optionId, string accept, string contentType, string includeFields, string excludeFields);
        /// <summary>
        /// Update a Product Option Value Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="optionValue">A BigCommerce &#x60;OptionValue&#x60; object. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>OptionValueResponse</returns>
        OptionValueResponse UpdateOptionValue (int? productId, int? optionId, int? valueId, object optionValue, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductOptionValuesApi : IProductOptionValuesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValuesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductOptionValuesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductOptionValuesApi(String basePath)
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
        /// Create Product Option Values Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param> 
        /// <param name="optionValue"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>OptionValueResponse</returns>            
        public OptionValueResponse CreateOptionValue (int? productId, int? optionId, object optionValue, string accept, string contentType)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling CreateOptionValue");
            
            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling CreateOptionValue");
            
            // verify the required parameter 'optionValue' is set
            if (optionValue == null) throw new ApiException(400, "Missing required parameter 'optionValue' when calling CreateOptionValue");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateOptionValue");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateOptionValue");
            
    
            var path = "/catalog/products/{product_id}/options/{option_id}/values";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(optionValue); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOptionValue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOptionValue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OptionValueResponse) ApiClient.Deserialize(response.Content, typeof(OptionValueResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete a Product Option Value Deletea a *Variant Option Value*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param> 
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void DeleteOptionValueById (int? productId, int? optionId, int? valueId, string accept, string contentType)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling DeleteOptionValueById");
            
            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling DeleteOptionValueById");
            
            // verify the required parameter 'valueId' is set
            if (valueId == null) throw new ApiException(400, "Missing required parameter 'valueId' when calling DeleteOptionValueById");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteOptionValueById");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteOptionValueById");
            
    
            var path = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));
path = path.Replace("{" + "value_id" + "}", ApiClient.ParameterToString(valueId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOptionValueById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOptionValueById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a Product Option Value Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param> 
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param> 
        /// <returns>OptionValueResponse</returns>            
        public OptionValueResponse GetOptionValueById (int? productId, int? optionId, int? valueId, string includeFields, string excludeFields)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetOptionValueById");
            
            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling GetOptionValueById");
            
            // verify the required parameter 'valueId' is set
            if (valueId == null) throw new ApiException(400, "Missing required parameter 'valueId' when calling GetOptionValueById");
            
    
            var path = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));
path = path.Replace("{" + "value_id" + "}", ApiClient.ParameterToString(valueId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
 if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOptionValueById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOptionValueById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OptionValueResponse) ApiClient.Deserialize(response.Content, typeof(OptionValueResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all Product Option Values Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param> 
        /// <returns>OptionValueCollectionResponse</returns>            
        public OptionValueCollectionResponse GetOptionValues (int? productId, int? optionId, string accept, string contentType, string includeFields, string excludeFields)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetOptionValues");
            
            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling GetOptionValues");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetOptionValues");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetOptionValues");
            
    
            var path = "/catalog/products/{product_id}/options/{option_id}/values";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
 if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOptionValues: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOptionValues: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OptionValueCollectionResponse) ApiClient.Deserialize(response.Content, typeof(OptionValueCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Update a Product Option Value Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param> 
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param> 
        /// <param name="optionValue">A BigCommerce &#x60;OptionValue&#x60; object. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>OptionValueResponse</returns>            
        public OptionValueResponse UpdateOptionValue (int? productId, int? optionId, int? valueId, object optionValue, string accept, string contentType)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling UpdateOptionValue");
            
            // verify the required parameter 'optionId' is set
            if (optionId == null) throw new ApiException(400, "Missing required parameter 'optionId' when calling UpdateOptionValue");
            
            // verify the required parameter 'valueId' is set
            if (valueId == null) throw new ApiException(400, "Missing required parameter 'valueId' when calling UpdateOptionValue");
            
            // verify the required parameter 'optionValue' is set
            if (optionValue == null) throw new ApiException(400, "Missing required parameter 'optionValue' when calling UpdateOptionValue");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateOptionValue");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateOptionValue");
            
    
            var path = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "option_id" + "}", ApiClient.ParameterToString(optionId));
path = path.Replace("{" + "value_id" + "}", ApiClient.ParameterToString(valueId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(optionValue); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOptionValue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOptionValue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OptionValueResponse) ApiClient.Deserialize(response.Content, typeof(OptionValueResponse), response.Headers);
        }
    
    }
}
