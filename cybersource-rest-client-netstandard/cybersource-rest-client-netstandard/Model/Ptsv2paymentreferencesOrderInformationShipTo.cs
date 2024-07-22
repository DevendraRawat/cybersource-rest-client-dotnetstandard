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
    /// Ptsv2paymentreferencesOrderInformationShipTo
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentreferencesOrderInformationShipTo :  IEquatable<Ptsv2paymentreferencesOrderInformationShipTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentreferencesOrderInformationShipTo" /> class.
        /// </summary>
        /// <param name="Email">Customer&#39;s primary email address, including the full domain name. .</param>
        /// <param name="Title">The title of the person receiving the product..</param>
        /// <param name="FirstName">First name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. .</param>
        /// <param name="MiddleName">Middle name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. .</param>
        /// <param name="LastName">Last name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. .</param>
        /// <param name="Company">Name of the customer&#39;s company. .</param>
        /// <param name="Address1">First line of the shipping address.  Required field for authorization if any shipping address information is included in the request; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. .</param>
        /// <param name="Address2">Second line of the shipping address.  Optional field.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. .</param>
        /// <param name="District">Neighborhood, community, or region within a city or municipality..</param>
        /// <param name="Locality">City of the shipping address.  Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. .</param>
        /// <param name="AdministrativeArea">State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2)   Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. .</param>
        /// <param name="PostalCode">Postal code for the shipping address. The postal code must consist of 5 to 9 digits.  Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  Example A1B 2C3  #### American Express Direct Before sending the postal code to the processor, all nonalphanumeric characters are removed and, if the remaining value is longer than nine characters, the value is truncated starting from the right side. #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. .</param>
        /// <param name="Country">Country of the shipping address. Use the two-character [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf)  Required field for authorization if any shipping address information is included in the request; otherwise, optional.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. .</param>
        /// <param name="BuildingNumber">Building number in the street address. For example, the building number is 187 in the following address:  Rua da Quitanda 187 .</param>
        /// <param name="PhoneNumber">Phone number associated with the shipping address..</param>
        /// <param name="Immutable">Indicates whether customers are permitted to edit the shipping address in their PayPal account. Possible values: - true: Customer cannot edit the shipping address. - false (default): Customer can edit the shipping address. .</param>
        /// <param name="NotApplicable">Indicates whether the shipping address is displayed to the customer in their PayPal account. Possible values: - true: Shipping address is not displayed. - false (default): Shipping address is displayed. For example, for digital downloads and services in which a shipping address is not required, set the value to true. .</param>
        /// <param name="County">U.S. county if available..</param>
        public Ptsv2paymentreferencesOrderInformationShipTo(string Email = default(string), string Title = default(string), string FirstName = default(string), string MiddleName = default(string), string LastName = default(string), string Company = default(string), string Address1 = default(string), string Address2 = default(string), string District = default(string), string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string), string Country = default(string), string BuildingNumber = default(string), string PhoneNumber = default(string), string Immutable = default(string), string NotApplicable = default(string), string County = default(string))
        {
            this.Email = Email;
            this.Title = Title;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Company = Company;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.District = District;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.BuildingNumber = BuildingNumber;
            this.PhoneNumber = PhoneNumber;
            this.Immutable = Immutable;
            this.NotApplicable = NotApplicable;
            this.County = County;
        }
        
        /// <summary>
        /// Customer&#39;s primary email address, including the full domain name. 
        /// </summary>
        /// <value>Customer&#39;s primary email address, including the full domain name. </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The title of the person receiving the product.
        /// </summary>
        /// <value>The title of the person receiving the product.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// First name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. 
        /// </summary>
        /// <value>First name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. 
        /// </summary>
        /// <value>Middle name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. </value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Last name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. 
        /// </summary>
        /// <value>Last name of the recipient.  #### Litle Maximum length: 25  #### All other processors Maximum length: 60  Optional field. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Name of the customer&#39;s company. 
        /// </summary>
        /// <value>Name of the customer&#39;s company. </value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// First line of the shipping address.  Required field for authorization if any shipping address information is included in the request; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. 
        /// </summary>
        /// <value>First line of the shipping address.  Required field for authorization if any shipping address information is included in the request; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of the shipping address.  Optional field.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. 
        /// </summary>
        /// <value>Second line of the shipping address.  Optional field.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. </value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Neighborhood, community, or region within a city or municipality.
        /// </summary>
        /// <value>Neighborhood, community, or region within a city or municipality.</value>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }

        /// <summary>
        /// City of the shipping address.  Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. 
        /// </summary>
        /// <value>City of the shipping address.  Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2)   Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. 
        /// </summary>
        /// <value>State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2)   Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Postal code for the shipping address. The postal code must consist of 5 to 9 digits.  Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  Example A1B 2C3  #### American Express Direct Before sending the postal code to the processor, all nonalphanumeric characters are removed and, if the remaining value is longer than nine characters, the value is truncated starting from the right side. #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. 
        /// </summary>
        /// <value>Postal code for the shipping address. The postal code must consist of 5 to 9 digits.  Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  Example A1B 2C3  #### American Express Direct Before sending the postal code to the processor, all nonalphanumeric characters are removed and, if the remaining value is longer than nine characters, the value is truncated starting from the right side. #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of the shipping address. Use the two-character [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf)  Required field for authorization if any shipping address information is included in the request; otherwise, optional.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. 
        /// </summary>
        /// <value>Country of the shipping address. Use the two-character [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf)  Required field for authorization if any shipping address information is included in the request; otherwise, optional.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Building number in the street address. For example, the building number is 187 in the following address:  Rua da Quitanda 187 
        /// </summary>
        /// <value>Building number in the street address. For example, the building number is 187 in the following address:  Rua da Quitanda 187 </value>
        [DataMember(Name="buildingNumber", EmitDefaultValue=false)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Phone number associated with the shipping address.
        /// </summary>
        /// <value>Phone number associated with the shipping address.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Indicates whether customers are permitted to edit the shipping address in their PayPal account. Possible values: - true: Customer cannot edit the shipping address. - false (default): Customer can edit the shipping address. 
        /// </summary>
        /// <value>Indicates whether customers are permitted to edit the shipping address in their PayPal account. Possible values: - true: Customer cannot edit the shipping address. - false (default): Customer can edit the shipping address. </value>
        [DataMember(Name="immutable", EmitDefaultValue=false)]
        public string Immutable { get; set; }

        /// <summary>
        /// Indicates whether the shipping address is displayed to the customer in their PayPal account. Possible values: - true: Shipping address is not displayed. - false (default): Shipping address is displayed. For example, for digital downloads and services in which a shipping address is not required, set the value to true. 
        /// </summary>
        /// <value>Indicates whether the shipping address is displayed to the customer in their PayPal account. Possible values: - true: Shipping address is not displayed. - false (default): Shipping address is displayed. For example, for digital downloads and services in which a shipping address is not required, set the value to true. </value>
        [DataMember(Name="notApplicable", EmitDefaultValue=false)]
        public string NotApplicable { get; set; }

        /// <summary>
        /// U.S. county if available.
        /// </summary>
        /// <value>U.S. county if available.</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentreferencesOrderInformationShipTo {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Immutable: ").Append(Immutable).Append("\n");
            sb.Append("  NotApplicable: ").Append(NotApplicable).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentreferencesOrderInformationShipTo);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentreferencesOrderInformationShipTo instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentreferencesOrderInformationShipTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentreferencesOrderInformationShipTo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
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
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.District == other.District ||
                    this.District != null &&
                    this.District.Equals(other.District)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.BuildingNumber == other.BuildingNumber ||
                    this.BuildingNumber != null &&
                    this.BuildingNumber.Equals(other.BuildingNumber)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Immutable == other.Immutable ||
                    this.Immutable != null &&
                    this.Immutable.Equals(other.Immutable)
                ) && 
                (
                    this.NotApplicable == other.NotApplicable ||
                    this.NotApplicable != null &&
                    this.NotApplicable.Equals(other.NotApplicable)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.District != null)
                    hash = hash * 59 + this.District.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.BuildingNumber != null)
                    hash = hash * 59 + this.BuildingNumber.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Immutable != null)
                    hash = hash * 59 + this.Immutable.GetHashCode();
                if (this.NotApplicable != null)
                    hash = hash * 59 + this.NotApplicable.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
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
