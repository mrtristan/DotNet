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
    /// Exchange rate response.
    /// </summary>
    [DataContract]
    public partial class ExchangeRateResponse :  IEquatable<ExchangeRateResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name="responseType", EmitDefaultValue=false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="ipgTransactionId">The response transaction ID..</param>
        /// <param name="requestTime">Time of the request..</param>
        /// <param name="inquiryRateId">Inquiry rate ID..</param>
        /// <param name="foreignCurrency">Foreign currency in alphabetic ISO 4217 currency code format..</param>
        /// <param name="foreignAmount">Foreign amount..</param>
        /// <param name="exchangeRate">Exchange rate..</param>
        /// <param name="dccOffered">Dcc offered..</param>
        /// <param name="exchangeRateSourceTimestamp">Exchange rate source timestamp..</param>
        /// <param name="expirationTimestamp">Expiration timestamp..</param>
        /// <param name="marginRatePercentage">Margin rate percentage..</param>
        /// <param name="exchangeRateSourceName">Exchange rate source name..</param>
        public ExchangeRateResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType responseType = default(ResponseType), string ipgTransactionId = default(string), string requestTime = default(string), string inquiryRateId = default(string), string foreignCurrency = default(string), string foreignAmount = default(string), string exchangeRate = default(string), string dccOffered = default(string), string exchangeRateSourceTimestamp = default(string), string expirationTimestamp = default(string), string marginRatePercentage = default(string), string exchangeRateSourceName = default(string))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.IpgTransactionId = ipgTransactionId;
            this.RequestTime = requestTime;
            this.InquiryRateId = inquiryRateId;
            this.ForeignCurrency = foreignCurrency;
            this.ForeignAmount = foreignAmount;
            this.ExchangeRate = exchangeRate;
            this.DccOffered = dccOffered;
            this.ExchangeRateSourceTimestamp = exchangeRateSourceTimestamp;
            this.ExpirationTimestamp = expirationTimestamp;
            this.MarginRatePercentage = marginRatePercentage;
            this.ExchangeRateSourceName = exchangeRateSourceName;
        }
        
        /// <summary>
        /// Echoes back the value in the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value in the request header for tracking.</value>
        [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Request identifier in API, can be used to request logs from the support team.
        /// </summary>
        /// <value>Request identifier in API, can be used to request logs from the support team.</value>
        [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
        public string ApiTraceId { get; set; }

        /// <summary>
        /// The response transaction ID.
        /// </summary>
        /// <value>The response transaction ID.</value>
        [DataMember(Name="ipgTransactionId", EmitDefaultValue=false)]
        public string IpgTransactionId { get; set; }

        /// <summary>
        /// Time of the request.
        /// </summary>
        /// <value>Time of the request.</value>
        [DataMember(Name="requestTime", EmitDefaultValue=false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// Inquiry rate ID.
        /// </summary>
        /// <value>Inquiry rate ID.</value>
        [DataMember(Name="inquiryRateId", EmitDefaultValue=false)]
        public string InquiryRateId { get; set; }

        /// <summary>
        /// Foreign currency in alphabetic ISO 4217 currency code format.
        /// </summary>
        /// <value>Foreign currency in alphabetic ISO 4217 currency code format.</value>
        [DataMember(Name="foreignCurrency", EmitDefaultValue=false)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// Foreign amount.
        /// </summary>
        /// <value>Foreign amount.</value>
        [DataMember(Name="foreignAmount", EmitDefaultValue=false)]
        public string ForeignAmount { get; set; }

        /// <summary>
        /// Exchange rate.
        /// </summary>
        /// <value>Exchange rate.</value>
        [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Dcc offered.
        /// </summary>
        /// <value>Dcc offered.</value>
        [DataMember(Name="dccOffered", EmitDefaultValue=false)]
        public string DccOffered { get; set; }

        /// <summary>
        /// Exchange rate source timestamp.
        /// </summary>
        /// <value>Exchange rate source timestamp.</value>
        [DataMember(Name="exchangeRateSourceTimestamp", EmitDefaultValue=false)]
        public string ExchangeRateSourceTimestamp { get; set; }

        /// <summary>
        /// Expiration timestamp.
        /// </summary>
        /// <value>Expiration timestamp.</value>
        [DataMember(Name="expirationTimestamp", EmitDefaultValue=false)]
        public string ExpirationTimestamp { get; set; }

        /// <summary>
        /// Margin rate percentage.
        /// </summary>
        /// <value>Margin rate percentage.</value>
        [DataMember(Name="marginRatePercentage", EmitDefaultValue=false)]
        public string MarginRatePercentage { get; set; }

        /// <summary>
        /// Exchange rate source name.
        /// </summary>
        /// <value>Exchange rate source name.</value>
        [DataMember(Name="exchangeRateSourceName", EmitDefaultValue=false)]
        public string ExchangeRateSourceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeRateResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  IpgTransactionId: ").Append(IpgTransactionId).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  InquiryRateId: ").Append(InquiryRateId).Append("\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  DccOffered: ").Append(DccOffered).Append("\n");
            sb.Append("  ExchangeRateSourceTimestamp: ").Append(ExchangeRateSourceTimestamp).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  MarginRatePercentage: ").Append(MarginRatePercentage).Append("\n");
            sb.Append("  ExchangeRateSourceName: ").Append(ExchangeRateSourceName).Append("\n");
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
            return this.Equals(input as ExchangeRateResponse);
        }

        /// <summary>
        /// Returns true if ExchangeRateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.ApiTraceId == input.ApiTraceId ||
                    (this.ApiTraceId != null &&
                    this.ApiTraceId.Equals(input.ApiTraceId))
                ) && 
                (
                    this.ResponseType == input.ResponseType ||
                    this.ResponseType.Equals(input.ResponseType)
                ) && 
                (
                    this.IpgTransactionId == input.IpgTransactionId ||
                    (this.IpgTransactionId != null &&
                    this.IpgTransactionId.Equals(input.IpgTransactionId))
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    (this.RequestTime != null &&
                    this.RequestTime.Equals(input.RequestTime))
                ) && 
                (
                    this.InquiryRateId == input.InquiryRateId ||
                    (this.InquiryRateId != null &&
                    this.InquiryRateId.Equals(input.InquiryRateId))
                ) && 
                (
                    this.ForeignCurrency == input.ForeignCurrency ||
                    (this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(input.ForeignCurrency))
                ) && 
                (
                    this.ForeignAmount == input.ForeignAmount ||
                    (this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(input.ForeignAmount))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.DccOffered == input.DccOffered ||
                    (this.DccOffered != null &&
                    this.DccOffered.Equals(input.DccOffered))
                ) && 
                (
                    this.ExchangeRateSourceTimestamp == input.ExchangeRateSourceTimestamp ||
                    (this.ExchangeRateSourceTimestamp != null &&
                    this.ExchangeRateSourceTimestamp.Equals(input.ExchangeRateSourceTimestamp))
                ) && 
                (
                    this.ExpirationTimestamp == input.ExpirationTimestamp ||
                    (this.ExpirationTimestamp != null &&
                    this.ExpirationTimestamp.Equals(input.ExpirationTimestamp))
                ) && 
                (
                    this.MarginRatePercentage == input.MarginRatePercentage ||
                    (this.MarginRatePercentage != null &&
                    this.MarginRatePercentage.Equals(input.MarginRatePercentage))
                ) && 
                (
                    this.ExchangeRateSourceName == input.ExchangeRateSourceName ||
                    (this.ExchangeRateSourceName != null &&
                    this.ExchangeRateSourceName.Equals(input.ExchangeRateSourceName))
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
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.ApiTraceId != null)
                    hashCode = hashCode * 59 + this.ApiTraceId.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseType.GetHashCode();
                if (this.IpgTransactionId != null)
                    hashCode = hashCode * 59 + this.IpgTransactionId.GetHashCode();
                if (this.RequestTime != null)
                    hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                if (this.InquiryRateId != null)
                    hashCode = hashCode * 59 + this.InquiryRateId.GetHashCode();
                if (this.ForeignCurrency != null)
                    hashCode = hashCode * 59 + this.ForeignCurrency.GetHashCode();
                if (this.ForeignAmount != null)
                    hashCode = hashCode * 59 + this.ForeignAmount.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.DccOffered != null)
                    hashCode = hashCode * 59 + this.DccOffered.GetHashCode();
                if (this.ExchangeRateSourceTimestamp != null)
                    hashCode = hashCode * 59 + this.ExchangeRateSourceTimestamp.GetHashCode();
                if (this.ExpirationTimestamp != null)
                    hashCode = hashCode * 59 + this.ExpirationTimestamp.GetHashCode();
                if (this.MarginRatePercentage != null)
                    hashCode = hashCode * 59 + this.MarginRatePercentage.GetHashCode();
                if (this.ExchangeRateSourceName != null)
                    hashCode = hashCode * 59 + this.ExchangeRateSourceName.GetHashCode();
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
