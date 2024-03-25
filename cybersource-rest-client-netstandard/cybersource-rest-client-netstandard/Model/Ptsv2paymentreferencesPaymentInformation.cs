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
    /// Ptsv2paymentreferencesPaymentInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentreferencesPaymentInformation :  IEquatable<Ptsv2paymentreferencesPaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentreferencesPaymentInformation" /> class.
        /// </summary>
        /// <param name="Card">Card.</param>
        /// <param name="Bank">Bank.</param>
        /// <param name="EWallet">EWallet.</param>
        /// <param name="Options">Options.</param>
        /// <param name="PaymentType">PaymentType.</param>
        public Ptsv2paymentreferencesPaymentInformation(Ptsv2paymentreferencesPaymentInformationCard Card = default(Ptsv2paymentreferencesPaymentInformationCard), Ptsv2paymentreferencesPaymentInformationBank Bank = default(Ptsv2paymentreferencesPaymentInformationBank), Ptsv2paymentreferencesPaymentInformationEWallet EWallet = default(Ptsv2paymentreferencesPaymentInformationEWallet), Ptsv2paymentreferencesPaymentInformationOptions Options = default(Ptsv2paymentreferencesPaymentInformationOptions), Ptsv2paymentsPaymentInformationPaymentType PaymentType = default(Ptsv2paymentsPaymentInformationPaymentType))
        {
            this.Card = Card;
            this.Bank = Bank;
            this.EWallet = EWallet;
            this.Options = Options;
            this.PaymentType = PaymentType;
        }
        
        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Ptsv2paymentreferencesPaymentInformationCard Card { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public Ptsv2paymentreferencesPaymentInformationBank Bank { get; set; }

        /// <summary>
        /// Gets or Sets EWallet
        /// </summary>
        [DataMember(Name="eWallet", EmitDefaultValue=false)]
        public Ptsv2paymentreferencesPaymentInformationEWallet EWallet { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Ptsv2paymentreferencesPaymentInformationOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationPaymentType PaymentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentreferencesPaymentInformation {\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  EWallet: ").Append(EWallet).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentreferencesPaymentInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentreferencesPaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentreferencesPaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentreferencesPaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
                ) && 
                (
                    this.EWallet == other.EWallet ||
                    this.EWallet != null &&
                    this.EWallet.Equals(other.EWallet)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
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
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();
                if (this.EWallet != null)
                    hash = hash * 59 + this.EWallet.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
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
