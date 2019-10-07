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
    /// Payment method containing payment device information.
    /// </summary>
    [DataContract]
    public partial class PaymentDevicePaymentMethod :  IEquatable<PaymentDevicePaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevicePaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentDevicePaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevicePaymentMethod" /> class.
        /// </summary>
        /// <param name="paymentDevice">paymentDevice (required).</param>
        /// <param name="paymentFacilitator">paymentFacilitator.</param>
        public PaymentDevicePaymentMethod(PaymentDevice paymentDevice = default(PaymentDevice), PaymentFacilitator paymentFacilitator = default(PaymentFacilitator))
        {
            // to ensure "paymentDevice" is required (not null)
            if (paymentDevice == null)
            {
                throw new InvalidDataException("paymentDevice is a required property for PaymentDevicePaymentMethod and cannot be null");
            }
            else
            {
                this.PaymentDevice = paymentDevice;
            }

            this.PaymentFacilitator = paymentFacilitator;
        }
        
        /// <summary>
        /// Gets or Sets PaymentDevice
        /// </summary>
        [DataMember(Name="paymentDevice", EmitDefaultValue=false)]
        public PaymentDevice PaymentDevice { get; set; }

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
            sb.Append("class PaymentDevicePaymentMethod {\n");
            sb.Append("  PaymentDevice: ").Append(PaymentDevice).Append("\n");
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
            return this.Equals(input as PaymentDevicePaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentDevicePaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDevicePaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDevicePaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentDevice == input.PaymentDevice ||
                    (this.PaymentDevice != null &&
                    this.PaymentDevice.Equals(input.PaymentDevice))
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
                if (this.PaymentDevice != null)
                    hashCode = hashCode * 59 + this.PaymentDevice.GetHashCode();
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
