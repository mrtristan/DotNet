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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Model for secondary financial transactions. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    [JsonSubtypes.KnownSubType(typeof(PostAuthTransaction), "PostAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(ReturnTransaction), "ReturnTransaction")]
    [JsonSubtypes.KnownSubType(typeof(VoidTransaction), "VoidTransaction")]
    public partial class SecondaryTransaction :  IEquatable<SecondaryTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecondaryTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryTransaction" /> class.
        /// </summary>
        /// <param name="requestType">Object name of the secondary transaction request. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="comments">Comment for the secondary transaction..</param>
        public SecondaryTransaction(string requestType = default(string), string storeId = default(string), string comments = default(string))
        {
            // to ensure "requestType" is required (not null)
            if (requestType == null)
            {
                throw new InvalidDataException("requestType is a required property for SecondaryTransaction and cannot be null");
            }
            else
            {
                this.RequestType = requestType;
            }

            this.StoreId = storeId;
            this.Comments = comments;
        }
        
        /// <summary>
        /// Object name of the secondary transaction request.
        /// </summary>
        /// <value>Object name of the secondary transaction request.</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// An optional outlet ID for clients that support multiple stores in the same developer app.
        /// </summary>
        /// <value>An optional outlet ID for clients that support multiple stores in the same developer app.</value>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Comment for the secondary transaction.
        /// </summary>
        /// <value>Comment for the secondary transaction.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecondaryTransaction {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(input as SecondaryTransaction);
        }

        /// <summary>
        /// Returns true if SecondaryTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of SecondaryTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecondaryTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // StoreId (string) maxLength
            if(this.StoreId != null && this.StoreId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreId, length must be less than 20.", new [] { "StoreId" });
            }

            yield break;
        }
    }

}
