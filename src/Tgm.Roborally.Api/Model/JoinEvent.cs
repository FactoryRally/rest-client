/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v1.1.1
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
    /// If somebody joins a game
    /// </summary>
    [DataContract]
    public partial class JoinEvent :  IEquatable<JoinEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinEvent" /> class.
        /// </summary>
        /// <param name="joinedId">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication.</param>
        /// <param name="unjoin">True if the player left instead of joining.</param>
        public JoinEvent(int joinedId = default(int), bool unjoin = default(bool))
        {
            this.JoinedId = joinedId;
            this.Unjoin = unjoin;
        }
        
        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name="joined_id", EmitDefaultValue=false)]
        public int JoinedId { get; set; }

        /// <summary>
        /// True if the player left instead of joining
        /// </summary>
        /// <value>True if the player left instead of joining</value>
        [DataMember(Name="unjoin", EmitDefaultValue=false)]
        public bool Unjoin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinEvent {\n");
            sb.Append("  JoinedId: ").Append(JoinedId).Append("\n");
            sb.Append("  Unjoin: ").Append(Unjoin).Append("\n");
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
            return this.Equals(input as JoinEvent);
        }

        /// <summary>
        /// Returns true if JoinEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of JoinEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JoinedId == input.JoinedId ||
                    this.JoinedId.Equals(input.JoinedId)
                ) && 
                (
                    this.Unjoin == input.Unjoin ||
                    this.Unjoin.Equals(input.Unjoin)
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
                hashCode = hashCode * 59 + this.JoinedId.GetHashCode();
                hashCode = hashCode * 59 + this.Unjoin.GetHashCode();
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
            // JoinedId (int) maximum
            if(this.JoinedId > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JoinedId, must be a value less than or equal to 8.", new [] { "JoinedId" });
            }

            // JoinedId (int) minimum
            if(this.JoinedId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JoinedId, must be a value greater than or equal to 0.", new [] { "JoinedId" });
            }

            yield break;
        }
    }

}
