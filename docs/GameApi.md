# Tgm.Roborally.Api.Api.GameApi

All URIs are relative to *http://game.host/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommitAction**](GameApi.md#commitaction) | **PUT** /games/{game_id}/actions | Commit Action
[**CreateGame**](GameApi.md#creategame) | **POST** /games/ | Create Game
[**GetActions**](GameApi.md#getactions) | **GET** /games/{game_id}/actions | Get games actions
[**GetGameState**](GameApi.md#getgamestate) | **GET** /games/{game_id}/status | Get game status
[**GetGames**](GameApi.md#getgames) | **GET** /games/ | Get all games
[**GetProgrammingCard**](GameApi.md#getprogrammingcard) | **GET** /games/{game_id}/statements/{statement_id} | Get Programming Card
[**GetProgrammingCardIds**](GameApi.md#getprogrammingcardids) | **HEAD** /games/{game_id}/statements | Get Programming Card IDs
[**GetProgrammingCards**](GameApi.md#getprogrammingcards) | **GET** /games/{game_id}/statements | Get Programming cards


<a name="commitaction"></a>
# **CommitAction**
> void CommitAction (int gameId, ActionType action)

Commit Action

Queues an action to be executed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class CommitActionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: admin-access
            config.AddApiKey("skey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("skey", "Bearer");

            var apiInstance = new GameApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var action = ;  // ActionType | 

            try
            {
                // Commit Action
                apiInstance.CommitAction(gameId, action);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.CommitAction: " + e.Message );
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
 **action** | **ActionType**|  | 

### Return type

void (empty response body)

### Authorization

[admin-access](../README.md#admin-access)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategame"></a>
# **CreateGame**
> int CreateGame (GameRules gameRules = null)

Create Game

Creates a random game by your defined rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class CreateGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: admin-access
            config.AddApiKey("skey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("skey", "Bearer");

            var apiInstance = new GameApi(config);
            var gameRules = new GameRules(); // GameRules | *Optional* This rules define how your game will behave (optional) 

            try
            {
                // Create Game
                int result = apiInstance.CreateGame(gameRules);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.CreateGame: " + e.Message );
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
 **gameRules** | [**GameRules**](GameRules.md)| *Optional* This rules define how your game will behave | [optional] 

### Return type

**int**

### Authorization

[admin-access](../README.md#admin-access)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactions"></a>
# **GetActions**
> List&lt;Action&gt; GetActions (int gameId, string mode = null)

Get games actions

Get all (**not robot related**) actions comitted to this game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: admin-access
            config.AddApiKey("skey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("skey", "Bearer");

            var apiInstance = new GameApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var mode = mode_example;  // string | Defines wich entries to return (optional)  (default to ALL)

            try
            {
                // Get games actions
                List<Action> result = apiInstance.GetActions(gameId, mode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetActions: " + e.Message );
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
 **mode** | **string**| Defines wich entries to return | [optional] [default to ALL]

### Return type

[**List&lt;Action&gt;**](Action.md)

### Authorization

[admin-access](../README.md#admin-access)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgamestate"></a>
# **GetGameState**
> GameInfo GetGameState (int gameId)

Get game status

Returns the status of a game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetGameStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            var apiInstance = new GameApi(config);
            var gameId = 56;  // int | The id of the game to interact with

            try
            {
                // Get game status
                GameInfo result = apiInstance.GetGameState(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetGameState: " + e.Message );
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

[**GameInfo**](GameInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgames"></a>
# **GetGames**
> List&lt;int&gt; GetGames (bool? joinable = null, bool? unprotected = null)

Get all games

Returns a list of all hosted games

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetGamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            var apiInstance = new GameApi(config);
            var joinable = true;  // bool? | true: only return joinable games (optional)  (default to false)
            var unprotected = true;  // bool? | true: only display games with no password set (optional)  (default to false)

            try
            {
                // Get all games
                List<int> result = apiInstance.GetGames(joinable, unprotected);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetGames: " + e.Message );
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
 **joinable** | **bool?**| true: only return joinable games | [optional] [default to false]
 **unprotected** | **bool?**| true: only display games with no password set | [optional] [default to false]

### Return type

**List<int>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprogrammingcard"></a>
# **GetProgrammingCard**
> RobotCommand GetProgrammingCard (int gameId, int statementId)

Get Programming Card

Get the programming card by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetProgrammingCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new GameApi(config);
            var gameId = 56;  // int | The id of the game to interact with
            var statementId = 56;  // int | The id of the programming card

            try
            {
                // Get Programming Card
                RobotCommand result = apiInstance.GetProgrammingCard(gameId, statementId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetProgrammingCard: " + e.Message );
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
 **statementId** | **int**| The id of the programming card | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprogrammingcardids"></a>
# **GetProgrammingCardIds**
> List&lt;int&gt; GetProgrammingCardIds (int gameId)

Get Programming Card IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetProgrammingCardIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new GameApi(config);
            var gameId = 56;  // int | The id of the game to interact with

            try
            {
                // Get Programming Card IDs
                List<int> result = apiInstance.GetProgrammingCardIds(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetProgrammingCardIds: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprogrammingcards"></a>
# **GetProgrammingCards**
> List&lt;RobotCommand&gt; GetProgrammingCards (int gameId)

Get Programming cards

Returns the Programming cards in this game

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Example
{
    public class GetProgrammingCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://game.host/v1";
            // Configure API key authorization: player-auth
            config.AddApiKey("pat", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("pat", "Bearer");

            var apiInstance = new GameApi(config);
            var gameId = 56;  // int | The id of the game to interact with

            try
            {
                // Get Programming cards
                List<RobotCommand> result = apiInstance.GetProgrammingCards(gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetProgrammingCards: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

