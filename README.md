# FirstApiClient C# library
## IPG API Version
- 6.14

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- JsonSubTypes.1.6.0
- Microsoft.CSharp.4.5.0
- Newtonsoft.Json.12.0.2
- RestSharp.106.6.10
- System.ComponentModel.Annotations.4.5.0
- xunit.2.4.1

<a name="installation"></a>
## Installation
### Install Via NuGet
-OR-
### Local
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`

Include the DLL (under the `bin` folder) in the C# project

Use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Org.Simple;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Newtonsoft.Json;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Org.Simple;

namespace Example
{
    public class Example
    {
        public void main()
        {
            string apiKey = "Your API Key Here";
            string apiSecret = "Your API Secret Here";

            MerchantCredentials credentials = new MerchantCredentials(apiKey, apiSecret);
            Gateway gateway = Gateway.Create(credentials);

            // For use in production, supply true as the optional production argument:
            // Gateway gateway = Gateway.create(credentials, true);
            // Or supply the production URL directly:
            // string productionURL = "https://prod.api.firstdata.com/gateway/v2";
            // Gateway gateway = Gateway.create(credentials, productionURL);

            string json_payload = @"{
                ""transactionAmount"": {
                    ""total"": ""10.24"",
                    ""currency"": ""USD""
                },
                ""paymentMethod"": {
                    ""paymentCard"": {
                        ""number"": ""4012000033330026"",
                        ""securityCode"": ""977"",
                        ""expiryDate"": {
                            ""month"": ""12"",
                            ""year"": ""24""
                        }
                    }
                }
            }";

            PaymentCardSaleTransaction payload = JsonConvert.DeserializeObject<PaymentCardSaleTransaction>(json_payload);

            ApiResponse response = gateway.SubmitPrimaryTransaction(
                payload
            );

            Console.WriteLine(response.JsonData);
        }
    }
}
```