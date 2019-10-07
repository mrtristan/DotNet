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
    /// Payment facilitator details provided by the merchant.
    /// </summary>
    [DataContract]
    public partial class PaymentFacilitator :  IEquatable<PaymentFacilitator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentFacilitator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentFacilitator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentFacilitator" /> class.
        /// </summary>
        /// <param name="externalMerchantId">External merchant ID of the payment facilitator. (required).</param>
        /// <param name="paymentFacilitatorId">Payment facilitator ID supplied during boarding. (required).</param>
        /// <param name="saleOrganizationId">Independent sales organization (ISO) ID provided by Mastercard..</param>
        /// <param name="name">Payment facilitator name. (required).</param>
        /// <param name="subMerchantData">subMerchantData.</param>
        public PaymentFacilitator(string externalMerchantId = default(string), string paymentFacilitatorId = default(string), string saleOrganizationId = default(string), string name = default(string), SubMerchantData subMerchantData = default(SubMerchantData))
        {
            // to ensure "externalMerchantId" is required (not null)
            if (externalMerchantId == null)
            {
                throw new InvalidDataException("externalMerchantId is a required property for PaymentFacilitator and cannot be null");
            }
            else
            {
                this.ExternalMerchantId = externalMerchantId;
            }

            // to ensure "paymentFacilitatorId" is required (not null)
            if (paymentFacilitatorId == null)
            {
                throw new InvalidDataException("paymentFacilitatorId is a required property for PaymentFacilitator and cannot be null");
            }
            else
            {
                this.PaymentFacilitatorId = paymentFacilitatorId;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PaymentFacilitator and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.SaleOrganizationId = saleOrganizationId;
            this.SubMerchantData = subMerchantData;
        }
        
        /// <summary>
        /// External merchant ID of the payment facilitator.
        /// </summary>
        /// <value>External merchant ID of the payment facilitator.</value>
        [DataMember(Name="externalMerchantId", EmitDefaultValue=false)]
        public string ExternalMerchantId { get; set; }

        /// <summary>
        /// Payment facilitator ID supplied during boarding.
        /// </summary>
        /// <value>Payment facilitator ID supplied during boarding.</value>
        [DataMember(Name="paymentFacilitatorId", EmitDefaultValue=false)]
        public string PaymentFacilitatorId { get; set; }

        /// <summary>
        /// Independent sales organization (ISO) ID provided by Mastercard.
        /// </summary>
        /// <value>Independent sales organization (ISO) ID provided by Mastercard.</value>
        [DataMember(Name="saleOrganizationId", EmitDefaultValue=false)]
        public string SaleOrganizationId { get; set; }

        /// <summary>
        /// Payment facilitator name.
        /// </summary>
        /// <value>Payment facilitator name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchantData
        /// </summary>
        [DataMember(Name="subMerchantData", EmitDefaultValue=false)]
        public SubMerchantData SubMerchantData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentFacilitator {\n");
            sb.Append("  ExternalMerchantId: ").Append(ExternalMerchantId).Append("\n");
            sb.Append("  PaymentFacilitatorId: ").Append(PaymentFacilitatorId).Append("\n");
            sb.Append("  SaleOrganizationId: ").Append(SaleOrganizationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubMerchantData: ").Append(SubMerchantData).Append("\n");
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
            return this.Equals(input as PaymentFacilitator);
        }

        /// <summary>
        /// Returns true if PaymentFacilitator instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentFacilitator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentFacilitator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalMerchantId == input.ExternalMerchantId ||
                    (this.ExternalMerchantId != null &&
                    this.ExternalMerchantId.Equals(input.ExternalMerchantId))
                ) && 
                (
                    this.PaymentFacilitatorId == input.PaymentFacilitatorId ||
                    (this.PaymentFacilitatorId != null &&
                    this.PaymentFacilitatorId.Equals(input.PaymentFacilitatorId))
                ) && 
                (
                    this.SaleOrganizationId == input.SaleOrganizationId ||
                    (this.SaleOrganizationId != null &&
                    this.SaleOrganizationId.Equals(input.SaleOrganizationId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubMerchantData == input.SubMerchantData ||
                    (this.SubMerchantData != null &&
                    this.SubMerchantData.Equals(input.SubMerchantData))
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
                if (this.ExternalMerchantId != null)
                    hashCode = hashCode * 59 + this.ExternalMerchantId.GetHashCode();
                if (this.PaymentFacilitatorId != null)
                    hashCode = hashCode * 59 + this.PaymentFacilitatorId.GetHashCode();
                if (this.SaleOrganizationId != null)
                    hashCode = hashCode * 59 + this.SaleOrganizationId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubMerchantData != null)
                    hashCode = hashCode * 59 + this.SubMerchantData.GetHashCode();
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
            // ExternalMerchantId (string) pattern
            Regex regexExternalMerchantId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexExternalMerchantId.Match(this.ExternalMerchantId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalMerchantId, must match a pattern of " + regexExternalMerchantId, new [] { "ExternalMerchantId" });
            }

            // PaymentFacilitatorId (string) pattern
            Regex regexPaymentFacilitatorId = new Regex(@"\\d{1,11}", RegexOptions.CultureInvariant);
            if (false == regexPaymentFacilitatorId.Match(this.PaymentFacilitatorId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentFacilitatorId, must match a pattern of " + regexPaymentFacilitatorId, new [] { "PaymentFacilitatorId" });
            }

            // SaleOrganizationId (string) pattern
            Regex regexSaleOrganizationId = new Regex(@"\\d{1,11}", RegexOptions.CultureInvariant);
            if (false == regexSaleOrganizationId.Match(this.SaleOrganizationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SaleOrganizationId, must match a pattern of " + regexSaleOrganizationId, new [] { "SaleOrganizationId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }

}
