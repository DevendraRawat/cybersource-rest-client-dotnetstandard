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
    /// TssV2TransactionsGet200ResponseLinks
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseLinks :  IEquatable<TssV2TransactionsGet200ResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="RelatedTransactions">RelatedTransactions.</param>
        public TssV2TransactionsGet200ResponseLinks(PtsV2PaymentsPost201ResponseLinksSelf Self = default(PtsV2PaymentsPost201ResponseLinksSelf), List<PtsV2PaymentsPost201ResponseLinksSelf> RelatedTransactions = default(List<PtsV2PaymentsPost201ResponseLinksSelf>))
        {
            this.Self = Self;
            this.RelatedTransactions = RelatedTransactions;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets RelatedTransactions
        /// </summary>
        [DataMember(Name="relatedTransactions", EmitDefaultValue=false)]
        public List<PtsV2PaymentsPost201ResponseLinksSelf> RelatedTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  RelatedTransactions: ").Append(RelatedTransactions).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseLinks);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.RelatedTransactions == other.RelatedTransactions ||
                    this.RelatedTransactions != null &&
                    this.RelatedTransactions.SequenceEqual(other.RelatedTransactions)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.RelatedTransactions != null)
                    hash = hash * 59 + this.RelatedTransactions.GetHashCode();
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