/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Get the last funding fee
    /// </summary>
    [DataContract]
    public partial class FundingFeeRes :  IEquatable<FundingFeeRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingFeeRes" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="side">side.</param>
        /// <param name="size">size.</param>
        /// <param name="fundingRate">fundingRate.</param>
        /// <param name="execFee">execFee.</param>
        /// <param name="execTimestamp">execTimestamp.</param>
        public FundingFeeRes(string symbol = default(string), string side = default(string), decimal? size = default(decimal?), string fundingRate = default(string), double? execFee = default(double?), decimal? execTimestamp = default(decimal?))
        {
            this.Symbol = symbol;
            this.Side = side;
            this.Size = size;
            this.FundingRate = fundingRate;
            this.ExecFee = execFee;
            this.ExecTimestamp = execTimestamp;
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Gets or Sets FundingRate
        /// </summary>
        [DataMember(Name="funding_rate", EmitDefaultValue=false)]
        public string FundingRate { get; set; }

        /// <summary>
        /// Gets or Sets ExecFee
        /// </summary>
        [DataMember(Name="exec_fee", EmitDefaultValue=false)]
        public double? ExecFee { get; set; }

        /// <summary>
        /// Gets or Sets ExecTimestamp
        /// </summary>
        [DataMember(Name="exec_timestamp", EmitDefaultValue=false)]
        public decimal? ExecTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingFeeRes {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  FundingRate: ").Append(FundingRate).Append("\n");
            sb.Append("  ExecFee: ").Append(ExecFee).Append("\n");
            sb.Append("  ExecTimestamp: ").Append(ExecTimestamp).Append("\n");
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
            return this.Equals(input as FundingFeeRes);
        }

        /// <summary>
        /// Returns true if FundingFeeRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingFeeRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingFeeRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.FundingRate == input.FundingRate ||
                    (this.FundingRate != null &&
                    this.FundingRate.Equals(input.FundingRate))
                ) && 
                (
                    this.ExecFee == input.ExecFee ||
                    (this.ExecFee != null &&
                    this.ExecFee.Equals(input.ExecFee))
                ) && 
                (
                    this.ExecTimestamp == input.ExecTimestamp ||
                    (this.ExecTimestamp != null &&
                    this.ExecTimestamp.Equals(input.ExecTimestamp))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.FundingRate != null)
                    hashCode = hashCode * 59 + this.FundingRate.GetHashCode();
                if (this.ExecFee != null)
                    hashCode = hashCode * 59 + this.ExecFee.GetHashCode();
                if (this.ExecTimestamp != null)
                    hashCode = hashCode * 59 + this.ExecTimestamp.GetHashCode();
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
