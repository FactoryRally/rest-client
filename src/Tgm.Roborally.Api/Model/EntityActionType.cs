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
    /// Defines the action itsselft (what the action is doing)  &#x60;pass&#x60; means that nothing is done and the action wont happen  If a type starts with &#x60;edit&#x60; then all actions within the domain of the second word (eg. remove, add, change) are adressed
    /// </summary>
    /// <value>Defines the action itsselft (what the action is doing)  &#x60;pass&#x60; means that nothing is done and the action wont happen  If a type starts with &#x60;edit&#x60; then all actions within the domain of the second word (eg. remove, add, change) are adressed</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EntityActionType
    {
        /// <summary>
        /// Enum Reboot for value: reboot
        /// </summary>
        [EnumMember(Value = "reboot")]
        Reboot = 1,

        /// <summary>
        /// Enum Useupgrade for value: use upgrade
        /// </summary>
        [EnumMember(Value = "use upgrade")]
        Useupgrade = 2,

        /// <summary>
        /// Enum Spiderjump for value: spider_jump
        /// </summary>
        [EnumMember(Value = "spider_jump")]
        Spiderjump = 3,

        /// <summary>
        /// Enum Cache for value: Cache
        /// </summary>
        [EnumMember(Value = "Cache")]
        Cache = 4,

        /// <summary>
        /// Enum RegisterRefresh for value: register-refresh
        /// </summary>
        [EnumMember(Value = "register-refresh")]
        RegisterRefresh = 5,

        /// <summary>
        /// Enum StorageSwap for value: storage-swap
        /// </summary>
        [EnumMember(Value = "storage-swap")]
        StorageSwap = 6,

        /// <summary>
        /// Enum Jumper for value: jumper
        /// </summary>
        [EnumMember(Value = "jumper")]
        Jumper = 7,

        /// <summary>
        /// Enum Teleporter for value: teleporter
        /// </summary>
        [EnumMember(Value = "teleporter")]
        Teleporter = 8,

        /// <summary>
        /// Enum MagnetRay for value: magnet-ray
        /// </summary>
        [EnumMember(Value = "magnet-ray")]
        MagnetRay = 9,

        /// <summary>
        /// Enum Pushray for value: pushray
        /// </summary>
        [EnumMember(Value = "pushray")]
        Pushray = 10,

        /// <summary>
        /// Enum Rotation for value: rotation
        /// </summary>
        [EnumMember(Value = "rotation")]
        Rotation = 11,

        /// <summary>
        /// Enum Sidekick for value: sidekick
        /// </summary>
        [EnumMember(Value = "sidekick")]
        Sidekick = 12,

        /// <summary>
        /// Enum Pass for value: pass
        /// </summary>
        [EnumMember(Value = "pass")]
        Pass = 13,

        /// <summary>
        /// Enum Buyupgrade for value: buy upgrade
        /// </summary>
        [EnumMember(Value = "buy upgrade")]
        Buyupgrade = 14,

        /// <summary>
        /// Enum Editregister for value: edit register
        /// </summary>
        [EnumMember(Value = "edit register")]
        Editregister = 15

    }

}
