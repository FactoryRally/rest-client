/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.9.0
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
    /// The event that occurs if a player gets his programming cards
    /// </summary>
    [DataContract]
    public partial class DrawCardEvent :  IEquatable<DrawCardEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCardEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DrawCardEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCardEvent" /> class.
        /// </summary>
        /// <param name="player">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication (required).</param>
        /// <param name="count">The number of cards drawn (required).</param>
        /// <param name="cards">The drawn cards. **This is only visible for the player himself**.</param>
        public DrawCardEvent(int player = default(int), int count = default(int), List<int> cards = default(List<int>))
        {
            this.Player = player;
            this.Count = count;
            this.Cards = cards;
        }
        
        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public int Player { get; set; }

        /// <summary>
        /// The number of cards drawn
        /// </summary>
        /// <value>The number of cards drawn</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; set; }

        /// <summary>
        /// The drawn cards. **This is only visible for the player himself**
        /// </summary>
        /// <value>The drawn cards. **This is only visible for the player himself**</value>
        [DataMember(Name="cards", EmitDefaultValue=false)]
        public List<int> Cards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrawCardEvent {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
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
            return this.Equals(input as DrawCardEvent);
        }

        /// <summary>
        /// Returns true if DrawCardEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of DrawCardEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrawCardEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Player == input.Player ||
                    this.Player.Equals(input.Player)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Cards == input.Cards ||
                    this.Cards != null &&
                    input.Cards != null &&
                    this.Cards.SequenceEqual(input.Cards)
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
                hashCode = hashCode * 59 + this.Player.GetHashCode();
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Cards != null)
                    hashCode = hashCode * 59 + this.Cards.GetHashCode();
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
            // Player (int) maximum
            if(this.Player > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Player, must be a value less than or equal to 8.", new [] { "Player" });
            }

            // Player (int) minimum
            if(this.Player < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Player, must be a value greater than or equal to 0.", new [] { "Player" });
            }

            // Count (int) maximum
            if(this.Count > (int)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value less than or equal to 9.", new [] { "Count" });
            }

            // Count (int) minimum
            if(this.Count < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to 0.", new [] { "Count" });
            }

            yield break;
        }
    }

}
