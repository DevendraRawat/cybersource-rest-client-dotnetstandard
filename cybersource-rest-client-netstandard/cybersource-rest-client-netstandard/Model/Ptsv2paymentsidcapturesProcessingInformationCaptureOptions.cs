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
    /// Ptsv2paymentsidcapturesProcessingInformationCaptureOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesProcessingInformationCaptureOptions :  IEquatable<Ptsv2paymentsidcapturesProcessingInformationCaptureOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesProcessingInformationCaptureOptions" /> class.
        /// </summary>
        /// <param name="CaptureSequenceNumber">Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; .</param>
        /// <param name="TotalCaptureCount">Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; .</param>
        /// <param name="IsFinal">Indicates whether to release the authorization hold on the remaining funds.   Possible Values: - &#x60;true&#x60; - &#x60;false&#x60; .</param>
        /// <param name="Notes">An informational note about this settlement. Appears in both the payer&#39;s transaction history and the emails that the payer receives. .</param>
        public Ptsv2paymentsidcapturesProcessingInformationCaptureOptions(int? CaptureSequenceNumber = default(int?), int? TotalCaptureCount = default(int?), string IsFinal = default(string), string Notes = default(string))
        {
            this.CaptureSequenceNumber = CaptureSequenceNumber;
            this.TotalCaptureCount = TotalCaptureCount;
            this.IsFinal = IsFinal;
            this.Notes = Notes;
        }
        
        /// <summary>
        /// Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; 
        /// </summary>
        /// <value>Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; </value>
        [DataMember(Name="captureSequenceNumber", EmitDefaultValue=false)]
        public int? CaptureSequenceNumber { get; set; }

        /// <summary>
        /// Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; 
        /// </summary>
        /// <value>Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; </value>
        [DataMember(Name="totalCaptureCount", EmitDefaultValue=false)]
        public int? TotalCaptureCount { get; set; }

        /// <summary>
        /// Indicates whether to release the authorization hold on the remaining funds.   Possible Values: - &#x60;true&#x60; - &#x60;false&#x60; 
        /// </summary>
        /// <value>Indicates whether to release the authorization hold on the remaining funds.   Possible Values: - &#x60;true&#x60; - &#x60;false&#x60; </value>
        [DataMember(Name="isFinal", EmitDefaultValue=false)]
        public string IsFinal { get; set; }

        /// <summary>
        /// An informational note about this settlement. Appears in both the payer&#39;s transaction history and the emails that the payer receives. 
        /// </summary>
        /// <value>An informational note about this settlement. Appears in both the payer&#39;s transaction history and the emails that the payer receives. </value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesProcessingInformationCaptureOptions {\n");
            sb.Append("  CaptureSequenceNumber: ").Append(CaptureSequenceNumber).Append("\n");
            sb.Append("  TotalCaptureCount: ").Append(TotalCaptureCount).Append("\n");
            sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesProcessingInformationCaptureOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesProcessingInformationCaptureOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesProcessingInformationCaptureOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesProcessingInformationCaptureOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CaptureSequenceNumber == other.CaptureSequenceNumber ||
                    this.CaptureSequenceNumber != null &&
                    this.CaptureSequenceNumber.Equals(other.CaptureSequenceNumber)
                ) && 
                (
                    this.TotalCaptureCount == other.TotalCaptureCount ||
                    this.TotalCaptureCount != null &&
                    this.TotalCaptureCount.Equals(other.TotalCaptureCount)
                ) && 
                (
                    this.IsFinal == other.IsFinal ||
                    this.IsFinal != null &&
                    this.IsFinal.Equals(other.IsFinal)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
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
                if (this.CaptureSequenceNumber != null)
                    hash = hash * 59 + this.CaptureSequenceNumber.GetHashCode();
                if (this.TotalCaptureCount != null)
                    hash = hash * 59 + this.TotalCaptureCount.GetHashCode();
                if (this.IsFinal != null)
                    hash = hash * 59 + this.IsFinal.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
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
