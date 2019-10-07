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
    /// Details related to updated account information.
    /// </summary>
    [DataContract]
    public partial class AccountUpdaterResponse :  IEquatable<AccountUpdaterResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUpdaterResponse" /> class.
        /// </summary>
        /// <param name="updatedCard">Account updater replacement PAN or TransArmor token..</param>
        /// <param name="updatedToken">Updated value of token..</param>
        /// <param name="updatedExpirationDate">New account number expiration date in MMYY format..</param>
        /// <param name="updatedAccountStatus">Status of the updated account. An account may have closed (C), the expiry date may have changed (E), the account may have changed (A), or the cardholder should be contacted (Q)..</param>
        /// <param name="updatedAccountErrorCode">Code for the error encountered when updating account..</param>
        public AccountUpdaterResponse(string updatedCard = default(string), string updatedToken = default(string), string updatedExpirationDate = default(string), string updatedAccountStatus = default(string), string updatedAccountErrorCode = default(string))
        {
            this.UpdatedCard = updatedCard;
            this.UpdatedToken = updatedToken;
            this.UpdatedExpirationDate = updatedExpirationDate;
            this.UpdatedAccountStatus = updatedAccountStatus;
            this.UpdatedAccountErrorCode = updatedAccountErrorCode;
        }
        
        /// <summary>
        /// Account updater replacement PAN or TransArmor token.
        /// </summary>
        /// <value>Account updater replacement PAN or TransArmor token.</value>
        [DataMember(Name="updatedCard", EmitDefaultValue=false)]
        public string UpdatedCard { get; set; }

        /// <summary>
        /// Updated value of token.
        /// </summary>
        /// <value>Updated value of token.</value>
        [DataMember(Name="updatedToken", EmitDefaultValue=false)]
        public string UpdatedToken { get; set; }

        /// <summary>
        /// New account number expiration date in MMYY format.
        /// </summary>
        /// <value>New account number expiration date in MMYY format.</value>
        [DataMember(Name="updatedExpirationDate", EmitDefaultValue=false)]
        public string UpdatedExpirationDate { get; set; }

        /// <summary>
        /// Status of the updated account. An account may have closed (C), the expiry date may have changed (E), the account may have changed (A), or the cardholder should be contacted (Q).
        /// </summary>
        /// <value>Status of the updated account. An account may have closed (C), the expiry date may have changed (E), the account may have changed (A), or the cardholder should be contacted (Q).</value>
        [DataMember(Name="updatedAccountStatus", EmitDefaultValue=false)]
        public string UpdatedAccountStatus { get; set; }

        /// <summary>
        /// Code for the error encountered when updating account.
        /// </summary>
        /// <value>Code for the error encountered when updating account.</value>
        [DataMember(Name="updatedAccountErrorCode", EmitDefaultValue=false)]
        public string UpdatedAccountErrorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountUpdaterResponse {\n");
            sb.Append("  UpdatedCard: ").Append(UpdatedCard).Append("\n");
            sb.Append("  UpdatedToken: ").Append(UpdatedToken).Append("\n");
            sb.Append("  UpdatedExpirationDate: ").Append(UpdatedExpirationDate).Append("\n");
            sb.Append("  UpdatedAccountStatus: ").Append(UpdatedAccountStatus).Append("\n");
            sb.Append("  UpdatedAccountErrorCode: ").Append(UpdatedAccountErrorCode).Append("\n");
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
            return this.Equals(input as AccountUpdaterResponse);
        }

        /// <summary>
        /// Returns true if AccountUpdaterResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountUpdaterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUpdaterResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdatedCard == input.UpdatedCard ||
                    (this.UpdatedCard != null &&
                    this.UpdatedCard.Equals(input.UpdatedCard))
                ) && 
                (
                    this.UpdatedToken == input.UpdatedToken ||
                    (this.UpdatedToken != null &&
                    this.UpdatedToken.Equals(input.UpdatedToken))
                ) && 
                (
                    this.UpdatedExpirationDate == input.UpdatedExpirationDate ||
                    (this.UpdatedExpirationDate != null &&
                    this.UpdatedExpirationDate.Equals(input.UpdatedExpirationDate))
                ) && 
                (
                    this.UpdatedAccountStatus == input.UpdatedAccountStatus ||
                    (this.UpdatedAccountStatus != null &&
                    this.UpdatedAccountStatus.Equals(input.UpdatedAccountStatus))
                ) && 
                (
                    this.UpdatedAccountErrorCode == input.UpdatedAccountErrorCode ||
                    (this.UpdatedAccountErrorCode != null &&
                    this.UpdatedAccountErrorCode.Equals(input.UpdatedAccountErrorCode))
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
                if (this.UpdatedCard != null)
                    hashCode = hashCode * 59 + this.UpdatedCard.GetHashCode();
                if (this.UpdatedToken != null)
                    hashCode = hashCode * 59 + this.UpdatedToken.GetHashCode();
                if (this.UpdatedExpirationDate != null)
                    hashCode = hashCode * 59 + this.UpdatedExpirationDate.GetHashCode();
                if (this.UpdatedAccountStatus != null)
                    hashCode = hashCode * 59 + this.UpdatedAccountStatus.GetHashCode();
                if (this.UpdatedAccountErrorCode != null)
                    hashCode = hashCode * 59 + this.UpdatedAccountErrorCode.GetHashCode();
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
