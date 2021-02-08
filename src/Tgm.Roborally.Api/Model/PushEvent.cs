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
    /// When entities push each other
    /// </summary>
    [DataContract]
    public partial class PushEvent :  IEquatable<PushEvent>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PushDirecton
        /// </summary>
        [DataMember(Name="push-directon", EmitDefaultValue=false)]
        public Direction? PushDirecton { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushEvent" /> class.
        /// </summary>
        /// <param name="pusherId">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        /// <param name="ammount">The number of tiles the pushed entity is pushed.</param>
        /// <param name="pushDirecton">pushDirecton.</param>
        /// <param name="pushedId">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        public PushEvent(int pusherId = default(int), int ammount = default(int), Direction? pushDirecton = default(Direction?), int pushedId = default(int))
        {
            this.PusherId = pusherId;
            this.Ammount = ammount;
            this.PushDirecton = pushDirecton;
            this.PushedId = pushedId;
        }
        
        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="pusher-id", EmitDefaultValue=false)]
        public int PusherId { get; set; }

        /// <summary>
        /// The number of tiles the pushed entity is pushed
        /// </summary>
        /// <value>The number of tiles the pushed entity is pushed</value>
        [DataMember(Name="ammount", EmitDefaultValue=false)]
        public int Ammount { get; set; }

        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="pushed-id", EmitDefaultValue=false)]
        public int PushedId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushEvent {\n");
            sb.Append("  PusherId: ").Append(PusherId).Append("\n");
            sb.Append("  Ammount: ").Append(Ammount).Append("\n");
            sb.Append("  PushDirecton: ").Append(PushDirecton).Append("\n");
            sb.Append("  PushedId: ").Append(PushedId).Append("\n");
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
            return this.Equals(input as PushEvent);
        }

        /// <summary>
        /// Returns true if PushEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PushEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PusherId == input.PusherId ||
                    this.PusherId.Equals(input.PusherId)
                ) && 
                (
                    this.Ammount == input.Ammount ||
                    this.Ammount.Equals(input.Ammount)
                ) && 
                (
                    this.PushDirecton == input.PushDirecton ||
                    this.PushDirecton.Equals(input.PushDirecton)
                ) && 
                (
                    this.PushedId == input.PushedId ||
                    this.PushedId.Equals(input.PushedId)
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
                hashCode = hashCode * 59 + this.PusherId.GetHashCode();
                hashCode = hashCode * 59 + this.Ammount.GetHashCode();
                hashCode = hashCode * 59 + this.PushDirecton.GetHashCode();
                hashCode = hashCode * 59 + this.PushedId.GetHashCode();
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
            // PusherId (int) minimum
            if(this.PusherId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PusherId, must be a value greater than or equal to 0.", new [] { "PusherId" });
            }

            // Ammount (int) minimum
            if(this.Ammount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ammount, must be a value greater than or equal to 1.", new [] { "Ammount" });
            }

            // PushedId (int) minimum
            if(this.PushedId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PushedId, must be a value greater than or equal to 0.", new [] { "PushedId" });
            }

            yield break;
        }
    }

}
