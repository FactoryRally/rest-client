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
    /// The event that occurs if a player buys an upgrade
    /// </summary>
    [DataContract]
    public partial class PurchaseEvent :  IEquatable<PurchaseEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseEvent" /> class.
        /// </summary>
        /// <param name="player">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication.</param>
        /// <param name="upgrade">The id of an upgrade. **Unique**.</param>
        public PurchaseEvent(int player = default(int), int upgrade = default(int))
        {
            this.Player = player;
            this.Upgrade = upgrade;
        }
        
        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public int Player { get; set; }

        /// <summary>
        /// The id of an upgrade. **Unique**
        /// </summary>
        /// <value>The id of an upgrade. **Unique**</value>
        [DataMember(Name="upgrade", EmitDefaultValue=false)]
        public int Upgrade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseEvent {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Upgrade: ").Append(Upgrade).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PurchaseEvent);
        }

        /// <summary>
        /// Returns true if PurchaseEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Player == input.Player ||
                    this.Player.Equals(input.Player)
                ) && 
                (
                    this.Upgrade == input.Upgrade ||
                    this.Upgrade.Equals(input.Upgrade)
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
                hashCode = hashCode * 59 + this.Player.GetHashCode();
                hashCode = hashCode * 59 + this.Upgrade.GetHashCode();
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
            // Player (int) maximum
            if(this.Player > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Player, must be a value less than or equal to 8.", new [] { "Player" });
            }

            // Player (int) minimum
            if(this.Player < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Player, must be a value greater than or equal to 0.", new [] { "Player" });
            }

            // Upgrade (int) maximum
            if(this.Upgrade > (int)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Upgrade, must be a value less than or equal to 10000.", new [] { "Upgrade" });
            }

            // Upgrade (int) minimum
            if(this.Upgrade < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Upgrade, must be a value greater than or equal to 0.", new [] { "Upgrade" });
            }

            yield break;
        }
    }

}
