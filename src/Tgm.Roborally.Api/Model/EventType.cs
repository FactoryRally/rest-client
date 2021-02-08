/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v1.2.1
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
    /// Describes what the event is about
    /// </summary>
    /// <value>Describes what the event is about</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EventType
    {
        /// <summary>
        /// Enum Movement for value: movement
        /// </summary>
        [EnumMember(Value = "movement")]
        Movement = 1,

        /// <summary>
        /// Enum Upgradepurchase for value: upgrade purchase
        /// </summary>
        [EnumMember(Value = "upgrade purchase")]
        Upgradepurchase = 2,

        /// <summary>
        /// Enum Activateupgrade for value: activate upgrade
        /// </summary>
        [EnumMember(Value = "activate upgrade")]
        Activateupgrade = 3,

        /// <summary>
        /// Enum Lazershot for value: lazer shot
        /// </summary>
        [EnumMember(Value = "lazer shot")]
        Lazershot = 4,

        /// <summary>
        /// Enum Gamestart for value: game start
        /// </summary>
        [EnumMember(Value = "game start")]
        Gamestart = 5,

        /// <summary>
        /// Enum Clearshop for value: clear shop
        /// </summary>
        [EnumMember(Value = "clear shop")]
        Clearshop = 6,

        /// <summary>
        /// Enum Fillshop for value: fill shop
        /// </summary>
        [EnumMember(Value = "fill shop")]
        Fillshop = 7,

        /// <summary>
        /// Enum Programmingtimerstart for value: programming timer start
        /// </summary>
        [EnumMember(Value = "programming timer start")]
        Programmingtimerstart = 8,

        /// <summary>
        /// Enum Programmingtimerstop for value: programming timer stop
        /// </summary>
        [EnumMember(Value = "programming timer stop")]
        Programmingtimerstop = 9,

        /// <summary>
        /// Enum Randomcarddistribution for value: random card distribution
        /// </summary>
        [EnumMember(Value = "random card distribution")]
        Randomcarddistribution = 10,

        /// <summary>
        /// Enum Takecardevent for value: take card event
        /// </summary>
        [EnumMember(Value = "take card event")]
        Takecardevent = 11,

        /// <summary>
        /// Enum Activatecheckpoint for value: activate checkpoint
        /// </summary>
        [EnumMember(Value = "activate checkpoint")]
        Activatecheckpoint = 12,

        /// <summary>
        /// Enum Gamephasechanged for value: game_phase_changed
        /// </summary>
        [EnumMember(Value = "game_phase_changed")]
        Gamephasechanged = 13,

        /// <summary>
        /// Enum Gameroundphasechanged for value: game_round_phase_changed
        /// </summary>
        [EnumMember(Value = "game_round_phase_changed")]
        Gameroundphasechanged = 14,

        /// <summary>
        /// Enum Pause for value: pause
        /// </summary>
        [EnumMember(Value = "pause")]
        Pause = 15,

        /// <summary>
        /// Enum Unpause for value: unpause
        /// </summary>
        [EnumMember(Value = "unpause")]
        Unpause = 16,

        /// <summary>
        /// Enum Damage for value: damage
        /// </summary>
        [EnumMember(Value = "damage")]
        Damage = 17,

        /// <summary>
        /// Enum Lazerhit for value: lazer hit
        /// </summary>
        [EnumMember(Value = "lazer hit")]
        Lazerhit = 18,

        /// <summary>
        /// Enum Push for value: push
        /// </summary>
        [EnumMember(Value = "push")]
        Push = 19,

        /// <summary>
        /// Enum Join for value: join
        /// </summary>
        [EnumMember(Value = "join")]
        Join = 20,

        /// <summary>
        /// Enum Lockin for value: lock in
        /// </summary>
        [EnumMember(Value = "lock in")]
        Lockin = 21,

        /// <summary>
        /// Enum Robotstartexecuting for value: robot_start_executing
        /// </summary>
        [EnumMember(Value = "robot_start_executing")]
        Robotstartexecuting = 22,

        /// <summary>
        /// Enum Heal for value: heal
        /// </summary>
        [EnumMember(Value = "heal")]
        Heal = 23,

        /// <summary>
        /// Enum Energygain for value: energy gain
        /// </summary>
        [EnumMember(Value = "energy gain")]
        Energygain = 24,

        /// <summary>
        /// Enum Map for value: map
        /// </summary>
        [EnumMember(Value = "map")]
        Map = 25,

        /// <summary>
        /// Enum Shutdown for value: shutdown
        /// </summary>
        [EnumMember(Value = "shutdown")]
        Shutdown = 26,

        /// <summary>
        /// Enum Changeregister for value: change register
        /// </summary>
        [EnumMember(Value = "change register")]
        Changeregister = 27,

        /// <summary>
        /// Enum Gameendevent for value: game end event
        /// </summary>
        [EnumMember(Value = "game end event")]
        Gameendevent = 28,

        /// <summary>
        /// Enum Clearregister for value: clear register
        /// </summary>
        [EnumMember(Value = "clear register")]
        Clearregister = 29,

        /// <summary>
        /// Enum Timeelapsed for value: time elapsed
        /// </summary>
        [EnumMember(Value = "time elapsed")]
        Timeelapsed = 30

    }

}
