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
    /// Model for address information.
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="company">Company name associated with the address..</param>
        /// <param name="address1">First line of the street address..</param>
        /// <param name="address2">Second line of the street address..</param>
        /// <param name="city">City or locality..</param>
        /// <param name="region">State or province..</param>
        /// <param name="postalCode">ZIP code or postal code..</param>
        /// <param name="country">ISO-3166-1  ALPHA-2, ALPHA-3, numeric or full country name. In the case of PaySecure endpoints, pass the country code in an ISO format..</param>
        public Address(string company = default(string), string address1 = default(string), string address2 = default(string), string city = default(string), string region = default(string), string postalCode = default(string), string country = default(string))
        {
            this.Company = company;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
        }
        
        /// <summary>
        /// Company name associated with the address.
        /// </summary>
        /// <value>Company name associated with the address.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// First line of the street address.
        /// </summary>
        /// <value>First line of the street address.</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of the street address.
        /// </summary>
        /// <value>Second line of the street address.</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// City or locality.
        /// </summary>
        /// <value>City or locality.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        /// <value>State or province.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// ZIP code or postal code.
        /// </summary>
        /// <value>ZIP code or postal code.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// ISO-3166-1  ALPHA-2, ALPHA-3, numeric or full country name. In the case of PaySecure endpoints, pass the country code in an ISO format.
        /// </summary>
        /// <value>ISO-3166-1  ALPHA-2, ALPHA-3, numeric or full country name. In the case of PaySecure endpoints, pass the country code in an ISO format.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
            // Company (string) maxLength
            if(this.Company != null && this.Company.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Company, length must be less than 96.", new [] { "Company" });
            }

            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 96.", new [] { "Address1" });
            }

            // Address2 (string) maxLength
            if(this.Address2 != null && this.Address2.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address2, length must be less than 96.", new [] { "Address2" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 96.", new [] { "City" });
            }

            // Region (string) maxLength
            if(this.Region != null && this.Region.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be less than 96.", new [] { "Region" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 24.", new [] { "PostalCode" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 32.", new [] { "Country" });
            }

            yield break;
        }
    }

}
