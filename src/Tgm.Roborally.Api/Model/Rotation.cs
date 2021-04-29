/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.13.3
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
    /// Defines wether to turn left or right
    /// </summary>
    /// <value>Defines wether to turn left or right</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Rotation
    {
        /// <summary>
        /// Enum Left for value: left
        /// </summary>
        [EnumMember(Value = "left")]
        Left = 1,

        /// <summary>
        /// Enum Right for value: right
        /// </summary>
        [EnumMember(Value = "right")]
        Right = 2

    }

}
