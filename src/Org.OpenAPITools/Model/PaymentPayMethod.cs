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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Info about the payment method.
    /// </summary>
    [DataContract]
    public partial class PaymentPayMethod :  IEquatable<PaymentPayMethod>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="PaymentPayMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentPayMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentPayMethod" /> class.
        /// </summary>
        /// <param name="methodType">Unique ID for the payment method type. (required).</param>
        /// <param name="methodId">The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method..</param>
        /// <param name="methodAlias">The address that should be used to send billing information for this payment method..</param>
        /// <param name="card">card (required).</param>
        /// <param name="provider">The wallet provider. This field should be normalized before sending through the API..</param>
        /// <param name="userDefined">A JSON object that can carry any additional information about the method that might be helpful for fraud detection..</param>
        public PaymentPayMethod(MethodTypeEnum methodType = default(MethodTypeEnum), string methodId = default(string), string methodAlias = default(string), Card card = default(Card), string provider = default(string), Object userDefined = default(Object))
        {
            this.MethodType = methodType;
            // to ensure "card" is required (not null)
            if (card == null)
            {
                throw new InvalidDataException("card is a required property for PaymentPayMethod and cannot be null");
            }
            else
            {
                this.Card = card;
            }

            this.MethodId = methodId;
            this.MethodAlias = methodAlias;
            this.Provider = provider;
            this.UserDefined = userDefined;
        }
        
        /// <summary>
        /// The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method.
        /// </summary>
        /// <value>The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method.</value>
        [DataMember(Name="methodId", EmitDefaultValue=false)]
        public string MethodId { get; set; }

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
        public Card Card { get; set; }

        /// <summary>
        /// The wallet provider. This field should be normalized before sending through the API.
        /// </summary>
        /// <value>The wallet provider. This field should be normalized before sending through the API.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information about the method that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information about the method that might be helpful for fraud detection.</value>
        [DataMember(Name="userDefined", EmitDefaultValue=false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentPayMethod {\n");
            sb.Append("  MethodType: ").Append(MethodType).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  MethodAlias: ").Append(MethodAlias).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
            return this.Equals(input as PaymentPayMethod);
        }

        /// <summary>
        /// Returns true if PaymentPayMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentPayMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentPayMethod input)
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
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
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
                if (this.MethodAlias != null)
                    hashCode = hashCode * 59 + this.MethodAlias.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
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
