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
    /// Ptsv1pushfundstransferMerchantInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferMerchantInformation :  IEquatable<Ptsv1pushfundstransferMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferMerchantInformation" /> class.
        /// </summary>
        /// <param name="CategoryCode">The value for this field is a four-digit number that the payment card industry uses to  classify merchants into market segments. A payment card company assigned one or more of  these values to your business when you started accepting the payment card company&#39;s cards.  When you do not include this field in your request, CyberSource uses the value in your CyberSource account. .</param>
        public Ptsv1pushfundstransferMerchantInformation(string CategoryCode = default(string))
        {
            this.CategoryCode = CategoryCode;
        }
        
        /// <summary>
        /// The value for this field is a four-digit number that the payment card industry uses to  classify merchants into market segments. A payment card company assigned one or more of  these values to your business when you started accepting the payment card company&#39;s cards.  When you do not include this field in your request, CyberSource uses the value in your CyberSource account. 
        /// </summary>
        /// <value>The value for this field is a four-digit number that the payment card industry uses to  classify merchants into market segments. A payment card company assigned one or more of  these values to your business when you started accepting the payment card company&#39;s cards.  When you do not include this field in your request, CyberSource uses the value in your CyberSource account. </value>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferMerchantInformation {\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferMerchantInformation);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
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
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
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
