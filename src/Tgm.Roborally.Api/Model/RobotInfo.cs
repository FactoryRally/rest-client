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
    /// Describes the state/stats of a robot
    /// </summary>
    [DataContract]
    public partial class RobotInfo :  IEquatable<RobotInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public Direction Direction { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public Robots? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RobotInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotInfo" /> class.
        /// </summary>
        /// <param name="direction">direction (required).</param>
        /// <param name="name">The default rule for names in the game (required).</param>
        /// <param name="id">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        /// <param name="location">location (required).</param>
        /// <param name="energyCubes">The number of avainable energy cubes (default to 3).</param>
        /// <param name="health">The remaining health points (default to 10).</param>
        /// <param name="active">True if the robot is not in rebooting mode (default to true).</param>
        /// <param name="_virtual">If the robot is in virtual mode (default to false).</param>
        /// <param name="priority">The priority of this player. Higher is more priority. 1 &#x3D; lowest. max &#x3D; number of players.</param>
        /// <param name="onTurn">True if the robot is currently active (executing a register).</param>
        /// <param name="isMine">True if you are the one controlling the robot.</param>
        /// <param name="handCards">The cards in the hand of the robot.</param>
        /// <param name="attitude">The height level of the robot (default to 0).</param>
        /// <param name="type">type.</param>
        public RobotInfo(Direction direction = default(Direction), string name = default(string), int id = default(int), Position location = default(Position), int energyCubes = 3, int health = 10, bool active = true, bool _virtual = false, int priority = default(int), bool onTurn = default(bool), bool isMine = default(bool), int handCards = default(int), int attitude = 0, Robots? type = default(Robots?))
        {
            this.Direction = direction;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for RobotInfo and cannot be null");
            // to ensure "location" is required (not null)
            this.Location = location ?? throw new ArgumentNullException("location is a required property for RobotInfo and cannot be null");
            this.Id = id;
            this.EnergyCubes = energyCubes;
            this.Health = health;
            this.Active = active;
            this.Virtual = _virtual;
            this.Priority = priority;
            this.OnTurn = onTurn;
            this.IsMine = isMine;
            this.HandCards = handCards;
            this.Attitude = attitude;
            this.Type = type;
        }
        
        /// <summary>
        /// The default rule for names in the game
        /// </summary>
        /// <value>The default rule for names in the game</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Position Location { get; set; }

        /// <summary>
        /// The number of avainable energy cubes
        /// </summary>
        /// <value>The number of avainable energy cubes</value>
        [DataMember(Name="energy-cubes", EmitDefaultValue=false)]
        public int EnergyCubes { get; set; }

        /// <summary>
        /// The remaining health points
        /// </summary>
        /// <value>The remaining health points</value>
        [DataMember(Name="health", EmitDefaultValue=false)]
        public int Health { get; set; }

        /// <summary>
        /// True if the robot is not in rebooting mode
        /// </summary>
        /// <value>True if the robot is not in rebooting mode</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// If the robot is in virtual mode
        /// </summary>
        /// <value>If the robot is in virtual mode</value>
        [DataMember(Name="virtual", EmitDefaultValue=false)]
        public bool Virtual { get; set; }

        /// <summary>
        /// The priority of this player. Higher is more priority. 1 &#x3D; lowest. max &#x3D; number of players
        /// </summary>
        /// <value>The priority of this player. Higher is more priority. 1 &#x3D; lowest. max &#x3D; number of players</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int Priority { get; set; }

        /// <summary>
        /// True if the robot is currently active (executing a register)
        /// </summary>
        /// <value>True if the robot is currently active (executing a register)</value>
        [DataMember(Name="on-turn", EmitDefaultValue=false)]
        public bool OnTurn { get; set; }

        /// <summary>
        /// True if you are the one controlling the robot
        /// </summary>
        /// <value>True if you are the one controlling the robot</value>
        [DataMember(Name="is-mine", EmitDefaultValue=false)]
        public bool IsMine { get; set; }

        /// <summary>
        /// The cards in the hand of the robot
        /// </summary>
        /// <value>The cards in the hand of the robot</value>
        [DataMember(Name="hand-cards", EmitDefaultValue=false)]
        public int HandCards { get; set; }

        /// <summary>
        /// The height level of the robot
        /// </summary>
        /// <value>The height level of the robot</value>
        [DataMember(Name="attitude", EmitDefaultValue=false)]
        public int Attitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RobotInfo {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  EnergyCubes: ").Append(EnergyCubes).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Virtual: ").Append(Virtual).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  OnTurn: ").Append(OnTurn).Append("\n");
            sb.Append("  IsMine: ").Append(IsMine).Append("\n");
            sb.Append("  HandCards: ").Append(HandCards).Append("\n");
            sb.Append("  Attitude: ").Append(Attitude).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as RobotInfo);
        }

        /// <summary>
        /// Returns true if RobotInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RobotInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.EnergyCubes == input.EnergyCubes ||
                    this.EnergyCubes.Equals(input.EnergyCubes)
                ) && 
                (
                    this.Health == input.Health ||
                    this.Health.Equals(input.Health)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Virtual == input.Virtual ||
                    this.Virtual.Equals(input.Virtual)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.OnTurn == input.OnTurn ||
                    this.OnTurn.Equals(input.OnTurn)
                ) && 
                (
                    this.IsMine == input.IsMine ||
                    this.IsMine.Equals(input.IsMine)
                ) && 
                (
                    this.HandCards == input.HandCards ||
                    this.HandCards.Equals(input.HandCards)
                ) && 
                (
                    this.Attitude == input.Attitude ||
                    this.Attitude.Equals(input.Attitude)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.EnergyCubes.GetHashCode();
                hashCode = hashCode * 59 + this.Health.GetHashCode();
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                hashCode = hashCode * 59 + this.Virtual.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                hashCode = hashCode * 59 + this.OnTurn.GetHashCode();
                hashCode = hashCode * 59 + this.IsMine.GetHashCode();
                hashCode = hashCode * 59 + this.HandCards.GetHashCode();
                hashCode = hashCode * 59 + this.Attitude.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 13.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"[A-Za-z]+[A-Za-z0-9_ -]+[A-Za-z0-9]{1}", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Id (int) minimum
            if(this.Id < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            // EnergyCubes (int) maximum
            if(this.EnergyCubes > (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EnergyCubes, must be a value less than or equal to 20.", new [] { "EnergyCubes" });
            }

            // EnergyCubes (int) minimum
            if(this.EnergyCubes < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EnergyCubes, must be a value greater than or equal to 0.", new [] { "EnergyCubes" });
            }

            // Health (int) maximum
            if(this.Health > (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Health, must be a value less than or equal to 10.", new [] { "Health" });
            }

            // Health (int) minimum
            if(this.Health < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Health, must be a value greater than or equal to 1.", new [] { "Health" });
            }

            // Priority (int) maximum
            if(this.Priority > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value less than or equal to 8.", new [] { "Priority" });
            }

            // Priority (int) minimum
            if(this.Priority < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value greater than or equal to 1.", new [] { "Priority" });
            }

            // HandCards (int) maximum
            if(this.HandCards > (int)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HandCards, must be a value less than or equal to 9.", new [] { "HandCards" });
            }

            // HandCards (int) minimum
            if(this.HandCards < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HandCards, must be a value greater than or equal to 0.", new [] { "HandCards" });
            }

            // Attitude (int) maximum
            if(this.Attitude > (int)4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Attitude, must be a value less than or equal to 4.", new [] { "Attitude" });
            }

            // Attitude (int) minimum
            if(this.Attitude < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Attitude, must be a value greater than or equal to 0.", new [] { "Attitude" });
            }

            yield break;
        }
    }

}
