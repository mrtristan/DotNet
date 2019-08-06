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
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using RestSharp;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardVerificationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Verify a payment card.
        /// </summary>
        /// <remarks>
        /// Use this to perform card verification for a payment card.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>TransactionResponse</returns>
        ApiResponse VerifyCard (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null);

        /// <summary>
        /// Verify a payment card.
        /// </summary>
        /// <remarks>
        /// Use this to perform card verification for a payment card.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>ApiResponse of TransactionResponse</returns>
        ApiResponse VerifyCardWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardVerificationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Verify a payment card.
        /// </summary>
        /// <remarks>
        /// Use this to perform card verification for a payment card.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>Task of TransactionResponse</returns>
        System.Threading.Tasks.Task<TransactionResponse> VerifyCardAsync (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null);

        /// <summary>
        /// Verify a payment card.
        /// </summary>
        /// <remarks>
        /// Use this to perform card verification for a payment card.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>Task of ApiResponse (TransactionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionResponse>> VerifyCardAsyncWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardVerificationApi : ICardVerificationApiSync, ICardVerificationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardVerificationApi : ICardVerificationApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardVerificationApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardVerificationApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CardVerificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardVerificationApi(Org.OpenAPITools.Client.Configuration configuration)
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
        public CardVerificationApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Verify a payment card. Use this to perform card verification for a payment card.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>TransactionResponse</returns>
        public ApiResponse VerifyCard (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null)
        {
             ApiResponse localVarResponse = VerifyCardWithHttpInfo(contentType, clientRequestId, apiKey, timestamp, cardVerificationRequest, messageSignature, region);
             return localVarResponse;
        }

        /// <summary>
        /// Verify a payment card. Use this to perform card verification for a payment card.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>ApiResponse of TransactionResponse</returns>
        public ApiResponse VerifyCardWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'contentType' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'clientRequestId' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'apiKey' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'timestamp' is set
            if (timestamp == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'timestamp' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'cardVerificationRequest' is set
            if (cardVerificationRequest == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'cardVerificationRequest' when calling CardVerificationApi->VerifyCard");

            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
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
            if (region != null)
                requestOptions.HeaderParameters.Add("Region", Org.OpenAPITools.Client.ClientUtils.ParameterToString(region)); // header parameter
            requestOptions.Data = cardVerificationRequest;


            // make the HTTP request

            IRestResponse response = this.Client.Post("/card-verification", requestOptions);

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 200:
                    return new ApiResponse(statusCode, (TransactionResponse)this.Client.Deserialize(response, typeof(TransactionResponse)), response.Headers);
                default:
                    return new ApiResponse(statusCode, (ErrorResponse)this.Client.Deserialize(response, typeof(ErrorResponse)), response.Headers);
            }
        }

        /// <summary>
        /// Verify a payment card. Use this to perform card verification for a payment card.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>Task of TransactionResponse</returns>
        public async System.Threading.Tasks.Task<TransactionResponse> VerifyCardAsync (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null)
        {
             Org.OpenAPITools.Client.ApiResponse<TransactionResponse> localVarResponse = await VerifyCardAsyncWithHttpInfo(contentType, clientRequestId, apiKey, timestamp, cardVerificationRequest, messageSignature, region);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Verify a payment card. Use this to perform card verification for a payment card.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type.</param>
        /// <param name="clientRequestId">A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.</param>
        /// <param name="apiKey">Key given to merchant after boarding associating their requests with the appropriate app in Apigee.</param>
        /// <param name="timestamp">Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).</param>
        /// <param name="cardVerificationRequest">Accepted request type: CardVerificationRequest.</param>
        /// <param name="messageSignature">Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256 algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional)</param>
        /// <param name="region">Indicates the region where the client wants the transaction to be processed. This will override the default processing region identified for the client. Available options are argentina, brazil, germany, india and northamerica. Region specific store setup and APIGEE boarding is required in order to use an alternate region for processing. (optional)</param>
        /// <returns>Task of ApiResponse (TransactionResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<TransactionResponse>> VerifyCardAsyncWithHttpInfo (string contentType, string clientRequestId, string apiKey, long? timestamp, CardVerificationRequest cardVerificationRequest, string messageSignature = null, string region = null)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'contentType' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'clientRequestId' is set
            if (clientRequestId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'clientRequestId' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'apiKey' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'timestamp' is set
            if (timestamp == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'timestamp' when calling CardVerificationApi->VerifyCard");

            // verify the required parameter 'cardVerificationRequest' is set
            if (cardVerificationRequest == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'cardVerificationRequest' when calling CardVerificationApi->VerifyCard");


            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
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
            if (region != null)
                requestOptions.HeaderParameters.Add("Region", Org.OpenAPITools.Client.ClientUtils.ParameterToString(region)); // header parameter
            requestOptions.Data = cardVerificationRequest;


            // make the HTTP request

            var response = await this.AsynchronousClient.PostAsync<TransactionResponse>("/card-verification", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("VerifyCard", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
