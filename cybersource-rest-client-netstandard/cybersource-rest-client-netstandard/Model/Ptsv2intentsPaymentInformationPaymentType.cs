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
    /// Ptsv2intentsPaymentInformationPaymentType
    /// </summary>
    [DataContract]
    public partial class Ptsv2intentsPaymentInformationPaymentType :  IEquatable<Ptsv2intentsPaymentInformationPaymentType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2intentsPaymentInformationPaymentType" /> class.
        /// </summary>
        /// <param name="Name">A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. Possible values: - &#x60;CARD&#x60; (use this for a PIN debit transaction) - &#x60;CHECK&#x60; (use this for all eCheck payment transactions - ECP Debit, ECP Follow-on Credit, ECP StandAlone Credit) - &#x60;bankTransfer&#x60; (use for Online Bank Transafer for methods such as P24, iDeal, Estonia Bank, KCP) - &#x60;localCard&#x60; (KCP Local card via Altpay) - &#x60;carrierBilling&#x60; (KCP Carrier Billing via Altpay) .</param>
        /// <param name="Method">Method.</param>
        public Ptsv2intentsPaymentInformationPaymentType(string Name = default(string), Ptsv2intentsPaymentInformationPaymentTypeMethod Method = default(Ptsv2intentsPaymentInformationPaymentTypeMethod))
        {
            this.Name = Name;
            this.Method = Method;
        }
        
        /// <summary>
        /// A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. Possible values: - &#x60;CARD&#x60; (use this for a PIN debit transaction) - &#x60;CHECK&#x60; (use this for all eCheck payment transactions - ECP Debit, ECP Follow-on Credit, ECP StandAlone Credit) - &#x60;bankTransfer&#x60; (use for Online Bank Transafer for methods such as P24, iDeal, Estonia Bank, KCP) - &#x60;localCard&#x60; (KCP Local card via Altpay) - &#x60;carrierBilling&#x60; (KCP Carrier Billing via Altpay) 
        /// </summary>
        /// <value>A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. Possible values: - &#x60;CARD&#x60; (use this for a PIN debit transaction) - &#x60;CHECK&#x60; (use this for all eCheck payment transactions - ECP Debit, ECP Follow-on Credit, ECP StandAlone Credit) - &#x60;bankTransfer&#x60; (use for Online Bank Transafer for methods such as P24, iDeal, Estonia Bank, KCP) - &#x60;localCard&#x60; (KCP Local card via Altpay) - &#x60;carrierBilling&#x60; (KCP Carrier Billing via Altpay) </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public Ptsv2intentsPaymentInformationPaymentTypeMethod Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2intentsPaymentInformationPaymentType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(obj as Ptsv2intentsPaymentInformationPaymentType);
        }

        /// <summary>
        /// Returns true if Ptsv2intentsPaymentInformationPaymentType instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2intentsPaymentInformationPaymentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2intentsPaymentInformationPaymentType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
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
