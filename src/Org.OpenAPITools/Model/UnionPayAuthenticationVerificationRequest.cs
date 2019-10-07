/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.8.0.20190731.002
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
    /// Authentication verification request specific to UnionPay transactions.
    /// </summary>
    [DataContract]
    public partial class UnionPayAuthenticationVerificationRequest : AuthenticationVerificationRequest,  IEquatable<UnionPayAuthenticationVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnionPayAuthenticationVerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnionPayAuthenticationVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnionPayAuthenticationVerificationRequest" /> class.
        /// </summary>
        /// <param name="smsVerificationCode">Customer mobile number for SMS verification. (required).</param>
        /// <param name="storeId">An optional Outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="requestType">Object name of the authentication verification request. (required).</param>
        /// <param name="securityCode">Card security code if required by merchant..</param>
        /// <param name="billingAddress">billingAddress.</param>
        public UnionPayAuthenticationVerificationRequest(string smsVerificationCode = default(string), string storeId = default(string), string requestType = default(string), string securityCode = default(string), Address billingAddress = default(Address)) : base(storeId, requestType, securityCode, billingAddress)
        {
            // to ensure "smsVerificationCode" is required (not null)
            if (smsVerificationCode == null)
            {
                throw new InvalidDataException("smsVerificationCode is a required property for UnionPayAuthenticationVerificationRequest and cannot be null");
            }
            else
            {
                this.SmsVerificationCode = smsVerificationCode;
            }

        }
        
        /// <summary>
        /// Customer mobile number for SMS verification.
        /// </summary>
        /// <value>Customer mobile number for SMS verification.</value>
        [DataMember(Name="smsVerificationCode", EmitDefaultValue=false)]
        public string SmsVerificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnionPayAuthenticationVerificationRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SmsVerificationCode: ").Append(SmsVerificationCode).Append("\n");
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
            return this.Equals(input as UnionPayAuthenticationVerificationRequest);
        }

        /// <summary>
        /// Returns true if UnionPayAuthenticationVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnionPayAuthenticationVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnionPayAuthenticationVerificationRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.SmsVerificationCode == input.SmsVerificationCode ||
                    (this.SmsVerificationCode != null &&
                    this.SmsVerificationCode.Equals(input.SmsVerificationCode))
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
                if (this.SmsVerificationCode != null)
                    hashCode = hashCode * 59 + this.SmsVerificationCode.GetHashCode();
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
            // SmsVerificationCode (string) pattern
            Regex regexSmsVerificationCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexSmsVerificationCode.Match(this.SmsVerificationCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SmsVerificationCode, must match a pattern of " + regexSmsVerificationCode, new [] { "SmsVerificationCode" });
            }

            yield break;
        }
    }

}
