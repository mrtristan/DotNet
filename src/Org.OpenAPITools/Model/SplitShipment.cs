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
    /// Split-shipment related information, in order to reuse the same authorization.
    /// </summary>
    [DataContract]
    public partial class SplitShipment :  IEquatable<SplitShipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitShipment" /> class.
        /// </summary>
        /// <param name="totalCount">Total count of the shipment, can be set at preauth or the first postauth..</param>
        /// <param name="finalShipment">Indicates whether the transaction is the final shipment. (default to false).</param>
        public SplitShipment(int totalCount = default(int), bool finalShipment = false)
        {
            this.TotalCount = totalCount;
            // use default value if no "finalShipment" provided
            if (finalShipment == null)
            {
                this.FinalShipment = false;
            }
            else
            {
                this.FinalShipment = finalShipment;
            }
        }
        
        /// <summary>
        /// Total count of the shipment, can be set at preauth or the first postauth.
        /// </summary>
        /// <value>Total count of the shipment, can be set at preauth or the first postauth.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Indicates whether the transaction is the final shipment.
        /// </summary>
        /// <value>Indicates whether the transaction is the final shipment.</value>
        [DataMember(Name="finalShipment", EmitDefaultValue=false)]
        public bool FinalShipment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitShipment {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  FinalShipment: ").Append(FinalShipment).Append("\n");
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
            return this.Equals(input as SplitShipment);
        }

        /// <summary>
        /// Returns true if SplitShipment instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitShipment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.FinalShipment == input.FinalShipment ||
                    this.FinalShipment.Equals(input.FinalShipment)
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
                hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.FinalShipment.GetHashCode();
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