/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.9.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Tgm.Roborally.Api.Client.OpenAPIDateConverter;

namespace Tgm.Roborally.Api.Model
{
    /// <summary>
    /// Describes the current state of the game. It does not includes the gamedata (like players/poitions/field) but general information.  This is read only
    /// </summary>
    [DataContract(Name = "GameInfo")]
    public partial class GameInfo : IEquatable<GameInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public GameState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameInfo" /> class.
        /// </summary>
        /// <param name="passedTime">The time passed since the game started in secconds. If the game is not started it will be &#x60;0&#x60; (required) (default to -1).</param>
        /// <param name="state">state (required).</param>
        /// <param name="hardwareCompatible">Not every game can be connected to hardware (for example to many bots)  If this is true it means you can use this game with hardware (required) (default to false).</param>
        /// <param name="playerOnTurn">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication (required).</param>
        /// <param name="name">The default rule for names in the game (required).</param>
        /// <param name="maxPlayers">The maximum count of players that can participate in this game (required).</param>
        /// <param name="currentPlayers">The numbers of players in the game (required).</param>
        /// <param name="executionInfo">executionInfo (required).</param>
        /// <param name="passwordProtected">True if the game has a password in order to join  (required).</param>
        public GameInfo(int passedTime = -1, GameState state = default(GameState), bool hardwareCompatible = false, int playerOnTurn = default(int), string name = default(string), int maxPlayers = default(int), int currentPlayers = default(int), GameInfoExecutionInfo executionInfo = default(GameInfoExecutionInfo), bool passwordProtected = default(bool))
        {
            this.PassedTime = passedTime;
            this.State = state;
            this.HardwareCompatible = hardwareCompatible;
            this.PlayerOnTurn = playerOnTurn;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GameInfo and cannot be null");
            this.MaxPlayers = maxPlayers;
            this.CurrentPlayers = currentPlayers;
            // to ensure "executionInfo" is required (not null)
            this.ExecutionInfo = executionInfo ?? throw new ArgumentNullException("executionInfo is a required property for GameInfo and cannot be null");
            this.PasswordProtected = passwordProtected;
        }

        /// <summary>
        /// The time passed since the game started in secconds. If the game is not started it will be &#x60;0&#x60;
        /// </summary>
        /// <value>The time passed since the game started in secconds. If the game is not started it will be &#x60;0&#x60;</value>
        [DataMember(Name = "passed-time", IsRequired = true, EmitDefaultValue = false)]
        public int PassedTime { get; set; }

        /// <summary>
        /// Not every game can be connected to hardware (for example to many bots)  If this is true it means you can use this game with hardware
        /// </summary>
        /// <value>Not every game can be connected to hardware (for example to many bots)  If this is true it means you can use this game with hardware</value>
        [DataMember(Name = "hardware-compatible", IsRequired = true, EmitDefaultValue = false)]
        public bool HardwareCompatible { get; set; }

        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name = "player-on-turn", IsRequired = true, EmitDefaultValue = false)]
        public int PlayerOnTurn { get; set; }

        /// <summary>
        /// The default rule for names in the game
        /// </summary>
        /// <value>The default rule for names in the game</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The maximum count of players that can participate in this game
        /// </summary>
        /// <value>The maximum count of players that can participate in this game</value>
        [DataMember(Name = "max-players", IsRequired = true, EmitDefaultValue = false)]
        public int MaxPlayers { get; set; }

        /// <summary>
        /// The numbers of players in the game
        /// </summary>
        /// <value>The numbers of players in the game</value>
        [DataMember(Name = "current-players", IsRequired = true, EmitDefaultValue = false)]
        public int CurrentPlayers { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionInfo
        /// </summary>
        [DataMember(Name = "executionInfo", IsRequired = true, EmitDefaultValue = false)]
        public GameInfoExecutionInfo ExecutionInfo { get; set; }

        /// <summary>
        /// True if the game has a password in order to join 
        /// </summary>
        /// <value>True if the game has a password in order to join </value>
        [DataMember(Name = "password-protected", IsRequired = true, EmitDefaultValue = false)]
        public bool PasswordProtected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameInfo {\n");
            sb.Append("  PassedTime: ").Append(PassedTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  HardwareCompatible: ").Append(HardwareCompatible).Append("\n");
            sb.Append("  PlayerOnTurn: ").Append(PlayerOnTurn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
            sb.Append("  CurrentPlayers: ").Append(CurrentPlayers).Append("\n");
            sb.Append("  ExecutionInfo: ").Append(ExecutionInfo).Append("\n");
            sb.Append("  PasswordProtected: ").Append(PasswordProtected).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GameInfo);
        }

        /// <summary>
        /// Returns true if GameInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GameInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassedTime == input.PassedTime ||
                    this.PassedTime.Equals(input.PassedTime)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.HardwareCompatible == input.HardwareCompatible ||
                    this.HardwareCompatible.Equals(input.HardwareCompatible)
                ) && 
                (
                    this.PlayerOnTurn == input.PlayerOnTurn ||
                    this.PlayerOnTurn.Equals(input.PlayerOnTurn)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MaxPlayers == input.MaxPlayers ||
                    this.MaxPlayers.Equals(input.MaxPlayers)
                ) && 
                (
                    this.CurrentPlayers == input.CurrentPlayers ||
                    this.CurrentPlayers.Equals(input.CurrentPlayers)
                ) && 
                (
                    this.ExecutionInfo == input.ExecutionInfo ||
                    (this.ExecutionInfo != null &&
                    this.ExecutionInfo.Equals(input.ExecutionInfo))
                ) && 
                (
                    this.PasswordProtected == input.PasswordProtected ||
                    this.PasswordProtected.Equals(input.PasswordProtected)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.PassedTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.HardwareCompatible.GetHashCode();
                hashCode = hashCode * 59 + this.PlayerOnTurn.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.MaxPlayers.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentPlayers.GetHashCode();
                if (this.ExecutionInfo != null)
                    hashCode = hashCode * 59 + this.ExecutionInfo.GetHashCode();
                hashCode = hashCode * 59 + this.PasswordProtected.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PassedTime (int) minimum
            if(this.PassedTime < (int)-1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PassedTime, must be a value greater than or equal to -1.", new [] { "PassedTime" });
            }

            // PlayerOnTurn (int) maximum
            if(this.PlayerOnTurn > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlayerOnTurn, must be a value less than or equal to 8.", new [] { "PlayerOnTurn" });
            }

            // PlayerOnTurn (int) minimum
            if(this.PlayerOnTurn < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlayerOnTurn, must be a value greater than or equal to 0.", new [] { "PlayerOnTurn" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 13.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"[A-Za-z]+[A-Za-z0-9_ -]+[A-Za-z0-9]{1}", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // MaxPlayers (int) maximum
            if(this.MaxPlayers > (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxPlayers, must be a value less than or equal to 10.", new [] { "MaxPlayers" });
            }

            // MaxPlayers (int) minimum
            if(this.MaxPlayers < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxPlayers, must be a value greater than or equal to 1.", new [] { "MaxPlayers" });
            }

            // CurrentPlayers (int) maximum
            if(this.CurrentPlayers > (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrentPlayers, must be a value less than or equal to 10.", new [] { "CurrentPlayers" });
            }

            // CurrentPlayers (int) minimum
            if(this.CurrentPlayers < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrentPlayers, must be a value greater than or equal to 0.", new [] { "CurrentPlayers" });
            }

            yield break;
        }
    }

}
