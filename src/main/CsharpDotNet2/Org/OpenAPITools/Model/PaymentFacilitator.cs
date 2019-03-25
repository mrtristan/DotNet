using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment Facilitator details provided by the Merchant.
  /// </summary>
  [DataContract]
  public class PaymentFacilitator {
    /// <summary>
    /// External Merchant ID of the payment facilitator
    /// </summary>
    /// <value>External Merchant ID of the payment facilitator</value>
    [DataMember(Name="externalMerchantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalMerchantId")]
    public string ExternalMerchantId { get; set; }

    /// <summary>
    /// Payment Facilitator ID supplied during boarding
    /// </summary>
    /// <value>Payment Facilitator ID supplied during boarding</value>
    [DataMember(Name="paymentFacilitatorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentFacilitatorId")]
    public string PaymentFacilitatorId { get; set; }

    /// <summary>
    /// Independent Sales Organization (ISO) ID provided by Mastercard
    /// </summary>
    /// <value>Independent Sales Organization (ISO) ID provided by Mastercard</value>
    [DataMember(Name="saleOrganizationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saleOrganizationId")]
    public string SaleOrganizationId { get; set; }

    /// <summary>
    /// Payment facilitator Name
    /// </summary>
    /// <value>Payment facilitator Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SubMerchantData
    /// </summary>
    [DataMember(Name="subMerchantData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subMerchantData")]
    public SubMerchantData SubMerchantData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentFacilitator {\n");
      sb.Append("  ExternalMerchantId: ").Append(ExternalMerchantId).Append("\n");
      sb.Append("  PaymentFacilitatorId: ").Append(PaymentFacilitatorId).Append("\n");
      sb.Append("  SaleOrganizationId: ").Append(SaleOrganizationId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SubMerchantData: ").Append(SubMerchantData).Append("\n");
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