# Tgm.Roborally.Api.Api.ConsumerApi

All URIs are relative to *http://game.host/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegisterConsumer**](ConsumerApi.md#registerconsumer) | **POST** /games/{game_id}/consumers | Register Consumers


<a name="registerconsumer"></a>
# **RegisterConsumer**
> JoinResponse RegisterConsumer (int gameId, ConsumerRegistration consumerRegistration = null)

Register Consumers

Add a consumer to create a *virtual* (*spectating*) player to consume events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class RegisterConsumerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            var apiInstance = new ConsumerApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var consumerRegistration = new ConsumerRegistration(); // ConsumerRegistration | Information about the joining consumer (optional) 

            try
            {
                // Register Consumers
                JoinResponse result = apiInstance.RegisterConsumer(gameId, consumerRegistration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsumerApi.RegisterConsumer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gameId** | **int**| The id of the game to interact with | 
 **consumerRegistration** | [**ConsumerRegistration**](ConsumerRegistration.md)| Information about the joining consumer | [optional] 

### Return type

[**JoinResponse**](JoinResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **410** | Consumer count limit reached |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

