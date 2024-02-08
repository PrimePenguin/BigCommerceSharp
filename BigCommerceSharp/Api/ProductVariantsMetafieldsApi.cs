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
    public interface IProductVariantsMetafieldsApi
    {
        /// <summary>
        /// Create a Product Variant Metafield Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="metafield"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>MetafieldResponse</returns>
        MetafieldResponse CreateVariantMetafield(int? productId, int? variantId, object metafield, string accept, string contentType);
        /// <summary>
        /// Delete a Variant Metafield Deletes a product variant *Metafield*.
        /// </summary>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteVariantMetafieldById(int? metafieldId, int? productId, int? variantId, string accept, string contentType);
        /// <summary>
        /// Get Product Variant Metafields Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>MetafieldResponse</returns>
        MetafieldResponse GetVariantMetafieldByProductIdAndVariantId(int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields, string excludeFields);
        /// <summary>
        /// Get Product Variant Metafields Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="key">Filter based on a metafield&#39;s key. </param>
        /// <param name="_namespace">Filter based on a metafield&#39;s namespace.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>MetaFieldCollectionResponse</returns>
        MetaFieldCollectionResponse GetVariantMetafieldsByProductIdAndVariantId(int? productId, int? variantId, string accept, string contentType, int? page, int? limit, string key, string _namespace, string includeFields, string excludeFields);
        /// <summary>
        /// Update Product Variant Metafields Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message.
        /// </summary>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="metafield"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>MetafieldResponse</returns>
        MetafieldResponse UpdateVariantMetafield(int? metafieldId, int? productId, int? variantId, object metafield, string accept, string contentType);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductVariantsMetafieldsApi : IProductVariantsMetafieldsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsMetafieldsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductVariantsMetafieldsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsMetafieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductVariantsMetafieldsApi(string basePath)
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
        /// Create a Product Variant Metafield Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="metafield"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>MetafieldResponse</returns>
        public MetafieldResponse CreateVariantMetafield(int? productId, int? variantId, object metafield, string accept, string contentType)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling CreateVariantMetafield");

            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling CreateVariantMetafield");

            // verify the required parameter 'metafield' is set
            if (metafield == null) throw new ApiException(400, "Missing required parameter 'metafield' when calling CreateVariantMetafield");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateVariantMetafield");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateVariantMetafield");


            var path = "/catalog/products/{product_id}/variants/{variant_id}/metafields";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(metafield); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateVariantMetafield: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateVariantMetafield: " + response.ErrorMessage, response.ErrorMessage);

            return (MetafieldResponse)ApiClient.Deserialize(response.Content, typeof(MetafieldResponse), response.Headers);
        }

        /// <summary>
        /// Delete a Variant Metafield Deletes a product variant *Metafield*.
        /// </summary>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteVariantMetafieldById(int? metafieldId, int? productId, int? variantId, string accept, string contentType)
        {

            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null) throw new ApiException(400, "Missing required parameter 'metafieldId' when calling DeleteVariantMetafieldById");

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling DeleteVariantMetafieldById");

            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling DeleteVariantMetafieldById");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteVariantMetafieldById");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteVariantMetafieldById");


            var path = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "metafield_id" + "}", ApiClient.ParameterToString(metafieldId));
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));

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
            var response = (RestResponse)ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteVariantMetafieldById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteVariantMetafieldById: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>MetafieldResponse</returns>
        public MetafieldResponse GetVariantMetafieldByProductIdAndVariantId(int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields, string excludeFields)
        {

            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null) throw new ApiException(400, "Missing required parameter 'metafieldId' when calling GetVariantMetafieldByProductIdAndVariantId");

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetVariantMetafieldByProductIdAndVariantId");

            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling GetVariantMetafieldByProductIdAndVariantId");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetVariantMetafieldByProductIdAndVariantId");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetVariantMetafieldByProductIdAndVariantId");


            var path = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "metafield_id" + "}", ApiClient.ParameterToString(metafieldId));
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
            if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetVariantMetafieldByProductIdAndVariantId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetVariantMetafieldByProductIdAndVariantId: " + response.ErrorMessage, response.ErrorMessage);

            return (MetafieldResponse)ApiClient.Deserialize(response.Content, typeof(MetafieldResponse), response.Headers);
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="key">Filter based on a metafield&#39;s key. </param>
        /// <param name="_namespace">Filter based on a metafield&#39;s namespace.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <returns>MetaFieldCollectionResponse</returns>
        public MetaFieldCollectionResponse GetVariantMetafieldsByProductIdAndVariantId(int? productId, int? variantId, string accept, string contentType, int? page, int? limit, string key, string _namespace, string includeFields, string excludeFields)
        {

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetVariantMetafieldsByProductIdAndVariantId");

            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling GetVariantMetafieldsByProductIdAndVariantId");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetVariantMetafieldsByProductIdAndVariantId");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetVariantMetafieldsByProductIdAndVariantId");


            var path = "/catalog/products/{product_id}/variants/{variant_id}/metafields";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            if (_namespace != null) queryParams.Add("namespace", ApiClient.ParameterToString(_namespace)); // query parameter
            if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
            if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetVariantMetafieldsByProductIdAndVariantId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetVariantMetafieldsByProductIdAndVariantId: " + response.ErrorMessage, response.ErrorMessage);

            return (MetaFieldCollectionResponse)ApiClient.Deserialize(response.Content, typeof(MetaFieldCollectionResponse), response.Headers);
        }

        /// <summary>
        /// Update Product Variant Metafields Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message.
        /// </summary>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="metafield"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>MetafieldResponse</returns>
        public MetafieldResponse UpdateVariantMetafield(int? metafieldId, int? productId, int? variantId, object metafield, string accept, string contentType)
        {

            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null) throw new ApiException(400, "Missing required parameter 'metafieldId' when calling UpdateVariantMetafield");

            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling UpdateVariantMetafield");

            // verify the required parameter 'variantId' is set
            if (variantId == null) throw new ApiException(400, "Missing required parameter 'variantId' when calling UpdateVariantMetafield");

            // verify the required parameter 'metafield' is set
            if (metafield == null) throw new ApiException(400, "Missing required parameter 'metafield' when calling UpdateVariantMetafield");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateVariantMetafield");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateVariantMetafield");


            var path = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "metafield_id" + "}", ApiClient.ParameterToString(metafieldId));
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
            path = path.Replace("{" + "variant_id" + "}", ApiClient.ParameterToString(variantId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            postBody = ApiClient.Serialize(metafield); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };

            // make the HTTP request
            var response = (RestResponse)ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateVariantMetafield: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateVariantMetafield: " + response.ErrorMessage, response.ErrorMessage);

            return (MetafieldResponse)ApiClient.Deserialize(response.Content, typeof(MetafieldResponse), response.Headers);
        }

    }
}
