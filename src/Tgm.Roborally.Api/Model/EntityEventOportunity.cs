/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.14.0
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
    /// The oportunity to perfom an action / event
    /// </summary>
    [DataContract]
    public partial class EntityEventOportunity :  IEquatable<EntityEventOportunity>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public EntityActionType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityEventOportunity" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="timeLeft">The time in ms left to do this action.</param>
        /// <param name="endTime">The in most languages avinable system time in MS as of which the action cant be committed any more.</param>
        public EntityEventOportunity(EntityActionType? type = default(EntityActionType?), long timeLeft = default(long), long endTime = default(long))
        {
            this.Type = type;
            this.TimeLeft = timeLeft;
            this.EndTime = endTime;
        }
        
        /// <summary>
        /// The time in ms left to do this action
        /// </summary>
        /// <value>The time in ms left to do this action</value>
        [DataMember(Name="time-left", EmitDefaultValue=false)]
        public long TimeLeft { get; set; }

        /// <summary>
        /// The in most languages avinable system time in MS as of which the action cant be committed any more
        /// </summary>
        /// <value>The in most languages avinable system time in MS as of which the action cant be committed any more</value>
        [DataMember(Name="end-time", EmitDefaultValue=false)]
        public long EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityEventOportunity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeLeft: ").Append(TimeLeft).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as EntityEventOportunity);
        }

        /// <summary>
        /// Returns true if EntityEventOportunity instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityEventOportunity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityEventOportunity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TimeLeft == input.TimeLeft ||
                    this.TimeLeft.Equals(input.TimeLeft)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    this.EndTime.Equals(input.EndTime)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.TimeLeft.GetHashCode();
                hashCode = hashCode * 59 + this.EndTime.GetHashCode();
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
            // TimeLeft (long) minimum
            if(this.TimeLeft < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeLeft, must be a value greater than or equal to 1.", new [] { "TimeLeft" });
            }

            // EndTime (long) minimum
            if(this.EndTime < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndTime, must be a value greater than or equal to 0.", new [] { "EndTime" });
            }

            yield break;
        }
    }

}
