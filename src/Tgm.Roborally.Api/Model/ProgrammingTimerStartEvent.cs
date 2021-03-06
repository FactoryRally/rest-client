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
    /// ProgrammingTimerStartEvent
    /// </summary>
    [DataContract]
    public partial class ProgrammingTimerStartEvent :  IEquatable<ProgrammingTimerStartEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgrammingTimerStartEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgrammingTimerStartEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgrammingTimerStartEvent" /> class.
        /// </summary>
        /// <param name="seconds">Time the timer will run for (required).</param>
        /// <param name="end">The time at which the timer ends. Given as &#x60;ms since epoche&#x60; [link](currentmillis.com)  (required).</param>
        public ProgrammingTimerStartEvent(int seconds = default(int), long end = default(long))
        {
            this.Seconds = seconds;
            this.End = end;
        }
        
        /// <summary>
        /// Time the timer will run for
        /// </summary>
        /// <value>Time the timer will run for</value>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public int Seconds { get; set; }

        /// <summary>
        /// The time at which the timer ends. Given as &#x60;ms since epoche&#x60; [link](currentmillis.com) 
        /// </summary>
        /// <value>The time at which the timer ends. Given as &#x60;ms since epoche&#x60; [link](currentmillis.com) </value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public long End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgrammingTimerStartEvent {\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(input as ProgrammingTimerStartEvent);
        }

        /// <summary>
        /// Returns true if ProgrammingTimerStartEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgrammingTimerStartEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgrammingTimerStartEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Seconds == input.Seconds ||
                    this.Seconds.Equals(input.Seconds)
                ) && 
                (
                    this.End == input.End ||
                    this.End.Equals(input.End)
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
                hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                hashCode = hashCode * 59 + this.End.GetHashCode();
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
            // Seconds (int) maximum
            if(this.Seconds > (int)300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Seconds, must be a value less than or equal to 300.", new [] { "Seconds" });
            }

            // Seconds (int) minimum
            if(this.Seconds < (int)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Seconds, must be a value greater than or equal to 3.", new [] { "Seconds" });
            }

            yield break;
        }
    }

}
