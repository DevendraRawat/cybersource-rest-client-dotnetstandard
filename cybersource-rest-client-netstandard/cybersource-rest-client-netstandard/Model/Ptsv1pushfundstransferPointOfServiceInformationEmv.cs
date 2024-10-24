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
    /// Ptsv1pushfundstransferPointOfServiceInformationEmv
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferPointOfServiceInformationEmv :  IEquatable<Ptsv1pushfundstransferPointOfServiceInformationEmv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferPointOfServiceInformationEmv" /> class.
        /// </summary>
        /// <param name="CardSequenceNumber">Number assigned to a specific card when two or more cards are associated with the same primary account number.  This value enables issuers to distinguish among multiple cards that are linked to the same account.  This value can also act as a tracking tool when reissuing cards.  When this value is available, it is provided by the chip reader.  When the chip reader does not provide this value, do not include this field in your request.  When sequence number is not provided via this API field, the value is extracted from EMV tag 5F34 for Mastercard transactions. To enable this feature please call support.  Note Card present information about EMV applies only to credit card processing and PIN debit processing.  All other card present information applies only to credit card processing. .</param>
        public Ptsv1pushfundstransferPointOfServiceInformationEmv(string CardSequenceNumber = default(string))
        {
            this.CardSequenceNumber = CardSequenceNumber;
        }
        
        /// <summary>
        /// Number assigned to a specific card when two or more cards are associated with the same primary account number.  This value enables issuers to distinguish among multiple cards that are linked to the same account.  This value can also act as a tracking tool when reissuing cards.  When this value is available, it is provided by the chip reader.  When the chip reader does not provide this value, do not include this field in your request.  When sequence number is not provided via this API field, the value is extracted from EMV tag 5F34 for Mastercard transactions. To enable this feature please call support.  Note Card present information about EMV applies only to credit card processing and PIN debit processing.  All other card present information applies only to credit card processing. 
        /// </summary>
        /// <value>Number assigned to a specific card when two or more cards are associated with the same primary account number.  This value enables issuers to distinguish among multiple cards that are linked to the same account.  This value can also act as a tracking tool when reissuing cards.  When this value is available, it is provided by the chip reader.  When the chip reader does not provide this value, do not include this field in your request.  When sequence number is not provided via this API field, the value is extracted from EMV tag 5F34 for Mastercard transactions. To enable this feature please call support.  Note Card present information about EMV applies only to credit card processing and PIN debit processing.  All other card present information applies only to credit card processing. </value>
        [DataMember(Name="cardSequenceNumber", EmitDefaultValue=false)]
        public string CardSequenceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferPointOfServiceInformationEmv {\n");
            sb.Append("  CardSequenceNumber: ").Append(CardSequenceNumber).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferPointOfServiceInformationEmv);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferPointOfServiceInformationEmv instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferPointOfServiceInformationEmv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferPointOfServiceInformationEmv other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardSequenceNumber == other.CardSequenceNumber ||
                    this.CardSequenceNumber != null &&
                    this.CardSequenceNumber.Equals(other.CardSequenceNumber)
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
                if (this.CardSequenceNumber != null)
                    hash = hash * 59 + this.CardSequenceNumber.GetHashCode();
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
