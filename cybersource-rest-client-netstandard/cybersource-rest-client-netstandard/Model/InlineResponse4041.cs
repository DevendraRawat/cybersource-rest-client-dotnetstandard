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
    /// InlineResponse4041
    /// </summary>
    [DataContract]
    public partial class InlineResponse4041 :  IEquatable<InlineResponse4041>, IValidatableObject
    {
        /// <summary>
        /// Documented reason codes. Client should be able to use the key for generating their own error message Possible Values:   - &#39;RESOURCE_NOT_FOUND&#39; 
        /// </summary>
        /// <value>Documented reason codes. Client should be able to use the key for generating their own error message Possible Values:   - &#39;RESOURCE_NOT_FOUND&#39; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum RESOURCENOTFOUND for "RESOURCE_NOT_FOUND"
            /// </summary>
            [EnumMember(Value = "RESOURCE_NOT_FOUND")]
            RESOURCENOTFOUND
        }
        /// <summary>
        /// Documented reason codes. Client should be able to use the key for generating their own error message Possible Values:   - &#39;RESOURCE_NOT_FOUND&#39; 
        /// </summary>
        /// <value>Documented reason codes. Client should be able to use the key for generating their own error message Possible Values:   - &#39;RESOURCE_NOT_FOUND&#39; </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4041" /> class.
        /// </summary>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="Status">The http status description of the submitted request..</param>
        /// <param name="Reason">Documented reason codes. Client should be able to use the key for generating their own error message Possible Values:   - &#39;RESOURCE_NOT_FOUND&#39; .</param>
        /// <param name="Message">Descriptive message for the error..</param>
        /// <param name="Details">Details.</param>
        public InlineResponse4041(DateTime? SubmitTimeUtc = default(DateTime?), string Status = default(string), ReasonEnum? Reason = default(ReasonEnum?), string Message = default(string), List<InlineResponse4006Details> Details = default(List<InlineResponse4006Details>))
        {
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.Reason = Reason;
            this.Message = Message;
            this.Details = Details;
        }
        
        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? SubmitTimeUtc { get; set; }

        /// <summary>
        /// The http status description of the submitted request.
        /// </summary>
        /// <value>The http status description of the submitted request.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }


        /// <summary>
        /// Descriptive message for the error.
        /// </summary>
        /// <value>Descriptive message for the error.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<InlineResponse4006Details> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse4041 {\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as InlineResponse4041);
        }

        /// <summary>
        /// Returns true if InlineResponse4041 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse4041 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse4041 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
