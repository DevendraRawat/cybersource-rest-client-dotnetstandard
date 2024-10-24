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
    /// Ptsv1pushfundstransferOrderInformationAmountDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferOrderInformationAmountDetails :  IEquatable<Ptsv1pushfundstransferOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferOrderInformationAmountDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ptsv1pushfundstransferOrderInformationAmountDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="TotalAmount">Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  (required).</param>
        /// <param name="Currency">Use a 3-character alpha currency code for currency of the funds transfer.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf  Currency must be supported by the processor.  (required).</param>
        /// <param name="SourceCurrency">Use a 3-character alpha currency code for source currency of the funds transfer. Supported for card and bank account based cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf .</param>
        /// <param name="DestinationCurrency">Use a 3-character alpha currency code for destination currency of the funds transfer. Supported for card and bank account based cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf .</param>
        /// <param name="Surcharge">Surcharge.</param>
        public Ptsv1pushfundstransferOrderInformationAmountDetails(string TotalAmount = default(string), string Currency = default(string), string SourceCurrency = default(string), string DestinationCurrency = default(string), Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge Surcharge = default(Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge))
        {
            this.TotalAmount = TotalAmount;
            this.Currency = Currency;
            this.SourceCurrency = SourceCurrency;
            this.DestinationCurrency = DestinationCurrency;
            this.Surcharge = Surcharge;
        }
        
        /// <summary>
        /// Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places. 
        /// </summary>
        /// <value>Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places. </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Use a 3-character alpha currency code for currency of the funds transfer.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf  Currency must be supported by the processor. 
        /// </summary>
        /// <value>Use a 3-character alpha currency code for currency of the funds transfer.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf  Currency must be supported by the processor. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Use a 3-character alpha currency code for source currency of the funds transfer. Supported for card and bank account based cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf 
        /// </summary>
        /// <value>Use a 3-character alpha currency code for source currency of the funds transfer. Supported for card and bank account based cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf </value>
        [DataMember(Name="sourceCurrency", EmitDefaultValue=false)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// Use a 3-character alpha currency code for destination currency of the funds transfer. Supported for card and bank account based cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf 
        /// </summary>
        /// <value>Use a 3-character alpha currency code for destination currency of the funds transfer. Supported for card and bank account based cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf </value>
        [DataMember(Name="destinationCurrency", EmitDefaultValue=false)]
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Surcharge
        /// </summary>
        [DataMember(Name="surcharge", EmitDefaultValue=false)]
        public Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge Surcharge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferOrderInformationAmountDetails {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  DestinationCurrency: ").Append(DestinationCurrency).Append("\n");
            sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.SourceCurrency == other.SourceCurrency ||
                    this.SourceCurrency != null &&
                    this.SourceCurrency.Equals(other.SourceCurrency)
                ) && 
                (
                    this.DestinationCurrency == other.DestinationCurrency ||
                    this.DestinationCurrency != null &&
                    this.DestinationCurrency.Equals(other.DestinationCurrency)
                ) && 
                (
                    this.Surcharge == other.Surcharge ||
                    this.Surcharge != null &&
                    this.Surcharge.Equals(other.Surcharge)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.SourceCurrency != null)
                    hash = hash * 59 + this.SourceCurrency.GetHashCode();
                if (this.DestinationCurrency != null)
                    hash = hash * 59 + this.DestinationCurrency.GetHashCode();
                if (this.Surcharge != null)
                    hash = hash * 59 + this.Surcharge.GetHashCode();
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
