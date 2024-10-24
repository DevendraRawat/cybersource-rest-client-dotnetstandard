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
    /// PushFunds201ResponseErrorInformation
    /// </summary>
    [DataContract]
    public partial class PushFunds201ResponseErrorInformation :  IEquatable<PushFunds201ResponseErrorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushFunds201ResponseErrorInformation" /> class.
        /// </summary>
        /// <param name="Reason">The reason of the status.  Possible values:  - CONTACT_PROCESSOR - INVALID_MERCHANT_CONFIGURATION - STOLEN_LOST_CARD - PROCESSOR_DECLINED - PARTIAL_APPROVAL - PAYMENT_REFUSED - INVALID_ACCOUNT - ISSUER_UNAVAILABLE - INSUFFICIENT_FUND - EXPIRED_CARD - INVALID_PIN - UNAUTHORIZED_CARD - EXCEEDS_CREDIT_LIMIT - DEBIT_CARD_USAGE_LIMIT_EXCEEDED - CVN_NOT_MATCH - DUPLICATE_REQUEST - GENERAL_DECLINE - BLACKLISTED_CUSTOMER - GATEWAY_TIMEOUT - INVALID_DATA - SYSTEM_ERROR - SERVICE_UNAVAILABLE - GATEWAY_TIMEOUT - DAGGDENIED .</param>
        /// <param name="Message">The detail message related to the status and reason listed above. .</param>
        /// <param name="Details">Details.</param>
        public PushFunds201ResponseErrorInformation(string Reason = default(string), string Message = default(string), List<PushFunds201ResponseErrorInformationDetails> Details = default(List<PushFunds201ResponseErrorInformationDetails>))
        {
            this.Reason = Reason;
            this.Message = Message;
            this.Details = Details;
        }
        
        /// <summary>
        /// The reason of the status.  Possible values:  - CONTACT_PROCESSOR - INVALID_MERCHANT_CONFIGURATION - STOLEN_LOST_CARD - PROCESSOR_DECLINED - PARTIAL_APPROVAL - PAYMENT_REFUSED - INVALID_ACCOUNT - ISSUER_UNAVAILABLE - INSUFFICIENT_FUND - EXPIRED_CARD - INVALID_PIN - UNAUTHORIZED_CARD - EXCEEDS_CREDIT_LIMIT - DEBIT_CARD_USAGE_LIMIT_EXCEEDED - CVN_NOT_MATCH - DUPLICATE_REQUEST - GENERAL_DECLINE - BLACKLISTED_CUSTOMER - GATEWAY_TIMEOUT - INVALID_DATA - SYSTEM_ERROR - SERVICE_UNAVAILABLE - GATEWAY_TIMEOUT - DAGGDENIED 
        /// </summary>
        /// <value>The reason of the status.  Possible values:  - CONTACT_PROCESSOR - INVALID_MERCHANT_CONFIGURATION - STOLEN_LOST_CARD - PROCESSOR_DECLINED - PARTIAL_APPROVAL - PAYMENT_REFUSED - INVALID_ACCOUNT - ISSUER_UNAVAILABLE - INSUFFICIENT_FUND - EXPIRED_CARD - INVALID_PIN - UNAUTHORIZED_CARD - EXCEEDS_CREDIT_LIMIT - DEBIT_CARD_USAGE_LIMIT_EXCEEDED - CVN_NOT_MATCH - DUPLICATE_REQUEST - GENERAL_DECLINE - BLACKLISTED_CUSTOMER - GATEWAY_TIMEOUT - INVALID_DATA - SYSTEM_ERROR - SERVICE_UNAVAILABLE - GATEWAY_TIMEOUT - DAGGDENIED </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The detail message related to the status and reason listed above. 
        /// </summary>
        /// <value>The detail message related to the status and reason listed above. </value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<PushFunds201ResponseErrorInformationDetails> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushFunds201ResponseErrorInformation {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as PushFunds201ResponseErrorInformation);
        }

        /// <summary>
        /// Returns true if PushFunds201ResponseErrorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PushFunds201ResponseErrorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushFunds201ResponseErrorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
