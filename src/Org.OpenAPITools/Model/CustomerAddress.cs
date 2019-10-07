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
    /// Customer address fields.
    /// </summary>
    [DataContract]
    public partial class CustomerAddress :  IEquatable<CustomerAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddress" /> class.
        /// </summary>
        /// <param name="street">First line of street address. (required).</param>
        /// <param name="street2">Second line of street address..</param>
        /// <param name="stateProvince">State or province..</param>
        /// <param name="city">City..</param>
        /// <param name="country">Country. (required).</param>
        /// <param name="zipPostalCode">Postal code. (required).</param>
        /// <param name="phone">phone.</param>
        public CustomerAddress(string street = default(string), string street2 = default(string), string stateProvince = default(string), string city = default(string), string country = default(string), string zipPostalCode = default(string), Phone phone = default(Phone))
        {
            // to ensure "street" is required (not null)
            if (street == null)
            {
                throw new InvalidDataException("street is a required property for CustomerAddress and cannot be null");
            }
            else
            {
                this.Street = street;
            }

            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for CustomerAddress and cannot be null");
            }
            else
            {
                this.Country = country;
            }

            // to ensure "zipPostalCode" is required (not null)
            if (zipPostalCode == null)
            {
                throw new InvalidDataException("zipPostalCode is a required property for CustomerAddress and cannot be null");
            }
            else
            {
                this.ZipPostalCode = zipPostalCode;
            }

            this.Street2 = street2;
            this.StateProvince = stateProvince;
            this.City = city;
            this.Phone = phone;
        }
        
        /// <summary>
        /// First line of street address.
        /// </summary>
        /// <value>First line of street address.</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Second line of street address.
        /// </summary>
        /// <value>Second line of street address.</value>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        /// <value>State or province.</value>
        [DataMember(Name="stateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        /// <value>Country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name="zipPostalCode", EmitDefaultValue=false)]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public Phone Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerAddress {\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ZipPostalCode: ").Append(ZipPostalCode).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as CustomerAddress);
        }

        /// <summary>
        /// Returns true if CustomerAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ZipPostalCode == input.ZipPostalCode ||
                    (this.ZipPostalCode != null &&
                    this.ZipPostalCode.Equals(input.ZipPostalCode))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Street2 != null)
                    hashCode = hashCode * 59 + this.Street2.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ZipPostalCode != null)
                    hashCode = hashCode * 59 + this.ZipPostalCode.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
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
            // Street (string) pattern
            Regex regexStreet = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexStreet.Match(this.Street).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Street, must match a pattern of " + regexStreet, new [] { "Street" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            // ZipPostalCode (string) pattern
            Regex regexZipPostalCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexZipPostalCode.Match(this.ZipPostalCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipPostalCode, must match a pattern of " + regexZipPostalCode, new [] { "ZipPostalCode" });
            }

            yield break;
        }
    }

}
