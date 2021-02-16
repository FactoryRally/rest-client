/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.1.0
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
    /// This event is fired when a player exchanges or actively discards upgrades. The upgrades are removed from the game (but still accessible) 
    /// </summary>
    [DataContract]
    public partial class DiscardUpgradesEvent :  IEquatable<DiscardUpgradesEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscardUpgradesEvent" /> class.
        /// </summary>
        /// <param name="upgrades">The list of upgrades discarded.</param>
        /// <param name="robot">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        public DiscardUpgradesEvent(List<int> upgrades = default(List<int>), int robot = default(int))
        {
            this.Upgrades = upgrades;
            this.Robot = robot;
        }
        
        /// <summary>
        /// The list of upgrades discarded
        /// </summary>
        /// <value>The list of upgrades discarded</value>
        [DataMember(Name="upgrades", EmitDefaultValue=false)]
        public List<int> Upgrades { get; set; }

        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="robot", EmitDefaultValue=false)]
        public int Robot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscardUpgradesEvent {\n");
            sb.Append("  Upgrades: ").Append(Upgrades).Append("\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
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
            return this.Equals(input as DiscardUpgradesEvent);
        }

        /// <summary>
        /// Returns true if DiscardUpgradesEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscardUpgradesEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscardUpgradesEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Upgrades == input.Upgrades ||
                    this.Upgrades != null &&
                    input.Upgrades != null &&
                    this.Upgrades.SequenceEqual(input.Upgrades)
                ) && 
                (
                    this.Robot == input.Robot ||
                    this.Robot.Equals(input.Robot)
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
                if (this.Upgrades != null)
                    hashCode = hashCode * 59 + this.Upgrades.GetHashCode();
                hashCode = hashCode * 59 + this.Robot.GetHashCode();
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
            // Robot (int) minimum
            if(this.Robot < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Robot, must be a value greater than or equal to 0.", new [] { "Robot" });
            }

            yield break;
        }
    }

}
