# Org.OpenAPITools.Api.CardInfoLookupApi

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CardInfoLookup**](CardInfoLookupApi.md#cardinfolookup) | **POST** /v1/card-information | Card information lookUp


<a name="cardinfolookup"></a>
# **CardInfoLookup**
> CardInfoLookupResponse CardInfoLookup (string contentType, string clientRequestId, string apiKey, long? timestamp, CardInfoLookupRequest cardInfoLookupRequest, string messageSignature, string region)

Card information lookUp

Use this to look up card related information such as issuer country, card function and card brand.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CardInfoLookupExample
    {
        public void main()
        {
            
            var apiInstance = new CardInfoLookupApi();
            var contentType = contentType_example;  // string | content type (default to application/json)
            var clientRequestId = clientRequestId_example;  // string | A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format.
            var apiKey = apiKey_example;  // string | 
            var timestamp = 789;  // long? | Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins).
            var cardInfoLookupRequest = new CardInfoLookupRequest(); // CardInfoLookupRequest | Card information lookup payload.
            var messageSignature = messageSignature_example;  // string | Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. (optional) 
            var region = region_example;  // string | The region where client wants to process the transaction (optional) 

            try
            {
                // Card information lookUp
                CardInfoLookupResponse result = apiInstance.CardInfoLookup(contentType, clientRequestId, apiKey, timestamp, cardInfoLookupRequest, messageSignature, region);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardInfoLookupApi.CardInfoLookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**| content type | [default to application/json]
 **clientRequestId** | **string**| A client-generated ID for request tracking and signature creation, unique per request.  This is also used for idempotency control. We recommend 128-bit UUID format. | 
 **apiKey** | **string**|  | 
 **timestamp** | **long?**| Epoch timestamp in milliseconds in the request from a client system. Used for Message Signature generation and time limit (5 mins). | 
 **cardInfoLookupRequest** | [**CardInfoLookupRequest**](CardInfoLookupRequest.md)| Card information lookup payload. | 
 **messageSignature** | **string**| Used to ensure the request has not been tampered with during transmission. The Message-Signature is the Base64 encoded HMAC hash (SHA256  algorithm with the API Secret as the key.) For more information, refer to the supporting documentation on the Developer Portal. | [optional] 
 **region** | **string**| The region where client wants to process the transaction | [optional] 

### Return type

[**CardInfoLookupResponse**](CardInfoLookupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
