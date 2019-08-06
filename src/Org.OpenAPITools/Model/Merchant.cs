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
    /// The merchant where this transaction occurred.
    /// </summary>
    [DataContract]
    public partial class Merchant :  IEquatable<Merchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Merchant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant" /> class.
        /// </summary>
        /// <param name="mcc">The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction..</param>
        /// <param name="merchantUniqueId">The unique ID of this merchant. Must be unique for the entire system (not just within a specific industry). (required).</param>
        /// <param name="location">location.</param>
        /// <param name="userDefined">A JSON object that can carry any additional information about the merchant that might be helpful for fraud detection..</param>
        public Merchant(string mcc = default(string), string merchantUniqueId = default(string), MerchantLocation location = default(MerchantLocation), Object userDefined = default(Object))
        {
            // to ensure "merchantUniqueId" is required (not null)
            if (merchantUniqueId == null)
            {
                throw new InvalidDataException("merchantUniqueId is a required property for Merchant and cannot be null");
            }
            else
            {
                this.MerchantUniqueId = merchantUniqueId;
            }

            this.Mcc = mcc;
            this.Location = location;
            this.UserDefined = userDefined;
        }
        
        /// <summary>
        /// The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.
        /// </summary>
        /// <value>The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.</value>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public string Mcc { get; set; }

        /// <summary>
        /// The unique ID of this merchant. Must be unique for the entire system (not just within a specific industry).
        /// </summary>
        /// <value>The unique ID of this merchant. Must be unique for the entire system (not just within a specific industry).</value>
        [DataMember(Name="merchantUniqueId", EmitDefaultValue=false)]
        public string MerchantUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public MerchantLocation Location { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information about the merchant that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information about the merchant that might be helpful for fraud detection.</value>
        [DataMember(Name="userDefined", EmitDefaultValue=false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Merchant {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantUniqueId: ").Append(MerchantUniqueId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as Merchant);
        }

        /// <summary>
        /// Returns true if Merchant instances are equal
        /// </summary>
        /// <param name="input">Instance of Merchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Merchant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) && 
                (
                    this.MerchantUniqueId == input.MerchantUniqueId ||
                    (this.MerchantUniqueId != null &&
                    this.MerchantUniqueId.Equals(input.MerchantUniqueId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Mcc != null)
                    hashCode = hashCode * 59 + this.Mcc.GetHashCode();
                if (this.MerchantUniqueId != null)
                    hashCode = hashCode * 59 + this.MerchantUniqueId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
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
            // MerchantUniqueId (string) pattern
            Regex regexMerchantUniqueId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexMerchantUniqueId.Match(this.MerchantUniqueId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantUniqueId, must match a pattern of " + regexMerchantUniqueId, new [] { "MerchantUniqueId" });
            }

            yield break;
        }
    }

}
