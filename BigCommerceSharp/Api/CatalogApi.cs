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
    public interface ICatalogApi
    {
        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#39;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name. </param>
        /// <param name="sku">Filter items by sku. </param>
        /// <param name="price">Filter items by price. </param>
        /// <param name="weight">Filter items by weight. </param>
        /// <param name="condition">Filter items by condition. </param>
        /// <param name="brandId">Filter items by brand_id. </param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60;</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60;</param>
        /// <param name="isVisible">Filter items by if visible on the storefront. </param>
        /// <param name="isFeatured">Filter items by is_featured. </param>
        /// <param name="inventoryLevel">Filter items by inventory_level. </param>
        /// <param name="totalSold">Filter items by total_sold. </param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;.</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;.</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name. </param>
        /// <returns></returns>
        void DeleteProducts (string accept, string contentType, string name, string sku, decimal? price, decimal? weight, string condition, int? brandId, DateTime? dateModified, DateTime? dateLastImported, bool? isVisible, int? isFeatured, int? inventoryLevel, int? totalSold, string type, int? categories, string keyword);
        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>VariantCollectionResponse</returns>
        VariantCollectionResponse UpdateVariantsBatch (List<Object> body, string accept, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CatalogApi : ICatalogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CatalogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CatalogApi(String basePath)
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
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#39;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="name">Filter items by name. </param> 
        /// <param name="sku">Filter items by sku. </param> 
        /// <param name="price">Filter items by price. </param> 
        /// <param name="weight">Filter items by weight. </param> 
        /// <param name="condition">Filter items by condition. </param> 
        /// <param name="brandId">Filter items by brand_id. </param> 
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60;</param> 
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60;</param> 
        /// <param name="isVisible">Filter items by if visible on the storefront. </param> 
        /// <param name="isFeatured">Filter items by is_featured. </param> 
        /// <param name="inventoryLevel">Filter items by inventory_level. </param> 
        /// <param name="totalSold">Filter items by total_sold. </param> 
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;.</param> 
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;.</param> 
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name. </param> 
        /// <returns></returns>            
        public void DeleteProducts (string accept, string contentType, string name, string sku, decimal? price, decimal? weight, string condition, int? brandId, DateTime? dateModified, DateTime? dateLastImported, bool? isVisible, int? isFeatured, int? inventoryLevel, int? totalSold, string type, int? categories, string keyword)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteProducts");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteProducts");
            
    
            var path = "/catalog/products";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (sku != null) queryParams.Add("sku", ApiClient.ParameterToString(sku)); // query parameter
 if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
 if (weight != null) queryParams.Add("weight", ApiClient.ParameterToString(weight)); // query parameter
 if (condition != null) queryParams.Add("condition", ApiClient.ParameterToString(condition)); // query parameter
 if (brandId != null) queryParams.Add("brand_id", ApiClient.ParameterToString(brandId)); // query parameter
 if (dateModified != null) queryParams.Add("date_modified", ApiClient.ParameterToString(dateModified)); // query parameter
 if (dateLastImported != null) queryParams.Add("date_last_imported", ApiClient.ParameterToString(dateLastImported)); // query parameter
 if (isVisible != null) queryParams.Add("is_visible", ApiClient.ParameterToString(isVisible)); // query parameter
 if (isFeatured != null) queryParams.Add("is_featured", ApiClient.ParameterToString(isFeatured)); // query parameter
 if (inventoryLevel != null) queryParams.Add("inventory_level", ApiClient.ParameterToString(inventoryLevel)); // query parameter
 if (totalSold != null) queryParams.Add("total_sold", ApiClient.ParameterToString(totalSold)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (keyword != null) queryParams.Add("keyword", ApiClient.ParameterToString(keyword)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProducts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns>VariantCollectionResponse</returns>            
        public VariantCollectionResponse UpdateVariantsBatch (List<Object> body, string accept, string contentType)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateVariantsBatch");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateVariantsBatch");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateVariantsBatch");
            
    
            var path = "/catalog/variants";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVariantsBatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVariantsBatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VariantCollectionResponse) ApiClient.Deserialize(response.Content, typeof(VariantCollectionResponse), response.Headers);
        }
    
    }
}
