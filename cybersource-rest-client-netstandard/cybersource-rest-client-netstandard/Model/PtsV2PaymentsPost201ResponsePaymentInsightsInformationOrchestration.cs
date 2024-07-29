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
    /// PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration" /> class.
        /// </summary>
        /// <param name="InfoCodes">Infocodes indicating which rules were triggered by the Service Orchestration product. .</param>
        public PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration(List<string> InfoCodes = default(List<string>))
        {
            this.InfoCodes = InfoCodes;
        }
        
        /// <summary>
        /// Infocodes indicating which rules were triggered by the Service Orchestration product. 
        /// </summary>
        /// <value>Infocodes indicating which rules were triggered by the Service Orchestration product. </value>
        [DataMember(Name="infoCodes", EmitDefaultValue=false)]
        public List<string> InfoCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration {\n");
            sb.Append("  InfoCodes: ").Append(InfoCodes).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInsightsInformationOrchestration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InfoCodes == other.InfoCodes ||
                    this.InfoCodes != null &&
                    this.InfoCodes.SequenceEqual(other.InfoCodes)
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
                if (this.InfoCodes != null)
                    hash = hash * 59 + this.InfoCodes.GetHashCode();
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
