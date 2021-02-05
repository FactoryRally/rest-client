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
    /// All the data you need as you joined a game.
    /// </summary>
    [DataContract]
    public partial class JoinResponse :  IEquatable<JoinResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JoinResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinResponse" /> class.
        /// </summary>
        /// <param name="id">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication (required).</param>
        /// <param name="pat">The uid is the key for the joined player. You need this key for authentication (required).</param>
        public JoinResponse(int id = default(int), string pat = default(string))
        {
            this.Id = id;
            // to ensure "pat" is required (not null)
            this.Pat = pat ?? throw new ArgumentNullException("pat is a required property for JoinResponse and cannot be null");
        }
        
        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The uid is the key for the joined player. You need this key for authentication
        /// </summary>
        /// <value>The uid is the key for the joined player. You need this key for authentication</value>
        [DataMember(Name="pat", EmitDefaultValue=false)]
        public string Pat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Pat: ").Append(Pat).Append("\n");
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
            return this.Equals(input as JoinResponse);
        }

        /// <summary>
        /// Returns true if JoinResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JoinResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Pat == input.Pat ||
                    (this.Pat != null &&
                    this.Pat.Equals(input.Pat))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Pat != null)
                    hashCode = hashCode * 59 + this.Pat.GetHashCode();
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
            // Id (int) maximum
            if(this.Id > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value less than or equal to 8.", new [] { "Id" });
            }

            // Id (int) minimum
            if(this.Id < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 0.", new [] { "Id" });
            }

            yield break;
        }
    }

}
