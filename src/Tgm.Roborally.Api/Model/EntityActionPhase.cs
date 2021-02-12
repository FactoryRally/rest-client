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
    /// The moment at which a entity action can be performed
    /// </summary>
    /// <value>The moment at which a entity action can be performed</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EntityActionPhase
    {
        /// <summary>
        /// Enum Preregister for value: pre_register
        /// </summary>
        [EnumMember(Value = "pre_register")]
        Preregister = 1,

        /// <summary>
        /// Enum Afterregister for value: after_register
        /// </summary>
        [EnumMember(Value = "after_register")]
        Afterregister = 2

    }

}
