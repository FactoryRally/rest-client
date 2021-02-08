# Tgm.Roborally.Api.Api.RobotsApi

All URIs are relative to *http://game.host/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearRegisters**](RobotsApi.md#clearregisters) | **DELETE** /games/{game_id}/entities/robots/{robot_id}/registers | clear registers
[**ClearUpgrades**](RobotsApi.md#clearupgrades) | **DELETE** /games/{game_id}/entities/robots/{robot_id}/upgrades | Clear Robot Upgrades
[**DoEntityAction**](RobotsApi.md#doentityaction) | **POST** /games/{game_id}/entities/robots/{robot_id}/actions/stack/ | Add Entity Action to stack
[**GetActionStack**](RobotsApi.md#getactionstack) | **GET** /games/{game_id}/entities/robots/{robot_id}/actions/stack/ | Get Robot action stack
[**GetInstalledUpgrades**](RobotsApi.md#getinstalledupgrades) | **GET** /games/{game_id}/entities/robots/{robot_id}/upgrades | Get Robot Upgrades
[**GetPossibleActions**](RobotsApi.md#getpossibleactions) | **GET** /games/{game_id}/entities/robots/{robot_id}/actions/avinable | Get Aviable actions
[**GetRegisterContent**](RobotsApi.md#getregistercontent) | **GET** /games/{game_id}/entities/robots/{robot_id}/registers/{register} | Get Register Content
[**GetRegisters**](RobotsApi.md#getregisters) | **GET** /games/{game_id}/entities/robots/{robot_id}/registers | Get register information
[**GetRobotStats**](RobotsApi.md#getrobotstats) | **GET** /games/{game_id}/entities/robots/{robot_id}/info | Get Robot Informations
[**GetRobots**](RobotsApi.md#getrobots) | **GET** /games/{game_id}/entities/robots/ | Get all robots
[**RemoveRobotUpgrade**](RobotsApi.md#removerobotupgrade) | **PATCH** /games/{game_id}/entities/robots/{robot_id}/upgrades | Remove Upgrade
[**SetRegister**](RobotsApi.md#setregister) | **PUT** /games/{game_id}/entities/robots/{robot_id}/registers/{register} | Set Register Content


<a name="clearregisters"></a>
# **ClearRegisters**
> void ClearRegisters (int gameId, int robotId)

clear registers

Emptys all register of the robot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class ClearRegistersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // clear registers
                apiInstance.ClearRegisters(gameId, robotId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.ClearRegisters: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

### Return type

void (empty response body)

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

<a name="clearupgrades"></a>
# **ClearUpgrades**
> void ClearUpgrades (int gameId, int robotId)

Clear Robot Upgrades

Removes all upgrades from a robot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class ClearUpgradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // Clear Robot Upgrades
                apiInstance.ClearUpgrades(gameId, robotId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.ClearUpgrades: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

### Return type

void (empty response body)

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

<a name="doentityaction"></a>
# **DoEntityAction**
> void DoEntityAction (int gameId, int robotId, EntityAction entityAction = null)

Add Entity Action to stack

Adds an action to the stack. The stack is processed using *first in first out*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class DoEntityActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with
            var entityAction = new EntityAction(); // EntityAction |  (optional) 

            try
            {
                // Add Entity Action to stack
                apiInstance.DoEntityAction(gameId, robotId, entityAction);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.DoEntityAction: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 
 **entityAction** | [**EntityAction**](EntityAction.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[player-auth](../README.md#player-auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactionstack"></a>
# **GetActionStack**
> List&lt;EntityAction&gt; GetActionStack (int gameId, int robotId)

Get Robot action stack

Retuns a list od all actions in the stack

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetActionStackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // Get Robot action stack
                List<EntityAction> result = apiInstance.GetActionStack(gameId, robotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetActionStack: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

### Return type

[**List&lt;EntityAction&gt;**](EntityAction.md)

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

<a name="getinstalledupgrades"></a>
# **GetInstalledUpgrades**
> List&lt;int&gt; GetInstalledUpgrades (int gameId, int robotId)

Get Robot Upgrades

Returns the upgrades installed on the robot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetInstalledUpgradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // Get Robot Upgrades
                List<int> result = apiInstance.GetInstalledUpgrades(gameId, robotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetInstalledUpgrades: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

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

<a name="getpossibleactions"></a>
# **GetPossibleActions**
> List&lt;EntityEventOportunity&gt; GetPossibleActions (int gameId, int robotId)

Get Aviable actions

Returns a list of EntityActionTypes which are possible to be executed at the moment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetPossibleActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // Get Aviable actions
                List<EntityEventOportunity> result = apiInstance.GetPossibleActions(gameId, robotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetPossibleActions: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

### Return type

[**List&lt;EntityEventOportunity&gt;**](EntityEventOportunity.md)

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

<a name="getregistercontent"></a>
# **GetRegisterContent**
> RobotCommand GetRegisterContent (int gameId, int robotId, int register)

Get Register Content

Returns the Programming card in the robots register

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetRegisterContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with
            var register = 56;  // int | The number of the register

            try
            {
                // Get Register Content
                RobotCommand result = apiInstance.GetRegisterContent(gameId, robotId, register);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetRegisterContent: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 
 **register** | **int**| The number of the register | 

### Return type

[**RobotCommand**](RobotCommand.md)

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

<a name="getregisters"></a>
# **GetRegisters**
> List&lt;RobotCommand&gt; GetRegisters (int gameId, int robotId)

Get register information

Returns the content of the registers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetRegistersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // Get register information
                List<RobotCommand> result = apiInstance.GetRegisters(gameId, robotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetRegisters: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

### Return type

[**List&lt;RobotCommand&gt;**](RobotCommand.md)

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

<a name="getrobotstats"></a>
# **GetRobotStats**
> RobotInfo GetRobotStats (int gameId, int robotId)

Get Robot Informations

Returns the status and info about the robot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetRobotStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with

            try
            {
                // Get Robot Informations
                RobotInfo result = apiInstance.GetRobotStats(gameId, robotId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetRobotStats: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 

### Return type

[**RobotInfo**](RobotInfo.md)

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

<a name="getrobots"></a>
# **GetRobots**
> List&lt;int&gt; GetRobots (int gameId)

Get all robots

Returns a list of all robot IDs in this game. > A robot is not a player as a player is able to controll multiple robots

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetRobotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with

            try
            {
                // Get all robots
                List<int> result = apiInstance.GetRobots(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.GetRobots: " + e.Message );
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

<a name="removerobotupgrade"></a>
# **RemoveRobotUpgrade**
> void RemoveRobotUpgrade (int gameId, int robotId, int? upgrade = null)

Remove Upgrade

Removes a paticular upgrade from the robot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class RemoveRobotUpgradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with
            var upgrade = 56;  // int? | The id of the upgrade to remove (optional) 

            try
            {
                // Remove Upgrade
                apiInstance.RemoveRobotUpgrade(gameId, robotId, upgrade);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.RemoveRobotUpgrade: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 
 **upgrade** | **int?**| The id of the upgrade to remove | [optional] 

### Return type

void (empty response body)

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

<a name="setregister"></a>
# **SetRegister**
> void SetRegister (int gameId, int robotId, int register, int statementId)

Set Register Content

Changes the programming card of the robots register

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class SetRegisterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new RobotsApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var robotId = 56;  // int | the id of the robot to interact with
            var register = 56;  // int | The number of the register
            var statementId = 56;  // int | The Id of the statement to place here

            try
            {
                // Set Register Content
                apiInstance.SetRegister(gameId, robotId, register, statementId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RobotsApi.SetRegister: " + e.Message );
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
 **robotId** | **int**| the id of the robot to interact with | 
 **register** | **int**| The number of the register | 
 **statementId** | **int**| The Id of the statement to place here | 

### Return type

void (empty response body)

### Authorization

[player-auth](../README.md#player-auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Changed |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

