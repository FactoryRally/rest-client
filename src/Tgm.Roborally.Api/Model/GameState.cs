/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.9.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Tgm.Roborally.Api.Client.OpenAPIDateConverter;

namespace Tgm.Roborally.Api.Model
{
    /// <summary>
    /// The phase the game is currently in * &#x60;Lobby&#x60;: Players are able to join, Bots able to be added. Host can decide to start the game and leave the phase * &#x60;Planning&#x60;: **[BETA - Not in game]** Players can choose their type of robot/bots bots autopick * &#x60;Playing&#x60;: The game is running and the players can do interactions * &#x60;Break&#x60;: The game is paused by the host. Players can still do interactions but they wont be executed as long as the break lasts * &#x60;Finished&#x60; : The game is over and there is a winner. This is the time to save the game for a replay 
    /// </summary>
    /// <value>The phase the game is currently in * &#x60;Lobby&#x60;: Players are able to join, Bots able to be added. Host can decide to start the game and leave the phase * &#x60;Planning&#x60;: **[BETA - Not in game]** Players can choose their type of robot/bots bots autopick * &#x60;Playing&#x60;: The game is running and the players can do interactions * &#x60;Break&#x60;: The game is paused by the host. Players can still do interactions but they wont be executed as long as the break lasts * &#x60;Finished&#x60; : The game is over and there is a winner. This is the time to save the game for a replay </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GameState
    {
        /// <summary>
        /// Enum LOBBY for value: LOBBY
        /// </summary>
        [EnumMember(Value = "LOBBY")]
        LOBBY = 1,

        /// <summary>
        /// Enum PLANNING for value: PLANNING
        /// </summary>
        [EnumMember(Value = "PLANNING")]
        PLANNING = 2,

        /// <summary>
        /// Enum PLAYING for value: PLAYING
        /// </summary>
        [EnumMember(Value = "PLAYING")]
        PLAYING = 3,

        /// <summary>
        /// Enum FINISHED for value: FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED = 4,

        /// <summary>
        /// Enum BREAK for value: BREAK
        /// </summary>
        [EnumMember(Value = "BREAK")]
        BREAK = 5

    }

}
