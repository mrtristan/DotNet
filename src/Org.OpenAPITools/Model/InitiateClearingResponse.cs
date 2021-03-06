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
    /// InitiateClearingResponse
    /// </summary>
    [DataContract]
    public partial class InitiateClearingResponse : IEquatable<InitiateClearingResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name = "responseType", EmitDefaultValue = false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.
        /// </summary>
        /// <value>Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum PROCESSINGFAILED for value: PROCESSING_FAILED
            /// </summary>
            [EnumMember(Value = "PROCESSING_FAILED")]
            PROCESSINGFAILED = 2,

            /// <summary>
            /// Enum FAILURE for value: FAILURE
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            FAILURE = 3

        }

        /// <summary>
        /// Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.
        /// </summary>
        /// <value>Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.</value>
        [DataMember(Name = "requestStatus", EmitDefaultValue = false)]
        public RequestStatusEnum? RequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateClearingResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="requestStatus">Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details..</param>
        /// <param name="clearingDetails">clearingDetails.</param>
        /// <param name="endpointResponses">The array holds response information of the involved endpoints..</param>
        public InitiateClearingResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType? responseType = null, RequestStatusEnum? requestStatus = null, ClearingDetails clearingDetails = default(ClearingDetails), List<EndpointResponse> endpointResponses = default(List<EndpointResponse>))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.RequestStatus = requestStatus;
            this.ClearingDetails = clearingDetails;
            this.EndpointResponses = endpointResponses;
        }

        /// <summary>
        /// Echoes back the value in the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value in the request header for tracking.</value>
        [DataMember(Name = "clientRequestId", EmitDefaultValue = false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Request identifier in API, can be used to request logs from the support team.
        /// </summary>
        /// <value>Request identifier in API, can be used to request logs from the support team.</value>
        [DataMember(Name = "apiTraceId", EmitDefaultValue = false)]
        public string ApiTraceId { get; set; }

        /// <summary>
        /// Gets or Sets ClearingDetails
        /// </summary>
        [DataMember(Name = "clearingDetails", EmitDefaultValue = false)]
        public ClearingDetails ClearingDetails { get; set; }

        /// <summary>
        /// The array holds response information of the involved endpoints.
        /// </summary>
        /// <value>The array holds response information of the involved endpoints.</value>
        [DataMember(Name = "endpointResponses", EmitDefaultValue = false)]
        public List<EndpointResponse> EndpointResponses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateClearingResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  ClearingDetails: ").Append(ClearingDetails).Append("\n");
            sb.Append("  EndpointResponses: ").Append(EndpointResponses).Append("\n");
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
            return this.Equals(input as InitiateClearingResponse);
        }

        /// <summary>
        /// Returns true if InitiateClearingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateClearingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateClearingResponse input)
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
                    this.RequestStatus == input.RequestStatus ||
                    this.RequestStatus.Equals(input.RequestStatus)
                ) && 
                (
                    this.ClearingDetails == input.ClearingDetails ||
                    (this.ClearingDetails != null &&
                    this.ClearingDetails.Equals(input.ClearingDetails))
                ) && 
                (
                    this.EndpointResponses == input.EndpointResponses ||
                    this.EndpointResponses != null &&
                    input.EndpointResponses != null &&
                    this.EndpointResponses.SequenceEqual(input.EndpointResponses)
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
                hashCode = hashCode * 59 + this.RequestStatus.GetHashCode();
                if (this.ClearingDetails != null)
                    hashCode = hashCode * 59 + this.ClearingDetails.GetHashCode();
                if (this.EndpointResponses != null)
                    hashCode = hashCode * 59 + this.EndpointResponses.GetHashCode();
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
