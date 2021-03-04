/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.7.0
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
    /// Defines a direction in a 2D system. the X and Y values can be defined by the client.
    /// </summary>
    /// <value>Defines a direction in a 2D system. the X and Y values can be defined by the client.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Direction
    {
        /// <summary>
        /// Enum Up for value: up
        /// </summary>
        [EnumMember(Value = "up")]
        Up = 1,

        /// <summary>
        /// Enum Down for value: down
        /// </summary>
        [EnumMember(Value = "down")]
        Down = 2,

        /// <summary>
        /// Enum Left for value: left
        /// </summary>
        [EnumMember(Value = "left")]
        Left = 3,

        /// <summary>
        /// Enum Right for value: right
        /// </summary>
        [EnumMember(Value = "right")]
        Right = 4

    }

}
