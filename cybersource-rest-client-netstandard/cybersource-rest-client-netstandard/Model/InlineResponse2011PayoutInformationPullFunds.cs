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
    /// InlineResponse2011PayoutInformationPullFunds
    /// </summary>
    [DataContract]
    public partial class InlineResponse2011PayoutInformationPullFunds :  IEquatable<InlineResponse2011PayoutInformationPullFunds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011PayoutInformationPullFunds" /> class.
        /// </summary>
        /// <param name="DomesticParticipant">This field indicates if domestic AFTs (pull funds) are allowed. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service(PPGS). Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60; .</param>
        /// <param name="CrossBorderParticipant">This field indicates if cross-border AFTs (pull funds) are allowed. Note: Supported only in US for cross-border transactions involving Push Payments Gateway Service(PPGS). Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60; .</param>
        public InlineResponse2011PayoutInformationPullFunds(string DomesticParticipant = default(string), string CrossBorderParticipant = default(string))
        {
            this.DomesticParticipant = DomesticParticipant;
            this.CrossBorderParticipant = CrossBorderParticipant;
        }
        
        /// <summary>
        /// This field indicates if domestic AFTs (pull funds) are allowed. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service(PPGS). Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60; 
        /// </summary>
        /// <value>This field indicates if domestic AFTs (pull funds) are allowed. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service(PPGS). Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60; </value>
        [DataMember(Name="domesticParticipant", EmitDefaultValue=false)]
        public string DomesticParticipant { get; set; }

        /// <summary>
        /// This field indicates if cross-border AFTs (pull funds) are allowed. Note: Supported only in US for cross-border transactions involving Push Payments Gateway Service(PPGS). Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60; 
        /// </summary>
        /// <value>This field indicates if cross-border AFTs (pull funds) are allowed. Note: Supported only in US for cross-border transactions involving Push Payments Gateway Service(PPGS). Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60; </value>
        [DataMember(Name="crossBorderParticipant", EmitDefaultValue=false)]
        public string CrossBorderParticipant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011PayoutInformationPullFunds {\n");
            sb.Append("  DomesticParticipant: ").Append(DomesticParticipant).Append("\n");
            sb.Append("  CrossBorderParticipant: ").Append(CrossBorderParticipant).Append("\n");
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
            return this.Equals(obj as InlineResponse2011PayoutInformationPullFunds);
        }

        /// <summary>
        /// Returns true if InlineResponse2011PayoutInformationPullFunds instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2011PayoutInformationPullFunds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2011PayoutInformationPullFunds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DomesticParticipant == other.DomesticParticipant ||
                    this.DomesticParticipant != null &&
                    this.DomesticParticipant.Equals(other.DomesticParticipant)
                ) && 
                (
                    this.CrossBorderParticipant == other.CrossBorderParticipant ||
                    this.CrossBorderParticipant != null &&
                    this.CrossBorderParticipant.Equals(other.CrossBorderParticipant)
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
                if (this.DomesticParticipant != null)
                    hash = hash * 59 + this.DomesticParticipant.GetHashCode();
                if (this.CrossBorderParticipant != null)
                    hash = hash * 59 + this.CrossBorderParticipant.GetHashCode();
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
