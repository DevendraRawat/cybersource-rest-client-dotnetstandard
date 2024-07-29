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
    /// InlineResponse2011IssuerInformation
    /// </summary>
    [DataContract]
    public partial class InlineResponse2011IssuerInformation :  IEquatable<InlineResponse2011IssuerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011IssuerInformation" /> class.
        /// </summary>
        /// <param name="Name">This field contains the issuer name. .</param>
        /// <param name="Country">This field contains [2-character ISO Country Codes](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) for the issuer. .</param>
        /// <param name="BinLength">This field contains the length of the BIN. .</param>
        /// <param name="AccountPrefix">This field contains the first 6 to 8 digits of a primary account number (PAN). The length of the field is determined by [PCI-DSS standards for truncation](https://pcissc.secure.force.com/faq/articles/Frequently_Asked_Question/What-are-acceptable-formats-for-truncation-of-primary-account-numbers). .</param>
        /// <param name="PhoneNumber">This field contains the customer service phone number for the issuer. .</param>
        public InlineResponse2011IssuerInformation(string Name = default(string), string Country = default(string), string BinLength = default(string), string AccountPrefix = default(string), string PhoneNumber = default(string))
        {
            this.Name = Name;
            this.Country = Country;
            this.BinLength = BinLength;
            this.AccountPrefix = AccountPrefix;
            this.PhoneNumber = PhoneNumber;
        }
        
        /// <summary>
        /// This field contains the issuer name. 
        /// </summary>
        /// <value>This field contains the issuer name. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// This field contains [2-character ISO Country Codes](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) for the issuer. 
        /// </summary>
        /// <value>This field contains [2-character ISO Country Codes](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) for the issuer. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// This field contains the length of the BIN. 
        /// </summary>
        /// <value>This field contains the length of the BIN. </value>
        [DataMember(Name="binLength", EmitDefaultValue=false)]
        public string BinLength { get; set; }

        /// <summary>
        /// This field contains the first 6 to 8 digits of a primary account number (PAN). The length of the field is determined by [PCI-DSS standards for truncation](https://pcissc.secure.force.com/faq/articles/Frequently_Asked_Question/What-are-acceptable-formats-for-truncation-of-primary-account-numbers). 
        /// </summary>
        /// <value>This field contains the first 6 to 8 digits of a primary account number (PAN). The length of the field is determined by [PCI-DSS standards for truncation](https://pcissc.secure.force.com/faq/articles/Frequently_Asked_Question/What-are-acceptable-formats-for-truncation-of-primary-account-numbers). </value>
        [DataMember(Name="accountPrefix", EmitDefaultValue=false)]
        public string AccountPrefix { get; set; }

        /// <summary>
        /// This field contains the customer service phone number for the issuer. 
        /// </summary>
        /// <value>This field contains the customer service phone number for the issuer. </value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011IssuerInformation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  BinLength: ").Append(BinLength).Append("\n");
            sb.Append("  AccountPrefix: ").Append(AccountPrefix).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(obj as InlineResponse2011IssuerInformation);
        }

        /// <summary>
        /// Returns true if InlineResponse2011IssuerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2011IssuerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2011IssuerInformation other)
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
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.BinLength == other.BinLength ||
                    this.BinLength != null &&
                    this.BinLength.Equals(other.BinLength)
                ) && 
                (
                    this.AccountPrefix == other.AccountPrefix ||
                    this.AccountPrefix != null &&
                    this.AccountPrefix.Equals(other.AccountPrefix)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.BinLength != null)
                    hash = hash * 59 + this.BinLength.GetHashCode();
                if (this.AccountPrefix != null)
                    hash = hash * 59 + this.AccountPrefix.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
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
