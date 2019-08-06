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
    /// WalletPreAuthTransactionAllOf
    /// </summary>
    [DataContract]
    public partial class WalletPreAuthTransactionAllOf :  IEquatable<WalletPreAuthTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPreAuthTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletPreAuthTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletPreAuthTransactionAllOf" /> class.
        /// </summary>
        /// <param name="walletPaymentMethod">walletPaymentMethod (required).</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="paymentFacilitator">paymentFacilitator.</param>
        public WalletPreAuthTransactionAllOf(WalletPaymentMethod walletPaymentMethod = default(WalletPaymentMethod), SplitShipment splitShipment = default(SplitShipment), PaymentFacilitator paymentFacilitator = default(PaymentFacilitator))
        {
            // to ensure "walletPaymentMethod" is required (not null)
            if (walletPaymentMethod == null)
            {
                throw new InvalidDataException("walletPaymentMethod is a required property for WalletPreAuthTransactionAllOf and cannot be null");
            }
            else
            {
                this.WalletPaymentMethod = walletPaymentMethod;
            }

            this.SplitShipment = splitShipment;
            this.PaymentFacilitator = paymentFacilitator;
        }
        
        /// <summary>
        /// Gets or Sets WalletPaymentMethod
        /// </summary>
        [DataMember(Name="walletPaymentMethod", EmitDefaultValue=false)]
        public WalletPaymentMethod WalletPaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name="splitShipment", EmitDefaultValue=false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// Gets or Sets PaymentFacilitator
        /// </summary>
        [DataMember(Name="paymentFacilitator", EmitDefaultValue=false)]
        public PaymentFacilitator PaymentFacilitator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletPreAuthTransactionAllOf {\n");
            sb.Append("  WalletPaymentMethod: ").Append(WalletPaymentMethod).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  PaymentFacilitator: ").Append(PaymentFacilitator).Append("\n");
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
            return this.Equals(input as WalletPreAuthTransactionAllOf);
        }

        /// <summary>
        /// Returns true if WalletPreAuthTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletPreAuthTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletPreAuthTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WalletPaymentMethod == input.WalletPaymentMethod ||
                    (this.WalletPaymentMethod != null &&
                    this.WalletPaymentMethod.Equals(input.WalletPaymentMethod))
                ) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && 
                (
                    this.PaymentFacilitator == input.PaymentFacilitator ||
                    (this.PaymentFacilitator != null &&
                    this.PaymentFacilitator.Equals(input.PaymentFacilitator))
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
                if (this.WalletPaymentMethod != null)
                    hashCode = hashCode * 59 + this.WalletPaymentMethod.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
                if (this.PaymentFacilitator != null)
                    hashCode = hashCode * 59 + this.PaymentFacilitator.GetHashCode();
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
