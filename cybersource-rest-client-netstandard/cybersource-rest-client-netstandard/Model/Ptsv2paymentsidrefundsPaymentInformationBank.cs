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
    /// Ptsv2paymentsidrefundsPaymentInformationBank
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidrefundsPaymentInformationBank :  IEquatable<Ptsv2paymentsidrefundsPaymentInformationBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidrefundsPaymentInformationBank" /> class.
        /// </summary>
        /// <param name="Account">Account.</param>
        /// <param name="RoutingNumber">Bank routing number. This is also called the _transit number_.  For details, see &#x60;ecp_rdfi&#x60; request field description in the [Electronic Check Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/) .</param>
        /// <param name="Iban">International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.  For all possible values, see the &#x60;bank_iban&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="SwiftCode">Bank&#39;s SWIFT code. You can use this field only when scoring a direct debit transaction. Required only for crossborder transactions.  For all possible values, see the &#x60;bank_swiftcode&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        public Ptsv2paymentsidrefundsPaymentInformationBank(Ptsv2paymentsidrefundsPaymentInformationBankAccount Account = default(Ptsv2paymentsidrefundsPaymentInformationBankAccount), string RoutingNumber = default(string), string Iban = default(string), string SwiftCode = default(string))
        {
            this.Account = Account;
            this.RoutingNumber = RoutingNumber;
            this.Iban = Iban;
            this.SwiftCode = SwiftCode;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsPaymentInformationBankAccount Account { get; set; }

        /// <summary>
        /// Bank routing number. This is also called the _transit number_.  For details, see &#x60;ecp_rdfi&#x60; request field description in the [Electronic Check Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/) 
        /// </summary>
        /// <value>Bank routing number. This is also called the _transit number_.  For details, see &#x60;ecp_rdfi&#x60; request field description in the [Electronic Check Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/) </value>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.  For all possible values, see the &#x60;bank_iban&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.  For all possible values, see the &#x60;bank_iban&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Bank&#39;s SWIFT code. You can use this field only when scoring a direct debit transaction. Required only for crossborder transactions.  For all possible values, see the &#x60;bank_swiftcode&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Bank&#39;s SWIFT code. You can use this field only when scoring a direct debit transaction. Required only for crossborder transactions.  For all possible values, see the &#x60;bank_swiftcode&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="swiftCode", EmitDefaultValue=false)]
        public string SwiftCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidrefundsPaymentInformationBank {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  SwiftCode: ").Append(SwiftCode).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidrefundsPaymentInformationBank);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidrefundsPaymentInformationBank instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidrefundsPaymentInformationBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidrefundsPaymentInformationBank other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                ) && 
                (
                    this.Iban == other.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(other.Iban)
                ) && 
                (
                    this.SwiftCode == other.SwiftCode ||
                    this.SwiftCode != null &&
                    this.SwiftCode.Equals(other.SwiftCode)
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
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
                if (this.SwiftCode != null)
                    hash = hash * 59 + this.SwiftCode.GetHashCode();
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
