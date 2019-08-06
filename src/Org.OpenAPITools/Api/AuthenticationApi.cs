/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.6.0.20190507.002
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate an access token for user authentication.
        /// </summary>
        /// <remarks>
        /// This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>AccessTokenResponse</returns>
        ApiResponse AuthenticationAccessTokensPost (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null);

        /// <summary>
        /// Generate an access token for user authentication.
        /// </summary>
        /// <remarks>
        /// This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        ApiResponse AuthenticationAccessTokensPostWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate an access token for user authentication.
        /// </summary>
        /// <remarks>
        /// This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>Task of AccessTokenResponse</returns>
        System.Threading.Tasks.Task<AccessTokenResponse> AuthenticationAccessTokensPostAsync (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null);

        /// <summary>
        /// Generate an access token for user authentication.
        /// </summary>
        /// <remarks>
        /// This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessTokenResponse>> AuthenticationAccessTokensPostAsyncWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IAuthenticationApiSync, IAuthenticationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticationApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Generate an access token for user authentication. This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>AccessTokenResponse</returns>
        public ApiResponse AuthenticationAccessTokensPost (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null)
        {
            ApiResponse localVarResponse = AuthenticationAccessTokensPostWithHttpInfo(contentType, clientRequestId, apiKey, timestamp, messageSignature);
            return localVarResponse;
        }

        /// <summary>
        /// Generate an access token for user authentication. This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        public ApiResponse AuthenticationAccessTokensPostWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'contentType' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'clientRequestId' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'apiKey' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            // verify the required parameter 'timestamp' is set
            if (timestamp == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'timestamp' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (contentType != null)
                requestOptions.HeaderParameters.Add("Content-Type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            if (clientRequestId != null)
                requestOptions.HeaderParameters.Add("Client-Request-Id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientRequestId)); // header parameter
            if (apiKey != null)
                requestOptions.HeaderParameters.Add("Api-Key", Org.OpenAPITools.Client.ClientUtils.ParameterToString(apiKey)); // header parameter
            if (timestamp != null)
                requestOptions.HeaderParameters.Add("Timestamp", Org.OpenAPITools.Client.ClientUtils.ParameterToString(timestamp)); // header parameter
            if (messageSignature != null)
                requestOptions.HeaderParameters.Add("Message-Signature", Org.OpenAPITools.Client.ClientUtils.ParameterToString(messageSignature)); // header parameter
            

            // make the HTTP request

            IRestResponse response = this.Client.Post("/authentication/access-tokens", requestOptions);

            int statusCode = (int)response.StatusCode;

            switch (statusCode){
                case 200:
                    return new ApiResponse(statusCode, (AccessTokenResponse)this.Client.Deserialize(response, typeof(AccessTokenResponse)), response.Headers);  
                default:
                    return new ApiResponse(statusCode, (ErrorResponse)this.Client.Deserialize(response, typeof(ErrorResponse)), response.Headers);
            }
        }

        /// <summary>
        /// Generate an access token for user authentication. This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>Task of AccessTokenResponse</returns>
        public async System.Threading.Tasks.Task<AccessTokenResponse> AuthenticationAccessTokensPostAsync (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null)
        {
             Org.OpenAPITools.Client.ApiResponse<AccessTokenResponse> localVarResponse = await AuthenticationAccessTokensPostAsyncWithHttpInfo(contentType, clientRequestId, apiKey, timestamp, messageSignature);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate an access token for user authentication. This is the access token generation call for authorizing subsequent financial transactions. A valid access token is required for web client requests.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<AccessTokenResponse>> AuthenticationAccessTokensPostAsyncWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, string messageSignature = null)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'contentType' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'clientRequestId' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'apiKey' when calling AuthenticationApi->AuthenticationAccessTokensPost");

            // verify the required parameter 'timestamp' is set
            if (timestamp == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'timestamp' when calling AuthenticationApi->AuthenticationAccessTokensPost");


            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (contentType != null)
                requestOptions.HeaderParameters.Add("Content-Type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            if (clientRequestId != null)
                requestOptions.HeaderParameters.Add("Client-Request-Id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientRequestId)); // header parameter
            if (apiKey != null)
                requestOptions.HeaderParameters.Add("Api-Key", Org.OpenAPITools.Client.ClientUtils.ParameterToString(apiKey)); // header parameter
            if (timestamp != null)
                requestOptions.HeaderParameters.Add("Timestamp", Org.OpenAPITools.Client.ClientUtils.ParameterToString(timestamp)); // header parameter
            if (messageSignature != null)
                requestOptions.HeaderParameters.Add("Message-Signature", Org.OpenAPITools.Client.ClientUtils.ParameterToString(messageSignature)); // header parameter


            // make the HTTP request

            var response = await this.AsynchronousClient.PostAsync<AccessTokenResponse>("/authentication/access-tokens", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthenticationAccessTokensPost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
