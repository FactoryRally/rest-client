# Tgm.Roborally.Api.Model.GameInfo
Describes the current state of the game. It does not includes the gamedata (like players/poitions/field) but general information.  This is read only
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassedTime** | **int** | The time passed since the game started in secconds. If the game is not started it will be &#x60;0&#x60; | [default to -1]
**State** | **GameState** |  | 
**HardwareCompatible** | **bool** | Not every game can be connected to hardware (for example to many bots)  If this is true it means you can use this game with hardware | [default to false]
**PlayerOnTurn** | **int** | This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication | 
**Name** | **string** | The default rule for names in the game | 
**MaxPlayers** | **int** | The maximum count of players that can participate in this game | 
**CurrentPlayers** | **int** | The numbers of players in the game | 
**ExecutionInfo** | [**GameInfoExecutionInfo**](GameInfoExecutionInfo.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

