# Tgm.Roborally.Api.Api.UpgradesApi

All URIs are relative to *http://game.host/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuyUpgrade**](UpgradesApi.md#buyupgrade) | **PATCH** /games/{game_id}/upgrades/shop/{upgrade_id} | Buy Upgrade
[**GetAllUpgradeIDs**](UpgradesApi.md#getallupgradeids) | **GET** /games/{game_id}/upgrades/ | get all Upgrades
[**GetUpgradeInformation**](UpgradesApi.md#getupgradeinformation) | **GET** /games/{game_id}/upgrades/{upgrade_id} | Get upgrade information
[**GetUpgradeShop**](UpgradesApi.md#getupgradeshop) | **GET** /games/{game_id}/upgrades/shop | Get upgrade shop


<a name="buyupgrade"></a>
# **BuyUpgrade**
> void BuyUpgrade (int gameId, int upgradeId, int? exchange = null)

Buy Upgrade

Buy or exchange an upgrade

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class BuyUpgradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            var apiInstance = new UpgradesApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var upgradeId = 56;  // int | The id of the upgrade to interact with
            var exchange = 56;  // int? | The id of the upgrade to exchange with. Set to null or leave empty for a regular purchase (optional) 

            try
            {
                // Buy Upgrade
                apiInstance.BuyUpgrade(gameId, upgradeId, exchange);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpgradesApi.BuyUpgrade: " + e.Message );
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
 **upgradeId** | **int**| The id of the upgrade to interact with | 
 **exchange** | **int?**| The id of the upgrade to exchange with. Set to null or leave empty for a regular purchase | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | The error message including a human readable description |  -  |
| **409** | The error message including a human readable description |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallupgradeids"></a>
# **GetAllUpgradeIDs**
> List&lt;int&gt; GetAllUpgradeIDs (int gameId)

get all Upgrades

Returns a list of all Upgrade IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetAllUpgradeIDsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new UpgradesApi(config);
            var gameId = 56;  // int | The id of the game to interact with

            try
            {
                // get all Upgrades
                List<int> result = apiInstance.GetAllUpgradeIDs(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpgradesApi.GetAllUpgradeIDs: " + e.Message );
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

### Return type

**List<int>**

### Authorization

[player-auth](../README.md#player-auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupgradeinformation"></a>
# **GetUpgradeInformation**
> Upgrade GetUpgradeInformation (int gameId, int upgradeId)

Get upgrade information

Get detailed information about the Upgrade

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetUpgradeInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new UpgradesApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var upgradeId = 56;  // int | The id of the upgrade to interact with

            try
            {
                // Get upgrade information
                Upgrade result = apiInstance.GetUpgradeInformation(gameId, upgradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpgradesApi.GetUpgradeInformation: " + e.Message );
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
 **upgradeId** | **int**| The id of the upgrade to interact with | 

### Return type

[**Upgrade**](Upgrade.md)

### Authorization

[player-auth](../README.md#player-auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupgradeshop"></a>
# **GetUpgradeShop**
> UpgradeShop GetUpgradeShop (int gameId)

Get upgrade shop

Retuns a list of all cards in the upgrade shop

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetUpgradeShopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new UpgradesApi(config);
            var gameId = 56;  // int | The id of the game to interact with

            try
            {
                // Get upgrade shop
                UpgradeShop result = apiInstance.GetUpgradeShop(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpgradesApi.GetUpgradeShop: " + e.Message );
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

### Return type

[**UpgradeShop**](UpgradeShop.md)

### Authorization

[player-auth](../README.md#player-auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

