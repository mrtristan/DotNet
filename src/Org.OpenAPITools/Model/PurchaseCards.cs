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
    /// Purchase card details.
    /// </summary>
    [DataContract]
    public partial class PurchaseCards :  IEquatable<PurchaseCards>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCards" /> class.
        /// </summary>
        /// <param name="level2">level2.</param>
        /// <param name="level3">level3.</param>
        public PurchaseCards(PurchaseCardsLevel2 level2 = default(PurchaseCardsLevel2), PurchaseCardsLevel3 level3 = default(PurchaseCardsLevel3))
        {
            this.Level2 = level2;
            this.Level3 = level3;
        }
        
        /// <summary>
        /// Gets or Sets Level2
        /// </summary>
        [DataMember(Name="Level2", EmitDefaultValue=false)]
        public PurchaseCardsLevel2 Level2 { get; set; }

        /// <summary>
        /// Gets or Sets Level3
        /// </summary>
        [DataMember(Name="Level3", EmitDefaultValue=false)]
        public PurchaseCardsLevel3 Level3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseCards {\n");
            sb.Append("  Level2: ").Append(Level2).Append("\n");
            sb.Append("  Level3: ").Append(Level3).Append("\n");
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
            return this.Equals(input as PurchaseCards);
        }

        /// <summary>
        /// Returns true if PurchaseCards instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseCards to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseCards input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Level2 == input.Level2 ||
                    (this.Level2 != null &&
                    this.Level2.Equals(input.Level2))
                ) && 
                (
                    this.Level3 == input.Level3 ||
                    (this.Level3 != null &&
                    this.Level3.Equals(input.Level3))
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
                if (this.Level2 != null)
                    hashCode = hashCode * 59 + this.Level2.GetHashCode();
                if (this.Level3 != null)
                    hashCode = hashCode * 59 + this.Level3.GetHashCode();
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
