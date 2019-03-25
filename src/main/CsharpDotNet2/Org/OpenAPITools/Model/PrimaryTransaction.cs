using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Model for primary financial transactions
  /// </summary>
  [DataContract]
  public class PrimaryTransaction {
    /// <summary>
    /// Gets or Sets TransactionType
    /// </summary>
    [DataMember(Name="transactionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionType")]
    public TransactionType TransactionType { get; set; }

    /// <summary>
    /// An optional outlet ID for clients that support multiple stores in the same app.
    /// </summary>
    /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// The unique merchant transaction ID from the Request header, if supplied.
    /// </summary>
    /// <value>The unique merchant transaction ID from the Request header, if supplied.</value>
    [DataMember(Name="merchantTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantTransactionId")]
    public string MerchantTransactionId { get; set; }

    /// <summary>
    /// Gets or Sets TransactionOrigin
    /// </summary>
    [DataMember(Name="transactionOrigin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionOrigin")]
    public TransactionOrigin TransactionOrigin { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethod
    /// </summary>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public PaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public Order Order { get; set; }

    /// <summary>
    /// Required for some payment methods (for example, Klarna)
    /// </summary>
    /// <value>Required for some payment methods (for example, Klarna)</value>
    [DataMember(Name="basketItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basketItems")]
    public List<BasketItem> BasketItems { get; set; }

    /// <summary>
    /// Gets or Sets SplitShipment
    /// </summary>
    [DataMember(Name="splitShipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splitShipment")]
    public SplitShipment SplitShipment { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalDetails
    /// </summary>
    [DataMember(Name="additionalDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalDetails")]
    public PrimaryTransactionAdditionalDetails AdditionalDetails { get; set; }

    /// <summary>
    /// Gets or Sets IndustrySpecificExtensions
    /// </summary>
    [DataMember(Name="industrySpecificExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "industrySpecificExtensions")]
    public IndustrySpecificExtensions IndustrySpecificExtensions { get; set; }

    /// <summary>
    /// Gets or Sets StoredCredentials
    /// </summary>
    [DataMember(Name="storedCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedCredentials")]
    public StoredCredential StoredCredentials { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseCard
    /// </summary>
    [DataMember(Name="purchaseCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchaseCard")]
    public PurchaseCards PurchaseCard { get; set; }

    /// <summary>
    /// Gets or Sets PaymentFacilitator
    /// </summary>
    [DataMember(Name="paymentFacilitator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentFacilitator")]
    public PaymentFacilitator PaymentFacilitator { get; set; }

    /// <summary>
    /// Gets or Sets SoftDescriptor
    /// </summary>
    [DataMember(Name="softDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "softDescriptor")]
    public SoftDescriptor SoftDescriptor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrimaryTransaction {\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
      sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  BasketItems: ").Append(BasketItems).Append("\n");
      sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
      sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
      sb.Append("  IndustrySpecificExtensions: ").Append(IndustrySpecificExtensions).Append("\n");
      sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
      sb.Append("  PurchaseCard: ").Append(PurchaseCard).Append("\n");
      sb.Append("  PaymentFacilitator: ").Append(PaymentFacilitator).Append("\n");
      sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}