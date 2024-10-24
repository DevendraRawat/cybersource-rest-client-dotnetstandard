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
    /// Rbsv1subscriptionsProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Rbsv1subscriptionsProcessingInformation :  IEquatable<Rbsv1subscriptionsProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rbsv1subscriptionsProcessingInformation" /> class.
        /// </summary>
        /// <param name="CommerceIndicator">Commerce Indicator is a way to identify the type of transaction. Some payment card companies use this information when determining discount rates.  Valid values: - &#x60;MOTO&#x60; - &#x60;RECURRING&#x60;  Please add the ecommerce indicator based on the rules defined by your gateway/processor. Some gateways may not accept the Commerce Indicator &#x60;RECURRING&#x60; with a Zero Dollar Authorization, that is done for subscriptions starting at a future date. .</param>
        /// <param name="AuthorizationOptions">AuthorizationOptions.</param>
        public Rbsv1subscriptionsProcessingInformation(string CommerceIndicator = default(string), Rbsv1subscriptionsProcessingInformationAuthorizationOptions AuthorizationOptions = default(Rbsv1subscriptionsProcessingInformationAuthorizationOptions))
        {
            this.CommerceIndicator = CommerceIndicator;
            this.AuthorizationOptions = AuthorizationOptions;
        }
        
        /// <summary>
        /// Commerce Indicator is a way to identify the type of transaction. Some payment card companies use this information when determining discount rates.  Valid values: - &#x60;MOTO&#x60; - &#x60;RECURRING&#x60;  Please add the ecommerce indicator based on the rules defined by your gateway/processor. Some gateways may not accept the Commerce Indicator &#x60;RECURRING&#x60; with a Zero Dollar Authorization, that is done for subscriptions starting at a future date. 
        /// </summary>
        /// <value>Commerce Indicator is a way to identify the type of transaction. Some payment card companies use this information when determining discount rates.  Valid values: - &#x60;MOTO&#x60; - &#x60;RECURRING&#x60;  Please add the ecommerce indicator based on the rules defined by your gateway/processor. Some gateways may not accept the Commerce Indicator &#x60;RECURRING&#x60; with a Zero Dollar Authorization, that is done for subscriptions starting at a future date. </value>
        [DataMember(Name="commerceIndicator", EmitDefaultValue=false)]
        public string CommerceIndicator { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationOptions
        /// </summary>
        [DataMember(Name="authorizationOptions", EmitDefaultValue=false)]
        public Rbsv1subscriptionsProcessingInformationAuthorizationOptions AuthorizationOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rbsv1subscriptionsProcessingInformation {\n");
            sb.Append("  CommerceIndicator: ").Append(CommerceIndicator).Append("\n");
            sb.Append("  AuthorizationOptions: ").Append(AuthorizationOptions).Append("\n");
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
            return this.Equals(obj as Rbsv1subscriptionsProcessingInformation);
        }

        /// <summary>
        /// Returns true if Rbsv1subscriptionsProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Rbsv1subscriptionsProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rbsv1subscriptionsProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommerceIndicator == other.CommerceIndicator ||
                    this.CommerceIndicator != null &&
                    this.CommerceIndicator.Equals(other.CommerceIndicator)
                ) && 
                (
                    this.AuthorizationOptions == other.AuthorizationOptions ||
                    this.AuthorizationOptions != null &&
                    this.AuthorizationOptions.Equals(other.AuthorizationOptions)
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
                if (this.CommerceIndicator != null)
                    hash = hash * 59 + this.CommerceIndicator.GetHashCode();
                if (this.AuthorizationOptions != null)
                    hash = hash * 59 + this.AuthorizationOptions.GetHashCode();
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
