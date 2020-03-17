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
    public interface IProductsApi
    {
        /// <summary>
        /// Create a Product Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;categories&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;
        /// </summary>
        /// <param name="product"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <returns>ProductResponse</returns>
        ProductResponse CreateProduct (ProductBase1 product, string contentType, string accept, string includeFields);
        /// <summary>
        /// Delete a Product Deletes a *Product*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteProductById (int? productId, string accept, string contentType);
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
        /// Get a Product Returns a single *Product*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use:  &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60;</param>
        /// <returns>ProductResponse</returns>
        ProductResponse GetProductById (int? productId, string accept, string contentType, string include, string includeFields, string excludeFields, int? priceListId);
        /// <summary>
        /// Get All Products Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </summary>
        /// <param name="id">Filter items by id. </param>
        /// <param name="name">Filter items by name. </param>
        /// <param name="sku">Filter items by sku. </param>
        /// <param name="upc">Filter items by upc. </param>
        /// <param name="price">Filter items by price. </param>
        /// <param name="weight">Filter items by weight. </param>
        /// <param name="condition">Filter items by condition. </param>
        /// <param name="brandId">Filter items by brand_id. </param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60;</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60;</param>
        /// <param name="isVisible">Filter items by if visible on the storefront. </param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false. </param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping. </param>
        /// <param name="inventoryLevel">Filter items by inventory_level. </param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0. </param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;. </param>
        /// <param name="totalSold">Filter items by total_sold. </param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;.</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;.</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name. </param>
        /// <param name="keywordContext">Set context for a product search.</param>
        /// <param name="status">Filter items by status. </param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page.</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder. </param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use:  &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60;</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;. </param>
        /// <param name="sort">Field name to sort by. </param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetProducts (int? id, string name, string sku, string upc, decimal? price, decimal? weight, string condition, int? brandId, DateTime? dateModified, DateTime? dateLastImported, bool? isVisible, int? isFeatured, int? isFreeShipping, int? inventoryLevel, int? inventoryLow, int? outOfStock, int? totalSold, string type, int? categories, string keyword, string keywordContext, int? status, string include, string includeFields, string excludeFields, string availability, int? priceListId, int? page, int? limit, string direction, string sort);
        /// <summary>
        /// Update a Product Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="product"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <returns>ProductResponse</returns>
        ProductResponse UpdateProduct (int? productId, object product, string accept, string contentType, string includeFields);
        /// <summary>
        /// Update Products (Batch) Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 UpdateProducts (string accept, string contentType, List<List<object>> body, string includeFields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductsApi : IProductsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsApi(string basePath)
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
        /// Create a Product Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;categories&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;
        /// </summary>
        /// <param name="product"></param> 
        /// <param name="contentType"></param> 
        /// <param name="accept"></param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <returns>ProductResponse</returns>            
        public ProductResponse CreateProduct (ProductBase1 product, string contentType, string accept, string includeFields)
        {
            
            // verify the required parameter 'product' is set
            if (product == null) throw new ApiException(400, "Missing required parameter 'product' when calling CreateProduct");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateProduct");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateProduct");
            
    
            var path = "/catalog/products";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
             if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
             if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
 if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
                        postBody = ApiClient.Serialize(product); // http body (model) parameter
    
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateProduct: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateProduct: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProductResponse) ApiClient.Deserialize(response.Content, typeof(ProductResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete a Product Deletes a *Product*.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void DeleteProductById (int? productId, string accept, string contentType)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling DeleteProductById");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteProductById");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteProductById");
            
    
            var path = "/catalog/products/{product_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProductById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProductById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
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
                
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
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
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProducts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a Product Returns a single *Product*. Optional parameters can be passed in.
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page.</param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param> 
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use:  &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60;</param> 
        /// <returns>ProductResponse</returns>            
        public ProductResponse GetProductById (int? productId, string accept, string contentType, string include, string includeFields, string excludeFields, int? priceListId)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling GetProductById");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetProductById");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetProductById");
            
    
            var path = "/catalog/products/{product_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
    
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
             if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
 if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
 if (priceListId != null) queryParams.Add("price_list_id", ApiClient.ParameterToString(priceListId)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                            
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProductResponse) ApiClient.Deserialize(response.Content, typeof(ProductResponse), response.Headers);
        }
    
        /// <summary>
        /// Get All Products Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </summary>
        /// <param name="id">Filter items by id. </param> 
        /// <param name="name">Filter items by name. </param> 
        /// <param name="sku">Filter items by sku. </param> 
        /// <param name="upc">Filter items by upc. </param> 
        /// <param name="price">Filter items by price. </param> 
        /// <param name="weight">Filter items by weight. </param> 
        /// <param name="condition">Filter items by condition. </param> 
        /// <param name="brandId">Filter items by brand_id. </param> 
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60;</param> 
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60;</param> 
        /// <param name="isVisible">Filter items by if visible on the storefront. </param> 
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false. </param> 
        /// <param name="isFreeShipping">Filter items by is_free_shipping. </param> 
        /// <param name="inventoryLevel">Filter items by inventory_level. </param> 
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0. </param> 
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;. </param> 
        /// <param name="totalSold">Filter items by total_sold. </param> 
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;.</param> 
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;.</param> 
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name. </param> 
        /// <param name="keywordContext">Set context for a product search.</param> 
        /// <param name="status">Filter items by status. </param> 
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page.</param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded.</param> 
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder. </param> 
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use:  &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60;</param> 
        /// <param name="page">Specifies the page number in a limited (paginated) list of products.</param> 
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products.</param> 
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;. </param> 
        /// <param name="sort">Field name to sort by. </param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 GetProducts (int? id, string name, string sku, string upc, decimal? price, decimal? weight, string condition, int? brandId, DateTime? dateModified, DateTime? dateLastImported, bool? isVisible, int? isFeatured, int? isFreeShipping, int? inventoryLevel, int? inventoryLow, int? outOfStock, int? totalSold, string type, int? categories, string keyword, string keywordContext, int? status, string include, string includeFields, string excludeFields, string availability, int? priceListId, int? page, int? limit, string direction, string sort)
        {
            
    
            var path = "/catalog/products";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (sku != null) queryParams.Add("sku", ApiClient.ParameterToString(sku)); // query parameter
 if (upc != null) queryParams.Add("upc", ApiClient.ParameterToString(upc)); // query parameter
 if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
 if (weight != null) queryParams.Add("weight", ApiClient.ParameterToString(weight)); // query parameter
 if (condition != null) queryParams.Add("condition", ApiClient.ParameterToString(condition)); // query parameter
 if (brandId != null) queryParams.Add("brand_id", ApiClient.ParameterToString(brandId)); // query parameter
 if (dateModified != null) queryParams.Add("date_modified", ApiClient.ParameterToString(dateModified)); // query parameter
 if (dateLastImported != null) queryParams.Add("date_last_imported", ApiClient.ParameterToString(dateLastImported)); // query parameter
 if (isVisible != null) queryParams.Add("is_visible", ApiClient.ParameterToString(isVisible)); // query parameter
 if (isFeatured != null) queryParams.Add("is_featured", ApiClient.ParameterToString(isFeatured)); // query parameter
 if (isFreeShipping != null) queryParams.Add("is_free_shipping", ApiClient.ParameterToString(isFreeShipping)); // query parameter
 if (inventoryLevel != null) queryParams.Add("inventory_level", ApiClient.ParameterToString(inventoryLevel)); // query parameter
 if (inventoryLow != null) queryParams.Add("inventory_low", ApiClient.ParameterToString(inventoryLow)); // query parameter
 if (outOfStock != null) queryParams.Add("out_of_stock", ApiClient.ParameterToString(outOfStock)); // query parameter
 if (totalSold != null) queryParams.Add("total_sold", ApiClient.ParameterToString(totalSold)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (keyword != null) queryParams.Add("keyword", ApiClient.ParameterToString(keyword)); // query parameter
 if (keywordContext != null) queryParams.Add("keyword_context", ApiClient.ParameterToString(keywordContext)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
 if (excludeFields != null) queryParams.Add("exclude_fields", ApiClient.ParameterToString(excludeFields)); // query parameter
 if (availability != null) queryParams.Add("availability", ApiClient.ParameterToString(availability)); // query parameter
 if (priceListId != null) queryParams.Add("price_list_id", ApiClient.ParameterToString(priceListId)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProducts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Update a Product Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </summary>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param> 
        /// <param name="product"></param> 
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <returns>ProductResponse</returns>            
        public ProductResponse UpdateProduct (int? productId, object product, string accept, string contentType, string includeFields)
        {
            
            // verify the required parameter 'productId' is set
            if (productId == null) throw new ApiException(400, "Missing required parameter 'productId' when calling UpdateProduct");
            
            // verify the required parameter 'product' is set
            if (product == null) throw new ApiException(400, "Missing required parameter 'product' when calling UpdateProduct");
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateProduct");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateProduct");
            
    
            var path = "/catalog/products/{product_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "product_id" + "}", ApiClient.ParameterToString(productId));
    
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
             if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(product); // http body (model) parameter
    
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProduct: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProduct: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProductResponse) ApiClient.Deserialize(response.Content, typeof(ProductResponse), response.Headers);
        }
    
        /// <summary>
        /// Update Products (Batch) Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned.</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 UpdateProducts (string accept, string contentType, List<List<object>> body, string includeFields)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateProducts");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateProducts");
            
    
            var path = "/catalog/products";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;
    
             if (includeFields != null) queryParams.Add("include_fields", ApiClient.ParameterToString(includeFields)); // query parameter
             if (accept != null) headerParams.Add("Accept", ApiClient.ParameterToString(accept)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            string[] authSettings = new string[] { "X-Auth-Client", "X-Auth-Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProducts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
    }
}
