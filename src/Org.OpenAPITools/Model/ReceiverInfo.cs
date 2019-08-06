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
    /// Receiver information for a funding transaction.
    /// </summary>
    [DataContract]
    public partial class ReceiverInfo :  IEquatable<ReceiverInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiverInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReceiverInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiverInfo" /> class.
        /// </summary>
        /// <param name="name">Receiver name. (required).</param>
        /// <param name="streetAddress">Receiver street address. (required).</param>
        /// <param name="city">Receiver city. (required).</param>
        /// <param name="stateCode">Receiver state. (required).</param>
        /// <param name="countryCode">Receiver country code. (required).</param>
        /// <param name="postalCode">Receiver postal code. (required).</param>
        /// <param name="phoneNumber">Receiver phone number. (required).</param>
        /// <param name="referenceNumber">Receiver reference number. (required).</param>
        /// <param name="accountNumber">Receiver account number..</param>
        public ReceiverInfo(string name = default(string), string streetAddress = default(string), string city = default(string), string stateCode = default(string), string countryCode = default(string), string postalCode = default(string), string phoneNumber = default(string), string referenceNumber = default(string), string accountNumber = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "streetAddress" is required (not null)
            if (streetAddress == null)
            {
                throw new InvalidDataException("streetAddress is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.StreetAddress = streetAddress;
            }

            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.City = city;
            }

            // to ensure "stateCode" is required (not null)
            if (stateCode == null)
            {
                throw new InvalidDataException("stateCode is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.StateCode = stateCode;
            }

            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }

            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new InvalidDataException("postalCode is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.PostalCode = postalCode;
            }

            // to ensure "phoneNumber" is required (not null)
            if (phoneNumber == null)
            {
                throw new InvalidDataException("phoneNumber is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
            }

            // to ensure "referenceNumber" is required (not null)
            if (referenceNumber == null)
            {
                throw new InvalidDataException("referenceNumber is a required property for ReceiverInfo and cannot be null");
            }
            else
            {
                this.ReferenceNumber = referenceNumber;
            }

            this.AccountNumber = accountNumber;
        }
        
        /// <summary>
        /// Receiver name.
        /// </summary>
        /// <value>Receiver name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Receiver street address.
        /// </summary>
        /// <value>Receiver street address.</value>
        [DataMember(Name="streetAddress", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Receiver city.
        /// </summary>
        /// <value>Receiver city.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Receiver state.
        /// </summary>
        /// <value>Receiver state.</value>
        [DataMember(Name="stateCode", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Receiver country code.
        /// </summary>
        /// <value>Receiver country code.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Receiver postal code.
        /// </summary>
        /// <value>Receiver postal code.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Receiver phone number.
        /// </summary>
        /// <value>Receiver phone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Receiver reference number.
        /// </summary>
        /// <value>Receiver reference number.</value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Receiver account number.
        /// </summary>
        /// <value>Receiver account number.</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReceiverInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
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
            return this.Equals(input as ReceiverInfo);
        }

        /// <summary>
        /// Returns true if ReceiverInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiverInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiverInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ReferenceNumber != null)
                    hashCode = hashCode * 59 + this.ReferenceNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // StreetAddress (string) maxLength
            if(this.StreetAddress != null && this.StreetAddress.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetAddress, length must be less than 250.", new [] { "StreetAddress" });
            }

            // StreetAddress (string) pattern
            Regex regexStreetAddress = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexStreetAddress.Match(this.StreetAddress).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetAddress, must match a pattern of " + regexStreetAddress, new [] { "StreetAddress" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 50.", new [] { "City" });
            }

            // City (string) pattern
            Regex regexCity = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCity.Match(this.City).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, must match a pattern of " + regexCity, new [] { "City" });
            }

            // StateCode (string) maxLength
            if(this.StateCode != null && this.StateCode.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateCode, length must be less than 50.", new [] { "StateCode" });
            }

            // StateCode (string) pattern
            Regex regexStateCode = new Regex(@"[A-Z]{2}", RegexOptions.CultureInvariant);
            if (false == regexStateCode.Match(this.StateCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateCode, must match a pattern of " + regexStateCode, new [] { "StateCode" });
            }

            // CountryCode (string) pattern
            Regex regexCountryCode = new Regex(@"[A-Z]{2}", RegexOptions.CultureInvariant);
            if (false == regexCountryCode.Match(this.CountryCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, must match a pattern of " + regexCountryCode, new [] { "CountryCode" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 10.", new [] { "PostalCode" });
            }

            // PostalCode (string) pattern
            Regex regexPostalCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexPostalCode.Match(this.PostalCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, must match a pattern of " + regexPostalCode, new [] { "PostalCode" });
            }

            // PhoneNumber (string) pattern
            Regex regexPhoneNumber = new Regex(@"[0-9]{10}", RegexOptions.CultureInvariant);
            if (false == regexPhoneNumber.Match(this.PhoneNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, must match a pattern of " + regexPhoneNumber, new [] { "PhoneNumber" });
            }

            // ReferenceNumber (string) pattern
            Regex regexReferenceNumber = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexReferenceNumber.Match(this.ReferenceNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceNumber, must match a pattern of " + regexReferenceNumber, new [] { "ReferenceNumber" });
            }

            // AccountNumber (string) pattern
            Regex regexAccountNumber = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexAccountNumber.Match(this.AccountNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, must match a pattern of " + regexAccountNumber, new [] { "AccountNumber" });
            }

            yield break;
        }
    }

}
