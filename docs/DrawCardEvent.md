# Tgm.Roborally.Api.Model.DrawCardEvent
The event that occurs if a player gets his programming cards

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Player** | **int** | This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication | 
**Count** | **int** | The number of cards drawn | 
**Cards** | **List&lt;int&gt;** | The drawn cards. **This is only visible for the player himself** | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

