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
    /// PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation :  IEquatable<PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation" /> class.
        /// </summary>
        /// <param name="Name">Name of the merchant account..</param>
        /// <param name="Contact">Phone number of the primary contact for the merchant account..</param>
        /// <param name="State">2-character ISO code for the U.S. state in which the merchant is registered.</param>
        public PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation(string Name = default(string), string Contact = default(string), string State = default(string))
        {
            this.Name = Name;
            this.Contact = Contact;
            this.State = State;
        }
        
        /// <summary>
        /// Name of the merchant account.
        /// </summary>
        /// <value>Name of the merchant account.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of the primary contact for the merchant account.
        /// </summary>
        /// <value>Phone number of the primary contact for the merchant account.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// 2-character ISO code for the U.S. state in which the merchant is registered
        /// </summary>
        /// <value>2-character ISO code for the U.S. state in which the merchant is registered</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation);
        }

        /// <summary>
        /// Returns true if PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation other)
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
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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