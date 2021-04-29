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
    /// The event that occurs if the active map elements are activated
    /// </summary>
    /// <value>The event that occurs if the active map elements are activated</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MapEventType
    {
        /// <summary>
        /// Enum Lazer for value: lazer
        /// </summary>
        [EnumMember(Value = "lazer")]
        Lazer = 1,

        /// <summary>
        /// Enum Rotator for value: rotator
        /// </summary>
        [EnumMember(Value = "rotator")]
        Rotator = 2,

        /// <summary>
        /// Enum ConveyorBelts for value: conveyor-belts
        /// </summary>
        [EnumMember(Value = "conveyor-belts")]
        ConveyorBelts = 3,

        /// <summary>
        /// Enum Stomper for value: stomper
        /// </summary>
        [EnumMember(Value = "stomper")]
        Stomper = 4,

        /// <summary>
        /// Enum Hole for value: hole
        /// </summary>
        [EnumMember(Value = "hole")]
        Hole = 5,

        /// <summary>
        /// Enum HoleTrap for value: hole-trap
        /// </summary>
        [EnumMember(Value = "hole-trap")]
        HoleTrap = 6,

        /// <summary>
        /// Enum Pusher for value: pusher
        /// </summary>
        [EnumMember(Value = "pusher")]
        Pusher = 7,

        /// <summary>
        /// Enum Flamethrower for value: flamethrower
        /// </summary>
        [EnumMember(Value = "flamethrower")]
        Flamethrower = 8,

        /// <summary>
        /// Enum Portal for value: portal
        /// </summary>
        [EnumMember(Value = "portal")]
        Portal = 9,

        /// <summary>
        /// Enum ToggleRamps for value: toggle-ramps
        /// </summary>
        [EnumMember(Value = "toggle-ramps")]
        ToggleRamps = 10,

        /// <summary>
        /// Enum Repair for value: repair
        /// </summary>
        [EnumMember(Value = "repair")]
        Repair = 11

    }

}
