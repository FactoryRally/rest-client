/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.13.2
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
    /// The map including the tiles
    /// </summary>
    [DataContract]
    public partial class Map :  IEquatable<Map>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Map" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Map() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Map" /> class.
        /// </summary>
        /// <param name="info">info.</param>
        /// <param name="rows">a flattend array representing the tiles of the map   to project it onto a 2D plane use &#x60;[x, y] &#x3D;&gt; [y*width+x]&#x60; (required).</param>
        /// <param name="height">The height (rows) of the map (required).</param>
        /// <param name="width">The width (columns) of the map (required).</param>
        public Map(MapInfo info = default(MapInfo), List<Tile> rows = default(List<Tile>), int height = default(int), int width = default(int))
        {
            // to ensure "rows" is required (not null)
            this.Rows = rows ?? throw new ArgumentNullException("rows is a required property for Map and cannot be null");
            this.Height = height;
            this.Width = width;
            this.Info = info;
        }
        
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public MapInfo Info { get; set; }

        /// <summary>
        /// a flattend array representing the tiles of the map   to project it onto a 2D plane use &#x60;[x, y] &#x3D;&gt; [y*width+x]&#x60;
        /// </summary>
        /// <value>a flattend array representing the tiles of the map   to project it onto a 2D plane use &#x60;[x, y] &#x3D;&gt; [y*width+x]&#x60;</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<Tile> Rows { get; set; }

        /// <summary>
        /// The height (rows) of the map
        /// </summary>
        /// <value>The height (rows) of the map</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int Height { get; set; }

        /// <summary>
        /// The width (columns) of the map
        /// </summary>
        /// <value>The width (columns) of the map</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Map {\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as Map);
        }

        /// <summary>
        /// Returns true if Map instances are equal
        /// </summary>
        /// <param name="input">Instance of Map to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Map input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
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
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Width.GetHashCode();
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
            // Height (int) maximum
            if(this.Height > (int)500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value less than or equal to 500.", new [] { "Height" });
            }

            // Height (int) minimum
            if(this.Height < (int)4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value greater than or equal to 4.", new [] { "Height" });
            }

            // Width (int) maximum
            if(this.Width > (int)500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Width, must be a value less than or equal to 500.", new [] { "Width" });
            }

            // Width (int) minimum
            if(this.Width < (int)4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Width, must be a value greater than or equal to 4.", new [] { "Width" });
            }

            yield break;
        }
    }

}
