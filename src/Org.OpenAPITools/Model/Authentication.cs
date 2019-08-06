/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.6.0.20190507.002
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request authentication of the payment card to verify the cardholder and be eligible for liability shift. Provides shared fields for all Authentication request types. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    [JsonSubtypes.KnownSubType(typeof(Secure3dAuthenticationRequest), "Secure3dAuthenticationRequest")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D10AuthenticationResult), "Secure3D10AuthenticationResult")]
    [JsonSubtypes.KnownSubType(typeof(UnionPayAuthenticationRequest), "UnionPayAuthenticationRequest")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D21AuthenticationResult), "Secure3D21AuthenticationResult")]
    public partial class Authentication :  IEquatable<Authentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Authentication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication" /> class.
        /// </summary>
        /// <param name="requestType">Indicates what kind of authentication scheme the merchant wants to use on the card. (required).</param>
        public Authentication(string requestType = default(string))
        {
            // to ensure "requestType" is required (not null)
            if (requestType == null)
            {
                throw new InvalidDataException("requestType is a required property for Authentication and cannot be null");
            }
            else
            {
                this.RequestType = requestType;
            }

        }
        
        /// <summary>
        /// Indicates what kind of authentication scheme the merchant wants to use on the card.
        /// </summary>
        /// <value>Indicates what kind of authentication scheme the merchant wants to use on the card.</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authentication {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
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
            return this.Equals(input as Authentication);
        }

        /// <summary>
        /// Returns true if Authentication instances are equal
        /// </summary>
        /// <param name="input">Instance of Authentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Authentication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
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
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}