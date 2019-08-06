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
    /// Amount of the transaction.
    /// </summary>
    [DataContract]
    public partial class Amount :  IEquatable<Amount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Amount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount" /> class.
        /// </summary>
        /// <param name="total">Amount total. (required).</param>
        /// <param name="currency">ISO 4217 currency code. (required).</param>
        /// <param name="components">components.</param>
        public Amount(decimal total = default(decimal), string currency = default(string), AmountComponents components = default(AmountComponents))
        {
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for Amount and cannot be null");
            }
            else
            {
                this.Total = total;
            }

            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for Amount and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }

            this.Components = components;
        }
        
        /// <summary>
        /// Amount total.
        /// </summary>
        /// <value>Amount total.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// ISO 4217 currency code.
        /// </summary>
        /// <value>ISO 4217 currency code.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public AmountComponents Components { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Amount {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
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
            return this.Equals(input as Amount);
        }

        /// <summary>
        /// Returns true if Amount instances are equal
        /// </summary>
        /// <param name="input">Instance of Amount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Amount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Components == input.Components ||
                    (this.Components != null &&
                    this.Components.Equals(input.Components))
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
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Components != null)
                    hashCode = hashCode * 59 + this.Components.GetHashCode();
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
            // Currency (string) pattern
            Regex regexCurrency = new Regex(@"([A-Z]{3})|([0-9]{3})", RegexOptions.CultureInvariant);
            if (false == regexCurrency.Match(this.Currency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, must match a pattern of " + regexCurrency, new [] { "Currency" });
            }

            yield break;
        }
    }

}
