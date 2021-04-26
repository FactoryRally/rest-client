/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.13.2
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
    /// The game is over
    /// </summary>
    [DataContract]
    public partial class GameEndEvent :  IEquatable<GameEndEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameEndEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameEndEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameEndEvent" /> class.
        /// </summary>
        /// <param name="winner">winner (required).</param>
        public GameEndEvent(Player winner = default(Player))
        {
            // to ensure "winner" is required (not null)
            this.Winner = winner ?? throw new ArgumentNullException("winner is a required property for GameEndEvent and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name="winner", EmitDefaultValue=false)]
        public Player Winner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameEndEvent {\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
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
            return this.Equals(input as GameEndEvent);
        }

        /// <summary>
        /// Returns true if GameEndEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of GameEndEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameEndEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Winner == input.Winner ||
                    (this.Winner != null &&
                    this.Winner.Equals(input.Winner))
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
                if (this.Winner != null)
                    hashCode = hashCode * 59 + this.Winner.GetHashCode();
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
            yield break;
        }
    }

}
