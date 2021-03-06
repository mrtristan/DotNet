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
    /// Request authentication of the payment card using the 3DS 1.0 URL redirect scheme.
    /// </summary>
    [DataContract]
    public partial class Secure3D10AuthenticationRequest : AuthenticationRequest, IEquatable<Secure3D10AuthenticationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Secure3D10AuthenticationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D10AuthenticationRequest" /> class.
        /// </summary>
        /// <param name="authenticationType">Indicates what kind of authentication scheme the merchant wants to use on the card..</param>
        public Secure3D10AuthenticationRequest(string authenticationType = default(string)) : base()
        {
            this.AuthenticationType = authenticationType;
        }

        /// <summary>
        /// Indicates what kind of authentication scheme the merchant wants to use on the card.
        /// </summary>
        /// <value>Indicates what kind of authentication scheme the merchant wants to use on the card.</value>
        [DataMember(Name = "authenticationType", EmitDefaultValue = false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D10AuthenticationRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Secure3D10AuthenticationRequest);
        }

        /// <summary>
        /// Returns true if Secure3D10AuthenticationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D10AuthenticationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D10AuthenticationRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
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
                int hashCode = base.GetHashCode();
                if (this.AuthenticationType != null)
                    hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
