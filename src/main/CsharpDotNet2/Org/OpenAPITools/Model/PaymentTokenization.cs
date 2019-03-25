using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// this object contains payment tokenization details
  /// </summary>
  [DataContract]
  public class PaymentTokenization {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Client supplied Payment Token value
    /// </summary>
    /// <value>Client supplied Payment Token value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// One time or reusable token
    /// </summary>
    /// <value>One time or reusable token</value>
    [DataMember(Name="reusable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reusable")]
    public bool? Reusable { get; set; }

    /// <summary>
    /// Decline duplicate payment info if client token is supplied
    /// </summary>
    /// <value>Decline duplicate payment info if client token is supplied</value>
    [DataMember(Name="declineDuplicates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declineDuplicates")]
    public bool? DeclineDuplicates { get; set; }

    /// <summary>
    /// The last 4 payment card numbers
    /// </summary>
    /// <value>The last 4 payment card numbers</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// Only for tokenization with payment
    /// </summary>
    /// <value>Only for tokenization with payment</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Only for tokenization with payment
    /// </summary>
    /// <value>Only for tokenization with payment</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets AccountVerification
    /// </summary>
    [DataMember(Name="accountVerification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountVerification")]
    public bool? AccountVerification { get; set; }

    /// <summary>
    /// Card Verification Value/Number
    /// </summary>
    /// <value>Card Verification Value/Number</value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentTokenization {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Reusable: ").Append(Reusable).Append("\n");
      sb.Append("  DeclineDuplicates: ").Append(DeclineDuplicates).Append("\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  AccountVerification: ").Append(AccountVerification).Append("\n");
      sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
