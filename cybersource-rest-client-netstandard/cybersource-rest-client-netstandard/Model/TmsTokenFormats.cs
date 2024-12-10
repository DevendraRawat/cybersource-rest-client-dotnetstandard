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
    /// TmsTokenFormats
    /// </summary>
    [DataContract]
    public partial class TmsTokenFormats :  IEquatable<TmsTokenFormats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsTokenFormats" /> class.
        /// </summary>
        /// <param name="Customer">Format for customer tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; .</param>
        /// <param name="PaymentInstrument">Format for payment instrument tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; .</param>
        /// <param name="InstrumentIdentifierCard">Format for card based instrument identifier tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;16_DIGIT_LAST_4&#39;   - &#39;19_DIGIT&#39;   - &#39;19_DIGIT_LAST_4&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; .</param>
        /// <param name="InstrumentIdentifierBankAccount">Format for bank account based instrument identifier tokens.  Possible Values:    - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; .</param>
        public TmsTokenFormats(string Customer = default(string), string PaymentInstrument = default(string), string InstrumentIdentifierCard = default(string), string InstrumentIdentifierBankAccount = default(string))
        {
            this.Customer = Customer;
            this.PaymentInstrument = PaymentInstrument;
            this.InstrumentIdentifierCard = InstrumentIdentifierCard;
            this.InstrumentIdentifierBankAccount = InstrumentIdentifierBankAccount;
        }
        
        /// <summary>
        /// Format for customer tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; 
        /// </summary>
        /// <value>Format for customer tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; </value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public string Customer { get; set; }

        /// <summary>
        /// Format for payment instrument tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; 
        /// </summary>
        /// <value>Format for payment instrument tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; </value>
        [DataMember(Name="paymentInstrument", EmitDefaultValue=false)]
        public string PaymentInstrument { get; set; }

        /// <summary>
        /// Format for card based instrument identifier tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;16_DIGIT_LAST_4&#39;   - &#39;19_DIGIT&#39;   - &#39;19_DIGIT_LAST_4&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; 
        /// </summary>
        /// <value>Format for card based instrument identifier tokens.  Possible Values:   - &#39;16_DIGIT&#39;   - &#39;16_DIGIT_LAST_4&#39;   - &#39;19_DIGIT&#39;   - &#39;19_DIGIT_LAST_4&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; </value>
        [DataMember(Name="instrumentIdentifierCard", EmitDefaultValue=false)]
        public string InstrumentIdentifierCard { get; set; }

        /// <summary>
        /// Format for bank account based instrument identifier tokens.  Possible Values:    - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; 
        /// </summary>
        /// <value>Format for bank account based instrument identifier tokens.  Possible Values:    - &#39;16_DIGIT&#39;   - &#39;19_DIGIT&#39;   - &#39;22_DIGIT&#39;   - &#39;32_HEX&#39; </value>
        [DataMember(Name="instrumentIdentifierBankAccount", EmitDefaultValue=false)]
        public string InstrumentIdentifierBankAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsTokenFormats {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  PaymentInstrument: ").Append(PaymentInstrument).Append("\n");
            sb.Append("  InstrumentIdentifierCard: ").Append(InstrumentIdentifierCard).Append("\n");
            sb.Append("  InstrumentIdentifierBankAccount: ").Append(InstrumentIdentifierBankAccount).Append("\n");
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
            return this.Equals(obj as TmsTokenFormats);
        }

        /// <summary>
        /// Returns true if TmsTokenFormats instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsTokenFormats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsTokenFormats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.PaymentInstrument == other.PaymentInstrument ||
                    this.PaymentInstrument != null &&
                    this.PaymentInstrument.Equals(other.PaymentInstrument)
                ) && 
                (
                    this.InstrumentIdentifierCard == other.InstrumentIdentifierCard ||
                    this.InstrumentIdentifierCard != null &&
                    this.InstrumentIdentifierCard.Equals(other.InstrumentIdentifierCard)
                ) && 
                (
                    this.InstrumentIdentifierBankAccount == other.InstrumentIdentifierBankAccount ||
                    this.InstrumentIdentifierBankAccount != null &&
                    this.InstrumentIdentifierBankAccount.Equals(other.InstrumentIdentifierBankAccount)
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
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.PaymentInstrument != null)
                    hash = hash * 59 + this.PaymentInstrument.GetHashCode();
                if (this.InstrumentIdentifierCard != null)
                    hash = hash * 59 + this.InstrumentIdentifierCard.GetHashCode();
                if (this.InstrumentIdentifierBankAccount != null)
                    hash = hash * 59 + this.InstrumentIdentifierBankAccount.GetHashCode();
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