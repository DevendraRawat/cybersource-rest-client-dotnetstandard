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
    /// Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact
    /// </summary>
    [DataContract]
    public partial class Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact :  IEquatable<Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact" /> class.
        /// </summary>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="PhoneNumber">PhoneNumber (required).</param>
        /// <param name="Email">Email (required).</param>
        public Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact(string FirstName = default(string), string MiddleName = default(string), string LastName = default(string), string PhoneNumber = default(string), string Email = default(string))
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.MiddleName = MiddleName;
        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact);
        }

        /// <summary>
        /// Returns true if Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact instances are equal
        /// </summary>
        /// <param name="other">Instance of Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boardingv1registrationsOrganizationInformationBusinessInformationBusinessContact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
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
            // FirstName (string) pattern
            Regex regexFirstName = new Regex(@"^[0-9a-zA-Z _\\-\\+\\.\\*\\\"\/'&\\,\\(\\)!$;:?@\\#¡-￿]+$", RegexOptions.CultureInvariant);
            if (false == regexFirstName.Match(this.FirstName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, must match a pattern of " + regexFirstName, new [] { "FirstName" });
            }

            // MiddleName (string) pattern
            Regex regexMiddleName = new Regex(@"^[0-9a-zA-Z _\\-\\+\\.\\*\\\"\/'&\\,\\(\\)!$;:?@\\#¡-￿]+$", RegexOptions.CultureInvariant);
            if (false == regexMiddleName.Match(this.MiddleName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleName, must match a pattern of " + regexMiddleName, new [] { "MiddleName" });
            }

            // LastName (string) pattern
            Regex regexLastName = new Regex(@"^[0-9a-zA-Z _\\-\\+\\.\\*\\\"\/'&\\,\\(\\)!$;:?@\\#¡-￿]+$", RegexOptions.CultureInvariant);
            if (false == regexLastName.Match(this.LastName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, must match a pattern of " + regexLastName, new [] { "LastName" });
            }

            // PhoneNumber (string) pattern
            Regex regexPhoneNumber = new Regex(@"^[0-9a-zA-Z\\\\+\\\\-]+$", RegexOptions.CultureInvariant);
            if (false == regexPhoneNumber.Match(this.PhoneNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, must match a pattern of " + regexPhoneNumber, new [] { "PhoneNumber" });
            }

            // Email (string) pattern
            Regex regexEmail = new Regex(@"^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,50}|[0-9]{1,3})(\\]?)$", RegexOptions.CultureInvariant);
            if (false == regexEmail.Match(this.Email).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, must match a pattern of " + regexEmail, new [] { "Email" });
            }

            yield break;
        }
    }

}
