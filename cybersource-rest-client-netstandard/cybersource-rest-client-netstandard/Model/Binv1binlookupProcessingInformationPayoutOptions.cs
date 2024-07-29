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
    /// Payout fields request parameters 
    /// </summary>
    [DataContract]
    public partial class Binv1binlookupProcessingInformationPayoutOptions :  IEquatable<Binv1binlookupProcessingInformationPayoutOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Binv1binlookupProcessingInformationPayoutOptions" /> class.
        /// </summary>
        /// <param name="PayoutInquiry">If &#x60;true&#x60; then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup.  Possible values: - true - false .</param>
        /// <param name="NetworkId">The networks specified in this field must be a subset of the information provided during program enrollment    Possible values: - 0020 : Accel/Exchange - 0024 : CU24 - 0003 : Interlink - 0016 : Maestro - 0018 : NYCE - 0027 : NYCE - 0009 : Pulse - 0017 : Pulse - 0019 : Pulse - 0008 : Star - 0010 : Star - 0011 : Star - 0012 : Star - 0015 : Star - 0002 : Visa/PLUS .</param>
        /// <param name="AcquirerBin">BIN under which the Funds Transfer application is registered. This must match the information provided during enrollment. .</param>
        public Binv1binlookupProcessingInformationPayoutOptions(bool? PayoutInquiry = default(bool?), string NetworkId = default(string), string AcquirerBin = default(string))
        {
            this.PayoutInquiry = PayoutInquiry;
            this.NetworkId = NetworkId;
            this.AcquirerBin = AcquirerBin;
        }
        
        /// <summary>
        /// If &#x60;true&#x60; then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup.  Possible values: - true - false 
        /// </summary>
        /// <value>If &#x60;true&#x60; then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup.  Possible values: - true - false </value>
        [DataMember(Name="payoutInquiry", EmitDefaultValue=false)]
        public bool? PayoutInquiry { get; set; }

        /// <summary>
        /// The networks specified in this field must be a subset of the information provided during program enrollment    Possible values: - 0020 : Accel/Exchange - 0024 : CU24 - 0003 : Interlink - 0016 : Maestro - 0018 : NYCE - 0027 : NYCE - 0009 : Pulse - 0017 : Pulse - 0019 : Pulse - 0008 : Star - 0010 : Star - 0011 : Star - 0012 : Star - 0015 : Star - 0002 : Visa/PLUS 
        /// </summary>
        /// <value>The networks specified in this field must be a subset of the information provided during program enrollment    Possible values: - 0020 : Accel/Exchange - 0024 : CU24 - 0003 : Interlink - 0016 : Maestro - 0018 : NYCE - 0027 : NYCE - 0009 : Pulse - 0017 : Pulse - 0019 : Pulse - 0008 : Star - 0010 : Star - 0011 : Star - 0012 : Star - 0015 : Star - 0002 : Visa/PLUS </value>
        [DataMember(Name="networkId", EmitDefaultValue=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// BIN under which the Funds Transfer application is registered. This must match the information provided during enrollment. 
        /// </summary>
        /// <value>BIN under which the Funds Transfer application is registered. This must match the information provided during enrollment. </value>
        [DataMember(Name="acquirerBin", EmitDefaultValue=false)]
        public string AcquirerBin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Binv1binlookupProcessingInformationPayoutOptions {\n");
            sb.Append("  PayoutInquiry: ").Append(PayoutInquiry).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  AcquirerBin: ").Append(AcquirerBin).Append("\n");
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
            return this.Equals(obj as Binv1binlookupProcessingInformationPayoutOptions);
        }

        /// <summary>
        /// Returns true if Binv1binlookupProcessingInformationPayoutOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Binv1binlookupProcessingInformationPayoutOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Binv1binlookupProcessingInformationPayoutOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PayoutInquiry == other.PayoutInquiry ||
                    this.PayoutInquiry != null &&
                    this.PayoutInquiry.Equals(other.PayoutInquiry)
                ) && 
                (
                    this.NetworkId == other.NetworkId ||
                    this.NetworkId != null &&
                    this.NetworkId.Equals(other.NetworkId)
                ) && 
                (
                    this.AcquirerBin == other.AcquirerBin ||
                    this.AcquirerBin != null &&
                    this.AcquirerBin.Equals(other.AcquirerBin)
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
                if (this.PayoutInquiry != null)
                    hash = hash * 59 + this.PayoutInquiry.GetHashCode();
                if (this.NetworkId != null)
                    hash = hash * 59 + this.NetworkId.GetHashCode();
                if (this.AcquirerBin != null)
                    hash = hash * 59 + this.AcquirerBin.GetHashCode();
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
