/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.11.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Tgm.Roborally.Api.Client.OpenAPIDateConverter;

namespace Tgm.Roborally.Api.Model
{
    /// <summary>
    /// UpgradeShopInformation
    /// </summary>
    [DataContract(Name = "UpgradeShopInformation")]
    public partial class UpgradeShopInformation : IEquatable<UpgradeShopInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeShopInformation" /> class.
        /// </summary>
        /// <param name="open">if true you can buy uprades (default to true).</param>
        public UpgradeShopInformation(bool open = true)
        {
            this.Open = open;
        }

        /// <summary>
        /// if true you can buy uprades
        /// </summary>
        /// <value>if true you can buy uprades</value>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public bool Open { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeShopInformation {\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeShopInformation);
        }

        /// <summary>
        /// Returns true if UpgradeShopInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradeShopInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradeShopInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Open == input.Open ||
                    this.Open.Equals(input.Open)
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
                hashCode = hashCode * 59 + this.Open.GetHashCode();
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
            yield break;
        }
    }

}
