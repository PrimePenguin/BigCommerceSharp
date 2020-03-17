using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductVariantsApi
    {
        /// <summary>
        /// Create a Product Variant Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variant"></param>
        /// <returns>VariantResponse</returns>
        VariantResponse CreateVariant (int? productId, object variant);
        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"></param>
        /// <returns>ImageResponse</returns>
        ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body);
        /// <summary>
        /// Delete a Product Variant Deletes a product *Variant*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteVariantById (int? productId, int? variantId, string accept, string contentType);
        /// <summary>
        /// Get a Product Variant Returns a single product *Variant*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>VariantResponse</returns>
        VariantResponse GetVariantById (int? productId, int? variantId, string accept, string contentType, string includeFields, string excludeFields);
        /// <summary>
        /// Get All Product Variants Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>VariantCollectionResponse</returns>
        VariantCollectionResponse GetVariantsByProductId (int? productId, string accept, string contentType, int? page, int? limit, string includeFields, string excludeFields);
        /// <summary>
        /// Update a Product Variant Updates a product *Variant*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="variant"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>VariantResponse</returns>
        VariantResponse UpdateVariant (int? productId, int? variantId, object variant, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductVariantsApi : IProductVariantsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductVariantsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductVariantsApi(String basePath)
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
        /// Create a Product Variant Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="variant"></param> 
        /// <returns>VariantResponse</returns>            
        public VariantResponse CreateVariant (int? productId, object variant)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling CreateVariant");
            
            // verify the required parameter 'variant' is set
            if (variant == null) throw new ApiException(400, "Missing required parameter 'variant' when calling CreateVariant");
            
    
            var path = "/catalog/products/{product_id}/variants";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(variant); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVariant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVariant: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VariantResponse) ApiClient.Deserialize(response.Content, typeof(VariantResponse), response.Headers);
        }
    
        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param> 
        /// <param name="body"></param> 
        /// <returns>ImageResponse</returns>            
        public ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling CreateVariantImage");
            
            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling CreateVariantImage");
            
    
            var path = "/catalog/products/{product_id}/variants/{variant_id}/image";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVariantImage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVariantImage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ImageResponse) ApiClient.Deserialize(response.Content, typeof(ImageResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete a Product Variant Deletes a product *Variant*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void DeleteVariantById (int? productId, int? variantId, string accept, string contentType)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling DeleteVariantById");
            
            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling DeleteVariantById");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteVariantById");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteVariantById");
            
    
            var path = "/catalog/products/{product_id}/variants/{variant_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVariantById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVariantById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a Product Variant Returns a single product *Variant*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param> 
        /// <returns>VariantResponse</returns>            
        public VariantResponse GetVariantById (int? productId, int? variantId, string accept, string contentType, string includeFields, string excludeFields)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetVariantById");
            
            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling GetVariantById");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetVariantById");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetVariantById");
            
    
            var path = "/catalog/products/{product_id}/variants/{variant_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVariantById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVariantById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VariantResponse) ApiClient.Deserialize(response.Content, typeof(VariantResponse), response.Headers);
        }
    
        /// <summary>
        /// Get All Product Variants Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param> 
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param> 
        /// <returns>VariantCollectionResponse</returns>            
        public VariantCollectionResponse GetVariantsByProductId (int? productId, string accept, string contentType, int? page, int? limit, string includeFields, string excludeFields)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetVariantsByProductId");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetVariantsByProductId");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetVariantsByProductId");
            
    
            var path = "/catalog/products/{product_id}/variants";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
 if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVariantsByProductId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVariantsByProductId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VariantCollectionResponse) ApiClient.Deserialize(response.Content, typeof(VariantCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Update a Product Variant Updates a product *Variant*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param> 
        /// <param name="variant"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>VariantResponse</returns>            
        public VariantResponse UpdateVariant (int? productId, int? variantId, object variant, string accept, string contentType)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling UpdateVariant");
            
            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling UpdateVariant");
            
            // verify the required parameter 'variant' is set
            if (variant == null) throw new ApiException(400, "Missing required parameter 'variant' when calling UpdateVariant");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateVariant");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateVariant");
            
    
            var path = "/catalog/products/{product_id}/variants/{variant_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(variant); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVariant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVariant: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VariantResponse) ApiClient.Deserialize(response.Content, typeof(VariantResponse), response.Headers);
        }
    
    }
}
