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
    /// The event when a player places or removes an robot command from/to a register
    /// </summary>
    [DataContract]
    public partial class ChangeRegisterEvent :  IEquatable<ChangeRegisterEvent>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Fill for value: fill
            /// </summary>
            [EnumMember(Value = "fill")]
            Fill = 1,

            /// <summary>
            /// Enum Clear for value: clear
            /// </summary>
            [EnumMember(Value = "clear")]
            Clear = 2,

            /// <summary>
            /// Enum Replace for value: replace
            /// </summary>
            [EnumMember(Value = "replace")]
            Replace = 3

        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeRegisterEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeRegisterEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeRegisterEvent" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="card">The id of an upgrade. **Unique**.</param>
        /// <param name="register">The changed register (required).</param>
        /// <param name="robotId">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        public ChangeRegisterEvent(ActionEnum action = default(ActionEnum), int card = default(int), int register = default(int), int robotId = default(int))
        {
            this.Action = action;
            this.Register = register;
            this.Card = card;
            this.RobotId = robotId;
        }
        
        /// <summary>
        /// The id of an upgrade. **Unique**
        /// </summary>
        /// <value>The id of an upgrade. **Unique**</value>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public int Card { get; set; }

        /// <summary>
        /// The changed register
        /// </summary>
        /// <value>The changed register</value>
        [DataMember(Name="register", EmitDefaultValue=false)]
        public int Register { get; set; }

        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="robotId", EmitDefaultValue=false)]
        public int RobotId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeRegisterEvent {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Register: ").Append(Register).Append("\n");
            sb.Append("  RobotId: ").Append(RobotId).Append("\n");
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
            return this.Equals(input as ChangeRegisterEvent);
        }

        /// <summary>
        /// Returns true if ChangeRegisterEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeRegisterEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeRegisterEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Card == input.Card ||
                    this.Card.Equals(input.Card)
                ) && 
                (
                    this.Register == input.Register ||
                    this.Register.Equals(input.Register)
                ) && 
                (
                    this.RobotId == input.RobotId ||
                    this.RobotId.Equals(input.RobotId)
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Card.GetHashCode();
                hashCode = hashCode * 59 + this.Register.GetHashCode();
                hashCode = hashCode * 59 + this.RobotId.GetHashCode();
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
            // Card (int) maximum
            if(this.Card > (int)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Card, must be a value less than or equal to 10000.", new [] { "Card" });
            }

            // Card (int) minimum
            if(this.Card < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Card, must be a value greater than or equal to 0.", new [] { "Card" });
            }

            // Register (int) maximum
            if(this.Register > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Register, must be a value less than or equal to 8.", new [] { "Register" });
            }

            // Register (int) minimum
            if(this.Register < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Register, must be a value greater than or equal to 0.", new [] { "Register" });
            }

            // RobotId (int) minimum
            if(this.RobotId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RobotId, must be a value greater than or equal to 0.", new [] { "RobotId" });
            }

            yield break;
        }
    }

}
