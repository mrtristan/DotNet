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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request to create a gateway schedule. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    [JsonSubtypes.KnownSubType(typeof(PaymentMethodPaymentSchedulesRequest), "PaymentMethodPaymentSchedulesRequest")]
    [JsonSubtypes.KnownSubType(typeof(ReferencedOrderPaymentSchedulesRequest), "ReferencedOrderPaymentSchedulesRequest")]
    public partial class PaymentSchedulesRequest :  IEquatable<PaymentSchedulesRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TransactionOrigin
        /// </summary>
        [DataMember(Name="transactionOrigin", EmitDefaultValue=false)]
        public TransactionOrigin? TransactionOrigin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSchedulesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentSchedulesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSchedulesRequest" /> class.
        /// </summary>
        /// <param name="requestType">Object name of the payment schedules request. (required).</param>
        /// <param name="storeId">Store ID number..</param>
        /// <param name="startDate">Date of mandate signature. (required).</param>
        /// <param name="numberOfPayments">Number of times the recurring payment will process..</param>
        /// <param name="maximumFailures">Number of failures that can be encountered before re-tries cease..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="purchaseOrderNumber">Purchase order number..</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="dynamicMerchantName">Dynamic merchant name for the cardholder&#39;s statement..</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="clientLocale">clientLocale.</param>
        /// <param name="orderId">Client order ID if supplied by client..</param>
        /// <param name="billing">billing.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="comments">User supplied comments..</param>
        public PaymentSchedulesRequest(string requestType = default(string), string storeId = default(string), DateTime startDate = default(DateTime), int numberOfPayments = default(int), int maximumFailures = default(int), string invoiceNumber = default(string), string purchaseOrderNumber = default(string), TransactionOrigin transactionOrigin = default(TransactionOrigin), string dynamicMerchantName = default(string), Frequency frequency = default(Frequency), Amount transactionAmount = default(Amount), ClientLocale clientLocale = default(ClientLocale), string orderId = default(string), Billing billing = default(Billing), Shipping shipping = default(Shipping), string comments = default(string))
        {
            // to ensure "requestType" is required (not null)
            if (requestType == null)
            {
                throw new InvalidDataException("requestType is a required property for PaymentSchedulesRequest and cannot be null");
            }
            else
            {
                this.RequestType = requestType;
            }

            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for PaymentSchedulesRequest and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }

            // to ensure "frequency" is required (not null)
            if (frequency == null)
            {
                throw new InvalidDataException("frequency is a required property for PaymentSchedulesRequest and cannot be null");
            }
            else
            {
                this.Frequency = frequency;
            }

            // to ensure "transactionAmount" is required (not null)
            if (transactionAmount == null)
            {
                throw new InvalidDataException("transactionAmount is a required property for PaymentSchedulesRequest and cannot be null");
            }
            else
            {
                this.TransactionAmount = transactionAmount;
            }

            this.StoreId = storeId;
            this.NumberOfPayments = numberOfPayments;
            this.MaximumFailures = maximumFailures;
            this.InvoiceNumber = invoiceNumber;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.TransactionOrigin = transactionOrigin;
            this.DynamicMerchantName = dynamicMerchantName;
            this.ClientLocale = clientLocale;
            this.OrderId = orderId;
            this.Billing = billing;
            this.Shipping = shipping;
            this.Comments = comments;
        }
        
        /// <summary>
        /// Object name of the payment schedules request.
        /// </summary>
        /// <value>Object name of the payment schedules request.</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// Store ID number.
        /// </summary>
        /// <value>Store ID number.</value>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Date of mandate signature.
        /// </summary>
        /// <value>Date of mandate signature.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Number of times the recurring payment will process.
        /// </summary>
        /// <value>Number of times the recurring payment will process.</value>
        [DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
        public int NumberOfPayments { get; set; }

        /// <summary>
        /// Number of failures that can be encountered before re-tries cease.
        /// </summary>
        /// <value>Number of failures that can be encountered before re-tries cease.</value>
        [DataMember(Name="maximumFailures", EmitDefaultValue=false)]
        public int MaximumFailures { get; set; }

        /// <summary>
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Purchase order number.
        /// </summary>
        /// <value>Purchase order number.</value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Dynamic merchant name for the cardholder&#39;s statement.
        /// </summary>
        /// <value>Dynamic merchant name for the cardholder&#39;s statement.</value>
        [DataMember(Name="dynamicMerchantName", EmitDefaultValue=false)]
        public string DynamicMerchantName { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public Frequency Frequency { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets ClientLocale
        /// </summary>
        [DataMember(Name="clientLocale", EmitDefaultValue=false)]
        public ClientLocale ClientLocale { get; set; }

        /// <summary>
        /// Client order ID if supplied by client.
        /// </summary>
        /// <value>Client order ID if supplied by client.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public Billing Billing { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// User supplied comments.
        /// </summary>
        /// <value>User supplied comments.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSchedulesRequest {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
            sb.Append("  MaximumFailures: ").Append(MaximumFailures).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
            sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
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
            return this.Equals(input as PaymentSchedulesRequest);
        }

        /// <summary>
        /// Returns true if PaymentSchedulesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSchedulesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSchedulesRequest input)
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.NumberOfPayments == input.NumberOfPayments ||
                    this.NumberOfPayments.Equals(input.NumberOfPayments)
                ) && 
                (
                    this.MaximumFailures == input.MaximumFailures ||
                    this.MaximumFailures.Equals(input.MaximumFailures)
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.TransactionOrigin == input.TransactionOrigin ||
                    this.TransactionOrigin.Equals(input.TransactionOrigin)
                ) && 
                (
                    this.DynamicMerchantName == input.DynamicMerchantName ||
                    (this.DynamicMerchantName != null &&
                    this.DynamicMerchantName.Equals(input.DynamicMerchantName))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.ClientLocale == input.ClientLocale ||
                    (this.ClientLocale != null &&
                    this.ClientLocale.Equals(input.ClientLocale))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Billing == input.Billing ||
                    (this.Billing != null &&
                    this.Billing.Equals(input.Billing))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfPayments.GetHashCode();
                hashCode = hashCode * 59 + this.MaximumFailures.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionOrigin.GetHashCode();
                if (this.DynamicMerchantName != null)
                    hashCode = hashCode * 59 + this.DynamicMerchantName.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.ClientLocale != null)
                    hashCode = hashCode * 59 + this.ClientLocale.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
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

            // NumberOfPayments (int) maximum
            if(this.NumberOfPayments > (int)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfPayments, must be a value less than or equal to 999.", new [] { "NumberOfPayments" });
            }

            // NumberOfPayments (int) minimum
            if(this.NumberOfPayments < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumberOfPayments, must be a value greater than or equal to 1.", new [] { "NumberOfPayments" });
            }

            // MaximumFailures (int) maximum
            if(this.MaximumFailures > (int)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumFailures, must be a value less than or equal to 999.", new [] { "MaximumFailures" });
            }

            // MaximumFailures (int) minimum
            if(this.MaximumFailures < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumFailures, must be a value greater than or equal to 1.", new [] { "MaximumFailures" });
            }

            yield break;
        }
    }

}
