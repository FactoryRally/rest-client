# Tgm.Roborally.Api.Model.Tile
A tile is a square at the Game field<br> **Note:**  * `direction` is only aviable for belts * properties with a `rotator-` prefix are only aviable for rotator (parts)
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TileType** |  | 
**Empty** | **bool** | If there is no player at the tile this is true | [optional] 
**Direction** | **Direction** |  | [optional] 
**RotatorDirection** | **Rotation** |  | [optional] 
**Level** | **int** | The height of the tile. 1 &#x3D; default | [default to 1]
**Order** | **int** | Descibes the interal order of the tile type: eg. if order is 3 it is the 4th of its tile-type (because it is 0 based)  Default -1 means the oder has no use to this tile(type) | [optional] [default to -1]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

