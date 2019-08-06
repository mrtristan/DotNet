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
    /// PurchaseCardsLevel3LineItems
    /// </summary>
    [DataContract]
    public partial class PurchaseCardsLevel3LineItems :  IEquatable<PurchaseCardsLevel3LineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCardsLevel3LineItems" /> class.
        /// </summary>
        /// <param name="commodityCode">The commodity code used to classify the item purchased..</param>
        /// <param name="productCode">Merchant product identifier/the Universal Product Code (UPC) of the item purchased..</param>
        /// <param name="description">The description..</param>
        /// <param name="quantity">The quantity..</param>
        /// <param name="unitMeasure">The unit of measure..</param>
        /// <param name="unitPrice">Rate amount in 3 decimal 12 bytes total digit..</param>
        /// <param name="vatAmountAndRate">vatAmountAndRate.</param>
        /// <param name="discountAmountAndRate">discountAmountAndRate.</param>
        /// <param name="lineItemTotal">Rate amount in 3 decimal 12 bytes total digit..</param>
        public PurchaseCardsLevel3LineItems(string commodityCode = default(string), string productCode = default(string), string description = default(string), int quantity = default(int), string unitMeasure = default(string), decimal unitPrice = default(decimal), AdditionalAmountRate vatAmountAndRate = default(AdditionalAmountRate), AdditionalAmountRate discountAmountAndRate = default(AdditionalAmountRate), decimal lineItemTotal = default(decimal))
        {
            this.CommodityCode = commodityCode;
            this.ProductCode = productCode;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitMeasure = unitMeasure;
            this.UnitPrice = unitPrice;
            this.VatAmountAndRate = vatAmountAndRate;
            this.DiscountAmountAndRate = discountAmountAndRate;
            this.LineItemTotal = lineItemTotal;
        }
        
        /// <summary>
        /// The commodity code used to classify the item purchased.
        /// </summary>
        /// <value>The commodity code used to classify the item purchased.</value>
        [DataMember(Name="commodityCode", EmitDefaultValue=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// Merchant product identifier/the Universal Product Code (UPC) of the item purchased.
        /// </summary>
        /// <value>Merchant product identifier/the Universal Product Code (UPC) of the item purchased.</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The unit of measure.
        /// </summary>
        /// <value>The unit of measure.</value>
        [DataMember(Name="unitMeasure", EmitDefaultValue=false)]
        public string UnitMeasure { get; set; }

        /// <summary>
        /// Rate amount in 3 decimal 12 bytes total digit.
        /// </summary>
        /// <value>Rate amount in 3 decimal 12 bytes total digit.</value>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountAndRate
        /// </summary>
        [DataMember(Name="vatAmountAndRate", EmitDefaultValue=false)]
        public AdditionalAmountRate VatAmountAndRate { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmountAndRate
        /// </summary>
        [DataMember(Name="discountAmountAndRate", EmitDefaultValue=false)]
        public AdditionalAmountRate DiscountAmountAndRate { get; set; }

        /// <summary>
        /// Rate amount in 3 decimal 12 bytes total digit.
        /// </summary>
        /// <value>Rate amount in 3 decimal 12 bytes total digit.</value>
        [DataMember(Name="lineItemTotal", EmitDefaultValue=false)]
        public decimal LineItemTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseCardsLevel3LineItems {\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitMeasure: ").Append(UnitMeasure).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  VatAmountAndRate: ").Append(VatAmountAndRate).Append("\n");
            sb.Append("  DiscountAmountAndRate: ").Append(DiscountAmountAndRate).Append("\n");
            sb.Append("  LineItemTotal: ").Append(LineItemTotal).Append("\n");
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
            return this.Equals(input as PurchaseCardsLevel3LineItems);
        }

        /// <summary>
        /// Returns true if PurchaseCardsLevel3LineItems instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseCardsLevel3LineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseCardsLevel3LineItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommodityCode == input.CommodityCode ||
                    (this.CommodityCode != null &&
                    this.CommodityCode.Equals(input.CommodityCode))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.UnitMeasure == input.UnitMeasure ||
                    (this.UnitMeasure != null &&
                    this.UnitMeasure.Equals(input.UnitMeasure))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.VatAmountAndRate == input.VatAmountAndRate ||
                    (this.VatAmountAndRate != null &&
                    this.VatAmountAndRate.Equals(input.VatAmountAndRate))
                ) && 
                (
                    this.DiscountAmountAndRate == input.DiscountAmountAndRate ||
                    (this.DiscountAmountAndRate != null &&
                    this.DiscountAmountAndRate.Equals(input.DiscountAmountAndRate))
                ) && 
                (
                    this.LineItemTotal == input.LineItemTotal ||
                    this.LineItemTotal.Equals(input.LineItemTotal)
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
                if (this.CommodityCode != null)
                    hashCode = hashCode * 59 + this.CommodityCode.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitMeasure != null)
                    hashCode = hashCode * 59 + this.UnitMeasure.GetHashCode();
                hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.VatAmountAndRate != null)
                    hashCode = hashCode * 59 + this.VatAmountAndRate.GetHashCode();
                if (this.DiscountAmountAndRate != null)
                    hashCode = hashCode * 59 + this.DiscountAmountAndRate.GetHashCode();
                hashCode = hashCode * 59 + this.LineItemTotal.GetHashCode();
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
            // CommodityCode (string) maxLength
            if(this.CommodityCode != null && this.CommodityCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommodityCode, length must be less than 4.", new [] { "CommodityCode" });
            }

            // ProductCode (string) maxLength
            if(this.ProductCode != null && this.ProductCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, length must be less than 20.", new [] { "ProductCode" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 30.", new [] { "Description" });
            }

            // Quantity (int) minimum
            if(this.Quantity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            // UnitMeasure (string) maxLength
            if(this.UnitMeasure != null && this.UnitMeasure.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitMeasure, length must be less than 3.", new [] { "UnitMeasure" });
            }

            yield break;
        }
    }

}
