# Tgm.Roborally.Api.Model.MovementEvent
Describes the movement of a entity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **int** | The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only | [optional] 
**Direction** | **Direction** |  | [optional] 
**MovementAmmount** | **int** | How far (in tiles) the movement was executed | [optional] 
**Rotation** | **Rotation** |  | [optional] 
**RotationTimes** | **int** | The number of times (90°) the robot turns | [optional] 
**From** | [**Position**](Position.md) |  | [optional] 
**To** | [**Position**](Position.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

