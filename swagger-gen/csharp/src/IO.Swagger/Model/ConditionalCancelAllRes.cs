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
    /// Cancel all conditional order response
    /// </summary>
    [DataContract]
    public partial class ConditionalCancelAllRes :  IEquatable<ConditionalCancelAllRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalCancelAllRes" /> class.
        /// </summary>
        /// <param name="clOrdID">clOrdID.</param>
        /// <param name="userId">userId.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="side">side.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="price">price.</param>
        /// <param name="qty">qty.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="createType">createType.</param>
        /// <param name="cancelType">cancelType.</param>
        /// <param name="orderStatus">orderStatus.</param>
        /// <param name="leavesQty">leavesQty.</param>
        /// <param name="leavesValue">leavesValue.</param>
        /// <param name="crossSeq">crossSeq.</param>
        /// <param name="stopOrderType">stopOrderType.</param>
        /// <param name="triggerBy">triggerBy.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public ConditionalCancelAllRes(string clOrdID = default(string), decimal? userId = default(decimal?), string symbol = default(string), string side = default(string), string orderType = default(string), string price = default(string), decimal? qty = default(decimal?), string timeInForce = default(string), string createType = default(string), string cancelType = default(string), string orderStatus = default(string), decimal? leavesQty = default(decimal?), string leavesValue = default(string), decimal? crossSeq = default(decimal?), string stopOrderType = default(string), string triggerBy = default(string), string createdAt = default(string), string updatedAt = default(string))
        {
            this.ClOrdID = clOrdID;
            this.UserId = userId;
            this.Symbol = symbol;
            this.Side = side;
            this.OrderType = orderType;
            this.Price = price;
            this.Qty = qty;
            this.TimeInForce = timeInForce;
            this.CreateType = createType;
            this.CancelType = cancelType;
            this.OrderStatus = orderStatus;
            this.LeavesQty = leavesQty;
            this.LeavesValue = leavesValue;
            this.CrossSeq = crossSeq;
            this.StopOrderType = stopOrderType;
            this.TriggerBy = triggerBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Gets or Sets ClOrdID
        /// </summary>
        [DataMember(Name="clOrdID", EmitDefaultValue=false)]
        public string ClOrdID { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public decimal? UserId { get; set; }

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
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="order_type", EmitDefaultValue=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public decimal? Qty { get; set; }

        /// <summary>
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name="time_in_force", EmitDefaultValue=false)]
        public string TimeInForce { get; set; }

        /// <summary>
        /// Gets or Sets CreateType
        /// </summary>
        [DataMember(Name="create_type", EmitDefaultValue=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// Gets or Sets CancelType
        /// </summary>
        [DataMember(Name="cancel_type", EmitDefaultValue=false)]
        public string CancelType { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name="order_status", EmitDefaultValue=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets LeavesQty
        /// </summary>
        [DataMember(Name="leaves_qty", EmitDefaultValue=false)]
        public decimal? LeavesQty { get; set; }

        /// <summary>
        /// Gets or Sets LeavesValue
        /// </summary>
        [DataMember(Name="leaves_value", EmitDefaultValue=false)]
        public string LeavesValue { get; set; }

        /// <summary>
        /// Gets or Sets CrossSeq
        /// </summary>
        [DataMember(Name="cross_seq", EmitDefaultValue=false)]
        public decimal? CrossSeq { get; set; }

        /// <summary>
        /// Gets or Sets StopOrderType
        /// </summary>
        [DataMember(Name="stop_order_type", EmitDefaultValue=false)]
        public string StopOrderType { get; set; }

        /// <summary>
        /// Gets or Sets TriggerBy
        /// </summary>
        [DataMember(Name="trigger_by", EmitDefaultValue=false)]
        public string TriggerBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalCancelAllRes {\n");
            sb.Append("  ClOrdID: ").Append(ClOrdID).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  CreateType: ").Append(CreateType).Append("\n");
            sb.Append("  CancelType: ").Append(CancelType).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  LeavesQty: ").Append(LeavesQty).Append("\n");
            sb.Append("  LeavesValue: ").Append(LeavesValue).Append("\n");
            sb.Append("  CrossSeq: ").Append(CrossSeq).Append("\n");
            sb.Append("  StopOrderType: ").Append(StopOrderType).Append("\n");
            sb.Append("  TriggerBy: ").Append(TriggerBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ConditionalCancelAllRes);
        }

        /// <summary>
        /// Returns true if ConditionalCancelAllRes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionalCancelAllRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalCancelAllRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClOrdID == input.ClOrdID ||
                    (this.ClOrdID != null &&
                    this.ClOrdID.Equals(input.ClOrdID))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
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
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.CreateType == input.CreateType ||
                    (this.CreateType != null &&
                    this.CreateType.Equals(input.CreateType))
                ) && 
                (
                    this.CancelType == input.CancelType ||
                    (this.CancelType != null &&
                    this.CancelType.Equals(input.CancelType))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.LeavesQty == input.LeavesQty ||
                    (this.LeavesQty != null &&
                    this.LeavesQty.Equals(input.LeavesQty))
                ) && 
                (
                    this.LeavesValue == input.LeavesValue ||
                    (this.LeavesValue != null &&
                    this.LeavesValue.Equals(input.LeavesValue))
                ) && 
                (
                    this.CrossSeq == input.CrossSeq ||
                    (this.CrossSeq != null &&
                    this.CrossSeq.Equals(input.CrossSeq))
                ) && 
                (
                    this.StopOrderType == input.StopOrderType ||
                    (this.StopOrderType != null &&
                    this.StopOrderType.Equals(input.StopOrderType))
                ) && 
                (
                    this.TriggerBy == input.TriggerBy ||
                    (this.TriggerBy != null &&
                    this.TriggerBy.Equals(input.TriggerBy))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.ClOrdID != null)
                    hashCode = hashCode * 59 + this.ClOrdID.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.CreateType != null)
                    hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                if (this.CancelType != null)
                    hashCode = hashCode * 59 + this.CancelType.GetHashCode();
                if (this.OrderStatus != null)
                    hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.LeavesQty != null)
                    hashCode = hashCode * 59 + this.LeavesQty.GetHashCode();
                if (this.LeavesValue != null)
                    hashCode = hashCode * 59 + this.LeavesValue.GetHashCode();
                if (this.CrossSeq != null)
                    hashCode = hashCode * 59 + this.CrossSeq.GetHashCode();
                if (this.StopOrderType != null)
                    hashCode = hashCode * 59 + this.StopOrderType.GetHashCode();
                if (this.TriggerBy != null)
                    hashCode = hashCode * 59 + this.TriggerBy.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
