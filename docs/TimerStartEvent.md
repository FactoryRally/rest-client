# Tgm.Roborally.Api.Model.TimerStartEvent
Called when a timer is started
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subject** | **string** | Describes the usage of the timer | 
**EndTime** | **long** | The time in ms since epoche when the timer will ends | 
**Duration** | **int** | the duration of the timer in ms | [default to 20000]
**Passable** | **bool** | if this is true the active player can pass the event | [default to false]
**RobotsActive** | **List&lt;int&gt;** | The entites that are able to act during this timer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

