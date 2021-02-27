/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.2.0
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
    /// The action to make an entity use an upgade card (including the actions which require additional information)
    /// </summary>
    [DataContract]
    public partial class EntityUseUpgradeAction :  IEquatable<EntityUseUpgradeAction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public EntityActionPhase? Phase { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public EntityActionType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityUseUpgradeAction" /> class.
        /// </summary>
        /// <param name="phase">phase.</param>
        /// <param name="type">type.</param>
        /// <param name="upgrade">The id of an upgrade. **Unique**.</param>
        public EntityUseUpgradeAction(EntityActionPhase? phase = default(EntityActionPhase?), EntityActionType? type = default(EntityActionType?), int upgrade = default(int))
        {
            this.Phase = phase;
            this.Type = type;
            this.Upgrade = upgrade;
        }
        
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
            sb.Append("class EntityUseUpgradeAction {\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as EntityUseUpgradeAction);
        }

        /// <summary>
        /// Returns true if EntityUseUpgradeAction instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityUseUpgradeAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityUseUpgradeAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phase == input.Phase ||
                    this.Phase.Equals(input.Phase)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Phase.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
