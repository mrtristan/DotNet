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
    /// Object that holds information about maximum purchase amount limit.
    /// </summary>
    [DataContract]
    public partial class MaximumPurchaseAmount : IEquatable<MaximumPurchaseAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumPurchaseAmount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MaximumPurchaseAmount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumPurchaseAmount" /> class.
        /// </summary>
        /// <param name="currency">Currency in alphabetic ISO 4217 currency code format. (required).</param>
        /// <param name="maxAmount">Maximum purchase amount limit. (required).</param>
        public MaximumPurchaseAmount(string currency = default(string), string maxAmount = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency is a required property for MaximumPurchaseAmount and cannot be null");
            // to ensure "maxAmount" is required (not null)
            this.MaxAmount = maxAmount ?? throw new ArgumentNullException("maxAmount is a required property for MaximumPurchaseAmount and cannot be null");
        }

        /// <summary>
        /// Currency in alphabetic ISO 4217 currency code format.
        /// </summary>
        /// <value>Currency in alphabetic ISO 4217 currency code format.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Maximum purchase amount limit.
        /// </summary>
        /// <value>Maximum purchase amount limit.</value>
        [DataMember(Name = "maxAmount", EmitDefaultValue = false)]
        public string MaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaximumPurchaseAmount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
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
            return this.Equals(input as MaximumPurchaseAmount);
        }

        /// <summary>
        /// Returns true if MaximumPurchaseAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of MaximumPurchaseAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaximumPurchaseAmount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.MaxAmount != null)
                    hashCode = hashCode * 59 + this.MaxAmount.GetHashCode();
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
