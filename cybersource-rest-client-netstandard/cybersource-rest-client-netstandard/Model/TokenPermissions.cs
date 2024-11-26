/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// TokenPermissions
    /// </summary>
    [DataContract]
    public partial class TokenPermissions :  IEquatable<TokenPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPermissions" /> class.
        /// </summary>
        /// <param name="Create">Indicates if tokens may be created.</param>
        /// <param name="Read">Indicates if tokens may be read.</param>
        /// <param name="Update">Indicates if tokens may be updated.</param>
        /// <param name="Delete">Indicates if tokens may be deleted.</param>
        public TokenPermissions(bool? Create = default(bool?), bool? Read = default(bool?), bool? Update = default(bool?), bool? Delete = default(bool?))
        {
            this.Create = Create;
            this.Read = Read;
            this.Update = Update;
            this.Delete = Delete;
        }
        
        /// <summary>
        /// Indicates if tokens may be created
        /// </summary>
        /// <value>Indicates if tokens may be created</value>
        [DataMember(Name="create", EmitDefaultValue=false)]
        public bool? Create { get; set; }

        /// <summary>
        /// Indicates if tokens may be read
        /// </summary>
        /// <value>Indicates if tokens may be read</value>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }

        /// <summary>
        /// Indicates if tokens may be updated
        /// </summary>
        /// <value>Indicates if tokens may be updated</value>
        [DataMember(Name="update", EmitDefaultValue=false)]
        public bool? Update { get; set; }

        /// <summary>
        /// Indicates if tokens may be deleted
        /// </summary>
        /// <value>Indicates if tokens may be deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenPermissions {\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TokenPermissions);
        }

        /// <summary>
        /// Returns true if TokenPermissions instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenPermissions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Create == other.Create ||
                    this.Create != null &&
                    this.Create.Equals(other.Create)
                ) && 
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) && 
                (
                    this.Update == other.Update ||
                    this.Update != null &&
                    this.Update.Equals(other.Update)
                ) && 
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Create != null)
                    hash = hash * 59 + this.Create.GetHashCode();
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                if (this.Update != null)
                    hash = hash * 59 + this.Update.GetHashCode();
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                return hash;
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
