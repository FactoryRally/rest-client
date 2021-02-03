/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.8.0
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
    /// A command for a robot to execute
    /// </summary>
    [DataContract]
    public partial class RobotCommand :  IEquatable<RobotCommand>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public Instruction Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RobotCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCommand" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="parameters">Defines parameters for the instruction.&lt;br&gt;Example: Effect: \&quot;Move {steps} steps forward\&quot;&lt;br&gt; &#x60;{steps}&#x60; is the number of steps the robot will do. And the exact value (of steps) will be defined in here (&#x60;values&#x60;).</param>
        /// <param name="description">A description about the effect of the command. Variables are using the format &#x60;{name}&#x60; where *name* refers to the names in &#x60;values&#x60;.  (default to &quot;null&quot;).</param>
        /// <param name="name">The ame to display for this Command. ***Not*** unique (identifying).</param>
        /// <param name="times">Describes how often this command is going to be executed (default to 1).</param>
        public RobotCommand(Instruction type = default(Instruction), List<Pair> parameters = default(List<Pair>), string description = "null", string name = default(string), int times = 1)
        {
            this.Type = type;
            this.Parameters = parameters;
            // use default value if no "description" provided
            this.Description = description ?? "null";
            this.Name = name;
            this.Times = times;
        }
        
        /// <summary>
        /// Defines parameters for the instruction.&lt;br&gt;Example: Effect: \&quot;Move {steps} steps forward\&quot;&lt;br&gt; &#x60;{steps}&#x60; is the number of steps the robot will do. And the exact value (of steps) will be defined in here (&#x60;values&#x60;)
        /// </summary>
        /// <value>Defines parameters for the instruction.&lt;br&gt;Example: Effect: \&quot;Move {steps} steps forward\&quot;&lt;br&gt; &#x60;{steps}&#x60; is the number of steps the robot will do. And the exact value (of steps) will be defined in here (&#x60;values&#x60;)</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<Pair> Parameters { get; set; }

        /// <summary>
        /// A description about the effect of the command. Variables are using the format &#x60;{name}&#x60; where *name* refers to the names in &#x60;values&#x60;. 
        /// </summary>
        /// <value>A description about the effect of the command. Variables are using the format &#x60;{name}&#x60; where *name* refers to the names in &#x60;values&#x60;. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ame to display for this Command. ***Not*** unique (identifying)
        /// </summary>
        /// <value>The ame to display for this Command. ***Not*** unique (identifying)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Describes how often this command is going to be executed
        /// </summary>
        /// <value>Describes how often this command is going to be executed</value>
        [DataMember(Name="times", EmitDefaultValue=false)]
        public int Times { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RobotCommand {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Times: ").Append(Times).Append("\n");
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
            return this.Equals(input as RobotCommand);
        }

        /// <summary>
        /// Returns true if RobotCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of RobotCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Times == input.Times ||
                    this.Times.Equals(input.Times)
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Times.GetHashCode();
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 27)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 27.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 2.", new [] { "Name" });
            }

            // Times (int) maximum
            if(this.Times > (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Times, must be a value less than or equal to 10.", new [] { "Times" });
            }

            // Times (int) minimum
            if(this.Times < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Times, must be a value greater than or equal to 1.", new [] { "Times" });
            }

            yield break;
        }
    }

}
