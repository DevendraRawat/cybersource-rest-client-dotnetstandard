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
    /// Ptsv2paymentsProcessingInformationJapanPaymentOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsProcessingInformationJapanPaymentOptions :  IEquatable<Ptsv2paymentsProcessingInformationJapanPaymentOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsProcessingInformationJapanPaymentOptions" /> class.
        /// </summary>
        /// <param name="PaymentMethod">This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment) .</param>
        /// <param name="Bonuses">An array of objects, each of which contains a bonus month and bonus amount.  Length of bonuses array is equal to the number of bonuses.  Max length &#x3D; 6.  In case of bonus month and amount not specified, null objects to be returned in the array. Example: bonuses : [ {\&quot;month\&quot;: \&quot;1\&quot;,\&quot;amount\&quot;: \&quot;200\&quot;}, {\&quot;month\&quot;: \&quot;3\&quot;,\&quot;amount\&quot;: \&quot;2500\&quot;}, null] .</param>
        /// <param name="PreapprovalType">This will contain the details of the kind of transaction that has been processe. Used only for Japan. Possible Values: - 0 &#x3D; Normal (authorization with amount and clearing/settlement; data capture or paper draft) - 1 &#x3D; Negative card authorization (authorization-only with 0 or 1 amount) - 2 &#x3D; Reservation of authorization (authorization-only with amount) - 3 &#x3D; Cancel transaction - 4 &#x3D; Merchant-initiated reversal/refund transactions - 5 &#x3D; Cancel reservation of authorization - 6 &#x3D; Post authorization .</param>
        /// <param name="Installments">Number of Installments. .</param>
        /// <param name="TerminalId">Unique Japan Credit Card Association (JCCA) terminal identifier.  The difference between this field and the &#x60;pointOfSaleInformation.terminalID&#x60; field is that you can define &#x60;pointOfSaleInformation.terminalID&#x60;, but &#x60;processingInformation.japanPaymentOptions.terminalId&#x60; is defined by the JCCA and is used only in Japan.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. .</param>
        /// <param name="FirstBillingMonth">Billing month in MM format. .</param>
        /// <param name="BusinessName">Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. .</param>
        /// <param name="BusinessNameKatakana">Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. .</param>
        /// <param name="Jis2TrackData">Japanese Industrial Standard Type 2 (JIS2) track data from the front of the card.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. .</param>
        /// <param name="BusinessNameAlphaNumeric">Business name in alphanumeric characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. .</param>
        public Ptsv2paymentsProcessingInformationJapanPaymentOptions(string PaymentMethod = default(string), List<Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses> Bonuses = default(List<Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses>), string PreapprovalType = default(string), string Installments = default(string), string TerminalId = default(string), string FirstBillingMonth = default(string), string BusinessName = default(string), string BusinessNameKatakana = default(string), string Jis2TrackData = default(string), string BusinessNameAlphaNumeric = default(string))
        {
            this.PaymentMethod = PaymentMethod;
            this.Bonuses = Bonuses;
            this.PreapprovalType = PreapprovalType;
            this.Installments = Installments;
            this.TerminalId = TerminalId;
            this.FirstBillingMonth = FirstBillingMonth;
            this.BusinessName = BusinessName;
            this.BusinessNameKatakana = BusinessNameKatakana;
            this.Jis2TrackData = Jis2TrackData;
            this.BusinessNameAlphaNumeric = BusinessNameAlphaNumeric;
        }
        
        /// <summary>
        /// This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment) 
        /// </summary>
        /// <value>This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment) </value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// An array of objects, each of which contains a bonus month and bonus amount.  Length of bonuses array is equal to the number of bonuses.  Max length &#x3D; 6.  In case of bonus month and amount not specified, null objects to be returned in the array. Example: bonuses : [ {\&quot;month\&quot;: \&quot;1\&quot;,\&quot;amount\&quot;: \&quot;200\&quot;}, {\&quot;month\&quot;: \&quot;3\&quot;,\&quot;amount\&quot;: \&quot;2500\&quot;}, null] 
        /// </summary>
        /// <value>An array of objects, each of which contains a bonus month and bonus amount.  Length of bonuses array is equal to the number of bonuses.  Max length &#x3D; 6.  In case of bonus month and amount not specified, null objects to be returned in the array. Example: bonuses : [ {\&quot;month\&quot;: \&quot;1\&quot;,\&quot;amount\&quot;: \&quot;200\&quot;}, {\&quot;month\&quot;: \&quot;3\&quot;,\&quot;amount\&quot;: \&quot;2500\&quot;}, null] </value>
        [DataMember(Name="bonuses", EmitDefaultValue=false)]
        public List<Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses> Bonuses { get; set; }

        /// <summary>
        /// This will contain the details of the kind of transaction that has been processe. Used only for Japan. Possible Values: - 0 &#x3D; Normal (authorization with amount and clearing/settlement; data capture or paper draft) - 1 &#x3D; Negative card authorization (authorization-only with 0 or 1 amount) - 2 &#x3D; Reservation of authorization (authorization-only with amount) - 3 &#x3D; Cancel transaction - 4 &#x3D; Merchant-initiated reversal/refund transactions - 5 &#x3D; Cancel reservation of authorization - 6 &#x3D; Post authorization 
        /// </summary>
        /// <value>This will contain the details of the kind of transaction that has been processe. Used only for Japan. Possible Values: - 0 &#x3D; Normal (authorization with amount and clearing/settlement; data capture or paper draft) - 1 &#x3D; Negative card authorization (authorization-only with 0 or 1 amount) - 2 &#x3D; Reservation of authorization (authorization-only with amount) - 3 &#x3D; Cancel transaction - 4 &#x3D; Merchant-initiated reversal/refund transactions - 5 &#x3D; Cancel reservation of authorization - 6 &#x3D; Post authorization </value>
        [DataMember(Name="preapprovalType", EmitDefaultValue=false)]
        public string PreapprovalType { get; set; }

        /// <summary>
        /// Number of Installments. 
        /// </summary>
        /// <value>Number of Installments. </value>
        [DataMember(Name="installments", EmitDefaultValue=false)]
        public string Installments { get; set; }

        /// <summary>
        /// Unique Japan Credit Card Association (JCCA) terminal identifier.  The difference between this field and the &#x60;pointOfSaleInformation.terminalID&#x60; field is that you can define &#x60;pointOfSaleInformation.terminalID&#x60;, but &#x60;processingInformation.japanPaymentOptions.terminalId&#x60; is defined by the JCCA and is used only in Japan.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. 
        /// </summary>
        /// <value>Unique Japan Credit Card Association (JCCA) terminal identifier.  The difference between this field and the &#x60;pointOfSaleInformation.terminalID&#x60; field is that you can define &#x60;pointOfSaleInformation.terminalID&#x60;, but &#x60;processingInformation.japanPaymentOptions.terminalId&#x60; is defined by the JCCA and is used only in Japan.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. </value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Billing month in MM format. 
        /// </summary>
        /// <value>Billing month in MM format. </value>
        [DataMember(Name="firstBillingMonth", EmitDefaultValue=false)]
        public string FirstBillingMonth { get; set; }

        /// <summary>
        /// Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. </value>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. </value>
        [DataMember(Name="businessNameKatakana", EmitDefaultValue=false)]
        public string BusinessNameKatakana { get; set; }

        /// <summary>
        /// Japanese Industrial Standard Type 2 (JIS2) track data from the front of the card.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. 
        /// </summary>
        /// <value>Japanese Industrial Standard Type 2 (JIS2) track data from the front of the card.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. </value>
        [DataMember(Name="jis2TrackData", EmitDefaultValue=false)]
        public string Jis2TrackData { get; set; }

        /// <summary>
        /// Business name in alphanumeric characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Business name in alphanumeric characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. </value>
        [DataMember(Name="businessNameAlphaNumeric", EmitDefaultValue=false)]
        public string BusinessNameAlphaNumeric { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsProcessingInformationJapanPaymentOptions {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Bonuses: ").Append(Bonuses).Append("\n");
            sb.Append("  PreapprovalType: ").Append(PreapprovalType).Append("\n");
            sb.Append("  Installments: ").Append(Installments).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  FirstBillingMonth: ").Append(FirstBillingMonth).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessNameKatakana: ").Append(BusinessNameKatakana).Append("\n");
            sb.Append("  Jis2TrackData: ").Append(Jis2TrackData).Append("\n");
            sb.Append("  BusinessNameAlphaNumeric: ").Append(BusinessNameAlphaNumeric).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsProcessingInformationJapanPaymentOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsProcessingInformationJapanPaymentOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsProcessingInformationJapanPaymentOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsProcessingInformationJapanPaymentOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.Bonuses == other.Bonuses ||
                    this.Bonuses != null &&
                    this.Bonuses.SequenceEqual(other.Bonuses)
                ) && 
                (
                    this.PreapprovalType == other.PreapprovalType ||
                    this.PreapprovalType != null &&
                    this.PreapprovalType.Equals(other.PreapprovalType)
                ) && 
                (
                    this.Installments == other.Installments ||
                    this.Installments != null &&
                    this.Installments.Equals(other.Installments)
                ) && 
                (
                    this.TerminalId == other.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(other.TerminalId)
                ) && 
                (
                    this.FirstBillingMonth == other.FirstBillingMonth ||
                    this.FirstBillingMonth != null &&
                    this.FirstBillingMonth.Equals(other.FirstBillingMonth)
                ) && 
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) && 
                (
                    this.BusinessNameKatakana == other.BusinessNameKatakana ||
                    this.BusinessNameKatakana != null &&
                    this.BusinessNameKatakana.Equals(other.BusinessNameKatakana)
                ) && 
                (
                    this.Jis2TrackData == other.Jis2TrackData ||
                    this.Jis2TrackData != null &&
                    this.Jis2TrackData.Equals(other.Jis2TrackData)
                ) && 
                (
                    this.BusinessNameAlphaNumeric == other.BusinessNameAlphaNumeric ||
                    this.BusinessNameAlphaNumeric != null &&
                    this.BusinessNameAlphaNumeric.Equals(other.BusinessNameAlphaNumeric)
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
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.Bonuses != null)
                    hash = hash * 59 + this.Bonuses.GetHashCode();
                if (this.PreapprovalType != null)
                    hash = hash * 59 + this.PreapprovalType.GetHashCode();
                if (this.Installments != null)
                    hash = hash * 59 + this.Installments.GetHashCode();
                if (this.TerminalId != null)
                    hash = hash * 59 + this.TerminalId.GetHashCode();
                if (this.FirstBillingMonth != null)
                    hash = hash * 59 + this.FirstBillingMonth.GetHashCode();
                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();
                if (this.BusinessNameKatakana != null)
                    hash = hash * 59 + this.BusinessNameKatakana.GetHashCode();
                if (this.Jis2TrackData != null)
                    hash = hash * 59 + this.Jis2TrackData.GetHashCode();
                if (this.BusinessNameAlphaNumeric != null)
                    hash = hash * 59 + this.BusinessNameAlphaNumeric.GetHashCode();
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
