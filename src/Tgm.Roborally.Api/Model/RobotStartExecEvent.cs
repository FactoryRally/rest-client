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
    /// When a robot is about to execute a programming card/statement
    /// </summary>
    [DataContract]
    public partial class RobotStartExecEvent :  IEquatable<RobotStartExecEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotStartExecEvent" /> class.
        /// </summary>
        /// <param name="robot">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        /// <param name="card">card.</param>
        /// <param name="register">The index of the executed register.</param>
        public RobotStartExecEvent(int robot = default(int), RobotCommand card = default(RobotCommand), int register = default(int))
        {
            this.Robot = robot;
            this.Card = card;
            this.Register = register;
        }
        
        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="robot", EmitDefaultValue=false)]
        public int Robot { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public RobotCommand Card { get; set; }

        /// <summary>
        /// The index of the executed register
        /// </summary>
        /// <value>The index of the executed register</value>
        [DataMember(Name="register", EmitDefaultValue=false)]
        public int Register { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RobotStartExecEvent {\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Register: ").Append(Register).Append("\n");
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
            return this.Equals(input as RobotStartExecEvent);
        }

        /// <summary>
        /// Returns true if RobotStartExecEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RobotStartExecEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotStartExecEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Robot == input.Robot ||
                    this.Robot.Equals(input.Robot)
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.Register == input.Register ||
                    this.Register.Equals(input.Register)
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
                hashCode = hashCode * 59 + this.Robot.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                hashCode = hashCode * 59 + this.Register.GetHashCode();
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

            yield break;
        }
    }

}
