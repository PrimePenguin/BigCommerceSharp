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
    public interface IShippingCarrierApi
    {
        /// <summary>
        /// Delete a Carrier Connection Deletes a *Carrier Connection*.  **Required Fields** * carrier_id
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void DeleteCarrierConnection (string accept, string contentType, Body body);
        /// <summary>
        /// Create a Carrier Connection Creates a *Carrier Connection*.   Carrier connections refer to specific settings required to connect to a specific shipping carrier. Each carrier requires your app to supply a unique set of properties/fields to establish a connection with that carrier.  *Notes:*  - There is no &#x60;GET&#x60; with this resource. It has &#x60;PUT&#x60;, &#x60;POST&#x60; and &#x60;DELETE&#x60;.     * &#x60;PUT&#x60; is used to update. The connection can be updated via API.      - Connections created here do not enable the shipping method. To enable the carrier for a shipping zone, use the Shipping Methods API.   - The Carrier Connection resource returns a 204 for both succesful and unsuccesful attempts to connect. If a field is missing, it will return a 400.  ### Australia Post  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;auspost\&quot;,  \&quot;connection\&quot; : {   \&quot;auth_key\&quot; : \&quot;yourAusPostAuthKey\&quot;,   \&quot;test_mode\&quot; : false  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;auspost\&quot; } &#x60;&#x60;&#x60;  #### Australia Post Connection Object – Properties  Australia Post &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description | - | - | - | | auth_key | string | Australia Post authorization key. | | test_mode | boolean | Whether or not to use Australia Post test-mode settings. Acceptable values are &#x60;true&#x60; or &#x60;false&#x60;. |   ### Endicia USPS is connected through Endicia.  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json { \&quot;carrier_id\&quot; : \&quot;endicia\&quot;,  \&quot;connection\&quot;: {   \&quot;account_id\&quot; : \&quot;yourEndiciaAccountId\&quot;,   \&quot;pass_phrase\&quot; : \&quot;yourEndiciaPassphrase\&quot;  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;endicia\&quot; } &#x60;&#x60;&#x60;  #### Endicia Connection Object – Properties  Endicia &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description | | - | - | - | | account_id | string | Endicia account ID. | | passphrase | string | Endicia passphrase. |   ### FedEx  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;fedex\&quot;,  \&quot;connection\&quot; : {   \&quot;key\&quot; : \&quot;yourFedexKey\&quot;,   \&quot;password\&quot; : \&quot;yourFedexPassword\&quot;,   \&quot;account_number\&quot; : \&quot;yourFedexAccountNumber\&quot;,   \&quot;meter_number\&quot; : \&quot;yourFedexMeterNumber\&quot;  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;fedex\&quot; } &#x60;&#x60;&#x60;  #### FedEx Connection Object – Properties  FedEx &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description |  | - | - | - | | key | string | FedEx account ID. |  | password | string | FedEx passphrase. | | account_number | string | FedEx account number. | | meter_number | string | FedEx meter number. |  ### Royal Mail  Sample Request - PUT or POST  &#x60;&#x60;&#x60;json {     \&quot;carrier_id\&quot; : \&quot;royalmail\&quot;,     \&quot;connection\&quot; : {              } } &#x60;&#x60;&#x60;  Sample Request - DELETE  &#x60;&#x60;&#x60;json {     \&quot;carrier_id\&quot; : \&quot;royalmail\&quot; } &#x60;&#x60;&#x60;  #### Royal Mail Connection Object - Properties  Royal Mail has no connection object properties.   ### Zoom2U  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;zoom2u\&quot;,  \&quot;connection\&quot; : {   \&quot;auth_key\&quot; : \&quot;yourZoom2uAuthKey\&quot;,   \&quot;test_mode\&quot; : false  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;zoom2u\&quot; } &#x60;&#x60;&#x60;  #### Zoom2U Connection Object – Properties  Zoom2U &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description |  | - | - | - | | auth_key | string | Zoom2U authorization key. | | test_mode | boolean | Whether or not to use Zoom2U test-mode settings. Acceptable values are &#x60;true&#x60; or &#x60;false&#x60;. |
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ShippingCarrierConnectionPost (string accept, string contentType, Object body);
        /// <summary>
        /// Update a Carrier Connection Updates a *Carrier Connection*.  Updating the carrier connection is done using the same information as creating the connection. This endpoint can be used to update credentials.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body">The request body will vary by carrier. See [Create a Carrier Connection](/api-reference/store-management/shipping-api/shipping-carrier/postshippingcarrierconnection). </param>
        /// <returns></returns>
        void UpdateACarrierConnection (string accept, string contentType, Object body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingCarrierApi : IShippingCarrierApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingCarrierApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingCarrierApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingCarrierApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingCarrierApi(String basePath)
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
        /// Delete a Carrier Connection Deletes a *Carrier Connection*.  **Required Fields** * carrier_id
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void DeleteCarrierConnection (string accept, string contentType, Body body)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling DeleteCarrierConnection");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling DeleteCarrierConnection");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteCarrierConnection");
            
    
            var path = "/shipping/carrier/connection";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCarrierConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCarrierConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a Carrier Connection Creates a *Carrier Connection*.   Carrier connections refer to specific settings required to connect to a specific shipping carrier. Each carrier requires your app to supply a unique set of properties/fields to establish a connection with that carrier.  *Notes:*  - There is no &#x60;GET&#x60; with this resource. It has &#x60;PUT&#x60;, &#x60;POST&#x60; and &#x60;DELETE&#x60;.     * &#x60;PUT&#x60; is used to update. The connection can be updated via API.      - Connections created here do not enable the shipping method. To enable the carrier for a shipping zone, use the Shipping Methods API.   - The Carrier Connection resource returns a 204 for both succesful and unsuccesful attempts to connect. If a field is missing, it will return a 400.  ### Australia Post  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;auspost\&quot;,  \&quot;connection\&quot; : {   \&quot;auth_key\&quot; : \&quot;yourAusPostAuthKey\&quot;,   \&quot;test_mode\&quot; : false  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;auspost\&quot; } &#x60;&#x60;&#x60;  #### Australia Post Connection Object – Properties  Australia Post &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description | - | - | - | | auth_key | string | Australia Post authorization key. | | test_mode | boolean | Whether or not to use Australia Post test-mode settings. Acceptable values are &#x60;true&#x60; or &#x60;false&#x60;. |   ### Endicia USPS is connected through Endicia.  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json { \&quot;carrier_id\&quot; : \&quot;endicia\&quot;,  \&quot;connection\&quot;: {   \&quot;account_id\&quot; : \&quot;yourEndiciaAccountId\&quot;,   \&quot;pass_phrase\&quot; : \&quot;yourEndiciaPassphrase\&quot;  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;endicia\&quot; } &#x60;&#x60;&#x60;  #### Endicia Connection Object – Properties  Endicia &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description | | - | - | - | | account_id | string | Endicia account ID. | | passphrase | string | Endicia passphrase. |   ### FedEx  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;fedex\&quot;,  \&quot;connection\&quot; : {   \&quot;key\&quot; : \&quot;yourFedexKey\&quot;,   \&quot;password\&quot; : \&quot;yourFedexPassword\&quot;,   \&quot;account_number\&quot; : \&quot;yourFedexAccountNumber\&quot;,   \&quot;meter_number\&quot; : \&quot;yourFedexMeterNumber\&quot;  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;fedex\&quot; } &#x60;&#x60;&#x60;  #### FedEx Connection Object – Properties  FedEx &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description |  | - | - | - | | key | string | FedEx account ID. |  | password | string | FedEx passphrase. | | account_number | string | FedEx account number. | | meter_number | string | FedEx meter number. |  ### Royal Mail  Sample Request - PUT or POST  &#x60;&#x60;&#x60;json {     \&quot;carrier_id\&quot; : \&quot;royalmail\&quot;,     \&quot;connection\&quot; : {              } } &#x60;&#x60;&#x60;  Sample Request - DELETE  &#x60;&#x60;&#x60;json {     \&quot;carrier_id\&quot; : \&quot;royalmail\&quot; } &#x60;&#x60;&#x60;  #### Royal Mail Connection Object - Properties  Royal Mail has no connection object properties.   ### Zoom2U  #### Sample Request – PUT or POST  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;zoom2u\&quot;,  \&quot;connection\&quot; : {   \&quot;auth_key\&quot; : \&quot;yourZoom2uAuthKey\&quot;,   \&quot;test_mode\&quot; : false  } } &#x60;&#x60;&#x60;  #### Sample Request – DELETE  &#x60;&#x60;&#x60;json {  \&quot;carrier_id\&quot; : \&quot;zoom2u\&quot; } &#x60;&#x60;&#x60;  #### Zoom2U Connection Object – Properties  Zoom2U &#x60;PUT&#x60; or &#x60;POST&#x60; requests require all of the following properties. (These requests won’t be fulfilled unless these properties are valid.) &#x60;DELETE&#x60; requests require only a &#x60;carrier_id&#x60;.   | Property | Type | Description |  | - | - | - | | auth_key | string | Zoom2U authorization key. | | test_mode | boolean | Whether or not to use Zoom2U test-mode settings. Acceptable values are &#x60;true&#x60; or &#x60;false&#x60;. |
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ShippingCarrierConnectionPost (string accept, string contentType, Object body)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling ShippingCarrierConnectionPost");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling ShippingCarrierConnectionPost");
            
    
            var path = "/shipping/carrier/connection";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingCarrierConnectionPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ShippingCarrierConnectionPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a Carrier Connection Updates a *Carrier Connection*.  Updating the carrier connection is done using the same information as creating the connection. This endpoint can be used to update credentials.
        /// </summary>
        /// <param name="accept"></param> 
        /// <param name="contentType"></param> 
        /// <param name="body">The request body will vary by carrier. See [Create a Carrier Connection](/api-reference/store-management/shipping-api/shipping-carrier/postshippingcarrierconnection). </param> 
        /// <returns></returns>            
        public void UpdateACarrierConnection (string accept, string contentType, Object body)
        {
            
            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling UpdateACarrierConnection");
            
            // verify the required parameter 'contentType' is set
            if (contentType == null) throw new ApiException(400, "Missing required parameter 'contentType' when calling UpdateACarrierConnection");
            
    
            var path = "/shipping/carrier/connection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateACarrierConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateACarrierConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
