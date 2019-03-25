using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Customer Address Fields associated with billing.
  /// </summary>
  [DataContract]
  public class BillingAddress {
    /// <summary>
    /// First name.
    /// </summary>
    /// <value>First name.</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Last name.
    /// </summary>
    /// <value>Last name.</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Middle name.
    /// </summary>
    /// <value>Middle name.</value>
    [DataMember(Name="middleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middleName")]
    public string MiddleName { get; set; }

    /// <summary>
    /// Street Address 1. This field is required if the parent object is present.
    /// </summary>
    /// <value>Street Address 1. This field is required if the parent object is present.</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// Street Address 2.
    /// </summary>
    /// <value>Street Address 2.</value>
    [DataMember(Name="street2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street2")]
    public string Street2 { get; set; }

    /// <summary>
    /// State or Province.
    /// </summary>
    /// <value>State or Province.</value>
    [DataMember(Name="stateProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateProvince")]
    public string StateProvince { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    /// <value>City.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Country.
    /// </summary>
    /// <value>Country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public BillingAddressPhone Phone { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    [DataMember(Name="zipPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipPostalCode")]
    public string ZipPostalCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingAddress {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  Street2: ").Append(Street2).Append("\n");
      sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  ZipPostalCode: ").Append(ZipPostalCode).Append("\n");
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