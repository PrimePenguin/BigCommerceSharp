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
    public interface IShippingZonesApi
    {
        /// <summary>
        /// Create a Shipping Zone Creates a *Shipping Zone*.  **Required Fields** * name
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingZone2</returns>
        ShippingZone2 CreateAShippingZones(string accept, string contentType, ShippingZone1 body);
        /// <summary>
        /// Delete a Shipping Zone Deletes a *Shipping Zone*.
        /// </summary>
        /// <param name="id">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteAShippingZone(int? id, string accept, string contentType);
        /// <summary>
        /// Get a Shipping Zones Returns a single *Shipping Zone*.
        /// </summary>
        /// <param name="id">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ShippingZone2</returns>
        ShippingZone2 GetAShippingZone(int? id, string accept, string contentType);
        /// <summary>
        /// Get All Shipping Zones Returns a list of all *Shipping Zones*.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;ShippingZone&gt;</returns>
        List<ShippingZone> GetAllShippingZones(string accept, string contentType);
        /// <summary>
        /// Update a Shipping Zone Updates a *Shipping Zone*.  **Required Fields** * name  **Read Only Fields** * id
        /// </summary>
        /// <param name="id">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingZone2</returns>
        ShippingZone2 UpdateAShippingZone(int? id, string accept, string contentType, ShippingZone3 body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingZonesApi : IShippingZonesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingZonesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingZonesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingZonesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingZonesApi(string basePath)
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
        /// Create a Shipping Zone Creates a *Shipping Zone*.  **Required Fields** * name
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingZone2</returns>
        public ShippingZone2 CreateAShippingZones(string accept, string contentType, ShippingZone1 body)
        {

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling CreateAShippingZones");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateAShippingZones");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAShippingZones");


            var path = "/shipping/zones";
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
            var response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAShippingZones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAShippingZones: " + response.ErrorMessage, response.ErrorMessage);

            return (ShippingZone2)ApiClient.Deserialize(response.Content, typeof(ShippingZone2), response.Headers);
        }

        /// <summary>
        /// Delete a Shipping Zone Deletes a *Shipping Zone*.
        /// </summary>
        /// <param name="id">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteAShippingZone(int? id, string accept, string contentType)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAShippingZone");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteAShippingZone");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteAShippingZone");


            var path = "/shipping/zones/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

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
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAShippingZone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteAShippingZone: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get a Shipping Zones Returns a single *Shipping Zone*.
        /// </summary>
        /// <param name="id">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ShippingZone2</returns>
        public ShippingZone2 GetAShippingZone(int? id, string accept, string contentType)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAShippingZone");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAShippingZone");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAShippingZone");


            var path = "/shipping/zones/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

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
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAShippingZone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAShippingZone: " + response.ErrorMessage, response.ErrorMessage);

            return (ShippingZone2)ApiClient.Deserialize(response.Content, typeof(ShippingZone2), response.Headers);
        }

        /// <summary>
        /// Get All Shipping Zones Returns a list of all *Shipping Zones*.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>List&lt;ShippingZone&gt;</returns>
        public List<ShippingZone> GetAllShippingZones(string accept, string contentType)
        {

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetAllShippingZones");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling GetAllShippingZones");


            var path = "/shipping/zones";
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
            var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllShippingZones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllShippingZones: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ShippingZone>)ApiClient.Deserialize(response.Content, typeof(List<ShippingZone>), response.Headers);
        }

        /// <summary>
        /// Update a Shipping Zone Updates a *Shipping Zone*.  **Required Fields** * name  **Read Only Fields** * id
        /// </summary>
        /// <param name="id">Id of the shipping zone.</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns>ShippingZone2</returns>
        public ShippingZone2 UpdateAShippingZone(int? id, string accept, string contentType, ShippingZone3 body)
        {

            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAShippingZone");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateAShippingZone");

            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateAShippingZone");

            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAShippingZone");


            var path = "/shipping/zones/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

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
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAShippingZone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAShippingZone: " + response.ErrorMessage, response.ErrorMessage);

            return (ShippingZone2)ApiClient.Deserialize(response.Content, typeof(ShippingZone2), response.Headers);
        }

    }
}
