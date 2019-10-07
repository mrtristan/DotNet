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
    /// PaymentCardPreAuthTransactionAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentCardPreAuthTransactionAllOf :  IEquatable<PaymentCardPreAuthTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPreAuthTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardPreAuthTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPreAuthTransactionAllOf" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="storedCredentials">storedCredentials.</param>
        /// <param name="createToken">createToken.</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="settlementSplit">Settle with multiple sub-merchants, sale and preAuth only..</param>
        public PaymentCardPreAuthTransactionAllOf(PaymentCardPaymentMethod paymentMethod = default(PaymentCardPaymentMethod), StoredCredential storedCredentials = default(StoredCredential), CreatePaymentToken createToken = default(CreatePaymentToken), SplitShipment splitShipment = default(SplitShipment), List<SubMerchantSplit> settlementSplit = default(List<SubMerchantSplit>))
        {
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentCardPreAuthTransactionAllOf and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }

            this.StoredCredentials = storedCredentials;
            this.CreateToken = createToken;
            this.SplitShipment = splitShipment;
            this.SettlementSplit = settlementSplit;
        }
        
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public PaymentCardPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets StoredCredentials
        /// </summary>
        [DataMember(Name="storedCredentials", EmitDefaultValue=false)]
        public StoredCredential StoredCredentials { get; set; }

        /// <summary>
        /// Gets or Sets CreateToken
        /// </summary>
        [DataMember(Name="createToken", EmitDefaultValue=false)]
        public CreatePaymentToken CreateToken { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name="splitShipment", EmitDefaultValue=false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// Settle with multiple sub-merchants, sale and preAuth only.
        /// </summary>
        /// <value>Settle with multiple sub-merchants, sale and preAuth only.</value>
        [DataMember(Name="settlementSplit", EmitDefaultValue=false)]
        public List<SubMerchantSplit> SettlementSplit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardPreAuthTransactionAllOf {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
            sb.Append("  CreateToken: ").Append(CreateToken).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  SettlementSplit: ").Append(SettlementSplit).Append("\n");
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
            return this.Equals(input as PaymentCardPreAuthTransactionAllOf);
        }

        /// <summary>
        /// Returns true if PaymentCardPreAuthTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardPreAuthTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardPreAuthTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.StoredCredentials == input.StoredCredentials ||
                    (this.StoredCredentials != null &&
                    this.StoredCredentials.Equals(input.StoredCredentials))
                ) && 
                (
                    this.CreateToken == input.CreateToken ||
                    (this.CreateToken != null &&
                    this.CreateToken.Equals(input.CreateToken))
                ) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && 
                (
                    this.SettlementSplit == input.SettlementSplit ||
                    this.SettlementSplit != null &&
                    input.SettlementSplit != null &&
                    this.SettlementSplit.SequenceEqual(input.SettlementSplit)
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
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.StoredCredentials != null)
                    hashCode = hashCode * 59 + this.StoredCredentials.GetHashCode();
                if (this.CreateToken != null)
                    hashCode = hashCode * 59 + this.CreateToken.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
                if (this.SettlementSplit != null)
                    hashCode = hashCode * 59 + this.SettlementSplit.GetHashCode();
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
