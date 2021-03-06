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
    /// Object contains font properties.
    /// </summary>
    [DataContract]
    public partial class FontProperties : IEquatable<FontProperties>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FontFace
        /// </summary>
        [DataMember(Name = "fontFace", EmitDefaultValue = false)]
        public FontFace? FontFace { get; set; }
        /// <summary>
        /// Gets or Sets FontWeight
        /// </summary>
        [DataMember(Name = "fontWeight", EmitDefaultValue = false)]
        public FontWeight? FontWeight { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FontProperties" /> class.
        /// </summary>
        /// <param name="fontFace">fontFace.</param>
        /// <param name="fontSize">Font size property..</param>
        /// <param name="fontWeight">fontWeight.</param>
        /// <param name="fontColor">Hexadecimal color value..</param>
        public FontProperties(FontFace? fontFace = null, string fontSize = default(string), FontWeight? fontWeight = null, string fontColor = default(string))
        {
            this.FontFace = fontFace;
            this.FontSize = fontSize;
            this.FontWeight = fontWeight;
            this.FontColor = fontColor;
        }

        /// <summary>
        /// Font size property.
        /// </summary>
        /// <value>Font size property.</value>
        [DataMember(Name = "fontSize", EmitDefaultValue = false)]
        public string FontSize { get; set; }

        /// <summary>
        /// Hexadecimal color value.
        /// </summary>
        /// <value>Hexadecimal color value.</value>
        [DataMember(Name = "fontColor", EmitDefaultValue = false)]
        public string FontColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FontProperties {\n");
            sb.Append("  FontFace: ").Append(FontFace).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  FontWeight: ").Append(FontWeight).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
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
            return this.Equals(input as FontProperties);
        }

        /// <summary>
        /// Returns true if FontProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of FontProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FontProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FontFace == input.FontFace ||
                    this.FontFace.Equals(input.FontFace)
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.FontWeight == input.FontWeight ||
                    this.FontWeight.Equals(input.FontWeight)
                ) && 
                (
                    this.FontColor == input.FontColor ||
                    (this.FontColor != null &&
                    this.FontColor.Equals(input.FontColor))
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
                hashCode = hashCode * 59 + this.FontFace.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                hashCode = hashCode * 59 + this.FontWeight.GetHashCode();
                if (this.FontColor != null)
                    hashCode = hashCode * 59 + this.FontColor.GetHashCode();
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
            // FontColor (string) pattern
            Regex regexFontColor = new Regex(@"(^(0[xX]){1}[A-Fa-f0-9]+$)|(^#[A-Fa-f0-9]{6}$)", RegexOptions.CultureInvariant);
            if (false == regexFontColor.Match(this.FontColor).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FontColor, must match a pattern of " + regexFontColor, new [] { "FontColor" });
            }

            yield break;
        }
    }
}
