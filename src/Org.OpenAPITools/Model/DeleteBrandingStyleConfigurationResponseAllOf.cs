/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.14.0.20201015.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DeleteBrandingStyleConfigurationResponseAllOf
    /// </summary>
    [DataContract]
    public partial class DeleteBrandingStyleConfigurationResponseAllOf : IEquatable<DeleteBrandingStyleConfigurationResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBrandingStyleConfigurationResponseAllOf" /> class.
        /// </summary>
        /// <param name="storeId">Store ID number..</param>
        /// <param name="status">Status from delete branding style configuration process..</param>
        public DeleteBrandingStyleConfigurationResponseAllOf(string storeId = default(string), string status = default(string))
        {
            this.StoreId = storeId;
            this.Status = status;
        }

        /// <summary>
        /// Store ID number.
        /// </summary>
        /// <value>Store ID number.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Status from delete branding style configuration process.
        /// </summary>
        /// <value>Status from delete branding style configuration process.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBrandingStyleConfigurationResponseAllOf {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteBrandingStyleConfigurationResponseAllOf);
        }

        /// <summary>
        /// Returns true if DeleteBrandingStyleConfigurationResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteBrandingStyleConfigurationResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteBrandingStyleConfigurationResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
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
