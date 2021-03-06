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
    /// Object contains configurable style properties for mobile.
    /// </summary>
    [DataContract]
    public partial class Mobile : IEquatable<Mobile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mobile" /> class.
        /// </summary>
        /// <param name="headerArea">headerArea.</param>
        /// <param name="showLogo">check if logo should be shown.</param>
        public Mobile(MobileHeaderArea headerArea = default(MobileHeaderArea), bool showLogo = default(bool))
        {
            this.HeaderArea = headerArea;
            this.ShowLogo = showLogo;
        }

        /// <summary>
        /// Gets or Sets HeaderArea
        /// </summary>
        [DataMember(Name = "headerArea", EmitDefaultValue = false)]
        public MobileHeaderArea HeaderArea { get; set; }

        /// <summary>
        /// check if logo should be shown
        /// </summary>
        /// <value>check if logo should be shown</value>
        [DataMember(Name = "showLogo", EmitDefaultValue = false)]
        public bool ShowLogo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mobile {\n");
            sb.Append("  HeaderArea: ").Append(HeaderArea).Append("\n");
            sb.Append("  ShowLogo: ").Append(ShowLogo).Append("\n");
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
            return this.Equals(input as Mobile);
        }

        /// <summary>
        /// Returns true if Mobile instances are equal
        /// </summary>
        /// <param name="input">Instance of Mobile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mobile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeaderArea == input.HeaderArea ||
                    (this.HeaderArea != null &&
                    this.HeaderArea.Equals(input.HeaderArea))
                ) && 
                (
                    this.ShowLogo == input.ShowLogo ||
                    this.ShowLogo.Equals(input.ShowLogo)
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
                if (this.HeaderArea != null)
                    hashCode = hashCode * 59 + this.HeaderArea.GetHashCode();
                hashCode = hashCode * 59 + this.ShowLogo.GetHashCode();
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
