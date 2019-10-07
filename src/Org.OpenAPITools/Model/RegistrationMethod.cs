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
    /// A JSON object that holds info about the payment registration method.
    /// </summary>
    [DataContract]
    public partial class RegistrationMethod :  IEquatable<RegistrationMethod>, IValidatableObject
    {
        /// <summary>
        /// Unique ID for the payment method type.
        /// </summary>
        /// <value>Unique ID for the payment method type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodTypeEnum
        {
            /// <summary>
            /// Enum Card for value: method/card
            /// </summary>
            [EnumMember(Value = "method/card")]
            Card = 1,

            /// <summary>
            /// Enum Wallet for value: method/wallet
            /// </summary>
            [EnumMember(Value = "method/wallet")]
            Wallet = 2

        }

        /// <summary>
        /// Unique ID for the payment method type.
        /// </summary>
        /// <value>Unique ID for the payment method type.</value>
        [DataMember(Name="methodType", EmitDefaultValue=false)]
        public MethodTypeEnum MethodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegistrationMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationMethod" /> class.
        /// </summary>
        /// <param name="methodType">Unique ID for the payment method type. (required).</param>
        /// <param name="methodId">The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method..</param>
        /// <param name="userDefined">A JSON object that carries any additional information that might be helpful for fraud detection..</param>
        /// <param name="billingPhoneNumber">The address that should be used to send billing information for this payment method..</param>
        /// <param name="methodAlias">The address that should be used to send billing information for this payment method..</param>
        /// <param name="card">card (required).</param>
        /// <param name="methodAddress">methodAddress.</param>
        public RegistrationMethod(MethodTypeEnum methodType = default(MethodTypeEnum), string methodId = default(string), Object userDefined = default(Object), string billingPhoneNumber = default(string), string methodAlias = default(string), FraudRegistrationCard card = default(FraudRegistrationCard), FraudAddress methodAddress = default(FraudAddress))
        {
            this.MethodType = methodType;
            // to ensure "card" is required (not null)
            if (card == null)
            {
                throw new InvalidDataException("card is a required property for RegistrationMethod and cannot be null");
            }
            else
            {
                this.Card = card;
            }

            this.MethodId = methodId;
            this.UserDefined = userDefined;
            this.BillingPhoneNumber = billingPhoneNumber;
            this.MethodAlias = methodAlias;
            this.MethodAddress = methodAddress;
        }
        
        /// <summary>
        /// The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method.
        /// </summary>
        /// <value>The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method.</value>
        [DataMember(Name="methodId", EmitDefaultValue=false)]
        public string MethodId { get; set; }

        /// <summary>
        /// A JSON object that carries any additional information that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that carries any additional information that might be helpful for fraud detection.</value>
        [DataMember(Name="userDefined", EmitDefaultValue=false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// The address that should be used to send billing information for this payment method.
        /// </summary>
        /// <value>The address that should be used to send billing information for this payment method.</value>
        [DataMember(Name="billingPhoneNumber", EmitDefaultValue=false)]
        public string BillingPhoneNumber { get; set; }

        /// <summary>
        /// The address that should be used to send billing information for this payment method.
        /// </summary>
        /// <value>The address that should be used to send billing information for this payment method.</value>
        [DataMember(Name="methodAlias", EmitDefaultValue=false)]
        public string MethodAlias { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public FraudRegistrationCard Card { get; set; }

        /// <summary>
        /// Gets or Sets MethodAddress
        /// </summary>
        [DataMember(Name="methodAddress", EmitDefaultValue=false)]
        public FraudAddress MethodAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegistrationMethod {\n");
            sb.Append("  MethodType: ").Append(MethodType).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
            sb.Append("  BillingPhoneNumber: ").Append(BillingPhoneNumber).Append("\n");
            sb.Append("  MethodAlias: ").Append(MethodAlias).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  MethodAddress: ").Append(MethodAddress).Append("\n");
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
            return this.Equals(input as RegistrationMethod);
        }

        /// <summary>
        /// Returns true if RegistrationMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MethodType == input.MethodType ||
                    this.MethodType.Equals(input.MethodType)
                ) && 
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
                ) && 
                (
                    this.BillingPhoneNumber == input.BillingPhoneNumber ||
                    (this.BillingPhoneNumber != null &&
                    this.BillingPhoneNumber.Equals(input.BillingPhoneNumber))
                ) && 
                (
                    this.MethodAlias == input.MethodAlias ||
                    (this.MethodAlias != null &&
                    this.MethodAlias.Equals(input.MethodAlias))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.MethodAddress == input.MethodAddress ||
                    (this.MethodAddress != null &&
                    this.MethodAddress.Equals(input.MethodAddress))
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
                hashCode = hashCode * 59 + this.MethodType.GetHashCode();
                if (this.MethodId != null)
                    hashCode = hashCode * 59 + this.MethodId.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
                if (this.BillingPhoneNumber != null)
                    hashCode = hashCode * 59 + this.BillingPhoneNumber.GetHashCode();
                if (this.MethodAlias != null)
                    hashCode = hashCode * 59 + this.MethodAlias.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.MethodAddress != null)
                    hashCode = hashCode * 59 + this.MethodAddress.GetHashCode();
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