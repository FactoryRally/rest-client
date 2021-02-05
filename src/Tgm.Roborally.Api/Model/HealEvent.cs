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
    /// When a robot is healed
    /// </summary>
    [DataContract]
    public partial class HealEvent :  IEquatable<HealEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealEvent" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="healAmount">healAmount.</param>
        public HealEvent(Entity entity = default(Entity), int healAmount = default(int))
        {
            this.Entity = entity;
            this.HealAmount = healAmount;
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Entity Entity { get; set; }

        /// <summary>
        /// Gets or Sets HealAmount
        /// </summary>
        [DataMember(Name="heal_amount", EmitDefaultValue=false)]
        public int HealAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealEvent {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  HealAmount: ").Append(HealAmount).Append("\n");
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
            return this.Equals(input as HealEvent);
        }

        /// <summary>
        /// Returns true if HealEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of HealEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.HealAmount == input.HealAmount ||
                    this.HealAmount.Equals(input.HealAmount)
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                hashCode = hashCode * 59 + this.HealAmount.GetHashCode();
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
            // HealAmount (int) maximum
            if(this.HealAmount > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HealAmount, must be a value less than or equal to 100.", new [] { "HealAmount" });
            }

            // HealAmount (int) minimum
            if(this.HealAmount < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HealAmount, must be a value greater than or equal to 0.", new [] { "HealAmount" });
            }

            yield break;
        }
    }

}
