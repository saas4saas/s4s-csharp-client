/* 
 * s4s-full
 *
 * description
 *
 * OpenAPI spec version: stable
 * Contact: rui.p.oliveira@impactinglabs.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model description
    /// </summary>
    [DataContract]
    public partial class Plan :  IEquatable<Plan>
    {
        /// <summary>
        /// Gets or Sets Typ
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypEnum
        {
            
            /// <summary>
            /// Enum OneTimePay for "OneTimePay"
            /// </summary>
            [EnumMember(Value = "OneTimePay")]
            OneTimePay,
            
            /// <summary>
            /// Enum Subscription for "Subscription"
            /// </summary>
            [EnumMember(Value = "Subscription")]
            Subscription
        }

        /// <summary>
        /// Gets or Sets VariableCostWhenPay
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VariableCostWhenPayEnum
        {
            
            /// <summary>
            /// Enum EachEndPeriod for "EachEndPeriod"
            /// </summary>
            [EnumMember(Value = "EachEndPeriod")]
            EachEndPeriod,
            
            /// <summary>
            /// Enum EachMonth for "EachMonth"
            /// </summary>
            [EnumMember(Value = "EachMonth")]
            EachMonth,
            
            /// <summary>
            /// Enum EachWeek for "EachWeek"
            /// </summary>
            [EnumMember(Value = "EachWeek")]
            EachWeek,
            
            /// <summary>
            /// Enum EachDay for "EachDay"
            /// </summary>
            [EnumMember(Value = "EachDay")]
            EachDay
        }

        /// <summary>
        /// Gets or Sets Typ
        /// </summary>
        [DataMember(Name="typ", EmitDefaultValue=false)]
        public TypEnum? Typ { get; set; }
        /// <summary>
        /// Gets or Sets VariableCostWhenPay
        /// </summary>
        [DataMember(Name="variableCostWhenPay", EmitDefaultValue=false)]
        public VariableCostWhenPayEnum? VariableCostWhenPay { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="VariableCost">VariableCost.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OneTimePay">OneTimePay.</param>
        /// <param name="HasVariableCost">HasVariableCost.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="BeforePlanId">BeforePlanId.</param>
        /// <param name="OnExpiratyNextPlanId">OnExpiratyNextPlanId.</param>
        /// <param name="UpgradeLevel">UpgradeLevel.</param>
        /// <param name="RequirePaymentMethod">RequirePaymentMethod.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PackId">PackId.</param>
        /// <param name="Typ">Typ.</param>
        /// <param name="UiOrder">UiOrder.</param>
        /// <param name="Family">Family.</param>
        /// <param name="UiVisible">UiVisible.</param>
        /// <param name="Withfamily">Withfamily.</param>
        /// <param name="VariableCostWhenPay">VariableCostWhenPay.</param>
        /// <param name="OneTimePlan">OneTimePlan.</param>
        public Plan(Dictionary<string, VariableCost> VariableCost = null, string Name = null, OneTimePay OneTimePay = null, bool? HasVariableCost = null, string Description = null, Subscription Subscription = null, string BeforePlanId = null, string OnExpiratyNextPlanId = null, int? UpgradeLevel = null, bool? RequirePaymentMethod = null, string Id = null, string PackId = null, TypEnum? Typ = null, int? UiOrder = null, string Family = null, bool? UiVisible = null, bool? Withfamily = null, VariableCostWhenPayEnum? VariableCostWhenPay = null, bool? OneTimePlan = null)
        {
            this.VariableCost = VariableCost;
            this.Name = Name;
            this.OneTimePay = OneTimePay;
            this.HasVariableCost = HasVariableCost;
            this.Description = Description;
            this.Subscription = Subscription;
            this.BeforePlanId = BeforePlanId;
            this.OnExpiratyNextPlanId = OnExpiratyNextPlanId;
            this.UpgradeLevel = UpgradeLevel;
            this.RequirePaymentMethod = RequirePaymentMethod;
            this.Id = Id;
            this.PackId = PackId;
            this.Typ = Typ;
            this.UiOrder = UiOrder;
            this.Family = Family;
            this.UiVisible = UiVisible;
            this.Withfamily = Withfamily;
            this.VariableCostWhenPay = VariableCostWhenPay;
            this.OneTimePlan = OneTimePlan;
        }
        
        /// <summary>
        /// Gets or Sets VariableCost
        /// </summary>
        [DataMember(Name="variableCost", EmitDefaultValue=false)]
        public Dictionary<string, VariableCost> VariableCost { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets OneTimePay
        /// </summary>
        [DataMember(Name="oneTimePay", EmitDefaultValue=false)]
        public OneTimePay OneTimePay { get; set; }
        /// <summary>
        /// Gets or Sets HasVariableCost
        /// </summary>
        [DataMember(Name="hasVariableCost", EmitDefaultValue=false)]
        public bool? HasVariableCost { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subscription Subscription { get; set; }
        /// <summary>
        /// Gets or Sets BeforePlanId
        /// </summary>
        [DataMember(Name="beforePlanId", EmitDefaultValue=false)]
        public string BeforePlanId { get; set; }
        /// <summary>
        /// Gets or Sets OnExpiratyNextPlanId
        /// </summary>
        [DataMember(Name="onExpiratyNextPlanId", EmitDefaultValue=false)]
        public string OnExpiratyNextPlanId { get; set; }
        /// <summary>
        /// Gets or Sets UpgradeLevel
        /// </summary>
        [DataMember(Name="upgradeLevel", EmitDefaultValue=false)]
        public int? UpgradeLevel { get; set; }
        /// <summary>
        /// Gets or Sets RequirePaymentMethod
        /// </summary>
        [DataMember(Name="requirePaymentMethod", EmitDefaultValue=false)]
        public bool? RequirePaymentMethod { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets PackId
        /// </summary>
        [DataMember(Name="packId", EmitDefaultValue=false)]
        public string PackId { get; set; }
        /// <summary>
        /// Gets or Sets UiOrder
        /// </summary>
        [DataMember(Name="uiOrder", EmitDefaultValue=false)]
        public int? UiOrder { get; set; }
        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public string Family { get; set; }
        /// <summary>
        /// Gets or Sets UiVisible
        /// </summary>
        [DataMember(Name="uiVisible", EmitDefaultValue=false)]
        public bool? UiVisible { get; set; }
        /// <summary>
        /// Gets or Sets Withfamily
        /// </summary>
        [DataMember(Name="withfamily", EmitDefaultValue=false)]
        public bool? Withfamily { get; set; }
        /// <summary>
        /// Gets or Sets OneTimePlan
        /// </summary>
        [DataMember(Name="oneTimePlan", EmitDefaultValue=false)]
        public bool? OneTimePlan { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Plan {\n");
            sb.Append("  VariableCost: ").Append(VariableCost).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OneTimePay: ").Append(OneTimePay).Append("\n");
            sb.Append("  HasVariableCost: ").Append(HasVariableCost).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  BeforePlanId: ").Append(BeforePlanId).Append("\n");
            sb.Append("  OnExpiratyNextPlanId: ").Append(OnExpiratyNextPlanId).Append("\n");
            sb.Append("  UpgradeLevel: ").Append(UpgradeLevel).Append("\n");
            sb.Append("  RequirePaymentMethod: ").Append(RequirePaymentMethod).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PackId: ").Append(PackId).Append("\n");
            sb.Append("  Typ: ").Append(Typ).Append("\n");
            sb.Append("  UiOrder: ").Append(UiOrder).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  UiVisible: ").Append(UiVisible).Append("\n");
            sb.Append("  Withfamily: ").Append(Withfamily).Append("\n");
            sb.Append("  VariableCostWhenPay: ").Append(VariableCostWhenPay).Append("\n");
            sb.Append("  OneTimePlan: ").Append(OneTimePlan).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Plan);
        }

        /// <summary>
        /// Returns true if Plan instances are equal
        /// </summary>
        /// <param name="other">Instance of Plan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VariableCost == other.VariableCost ||
                    this.VariableCost != null &&
                    this.VariableCost.SequenceEqual(other.VariableCost)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OneTimePay == other.OneTimePay ||
                    this.OneTimePay != null &&
                    this.OneTimePay.Equals(other.OneTimePay)
                ) && 
                (
                    this.HasVariableCost == other.HasVariableCost ||
                    this.HasVariableCost != null &&
                    this.HasVariableCost.Equals(other.HasVariableCost)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.BeforePlanId == other.BeforePlanId ||
                    this.BeforePlanId != null &&
                    this.BeforePlanId.Equals(other.BeforePlanId)
                ) && 
                (
                    this.OnExpiratyNextPlanId == other.OnExpiratyNextPlanId ||
                    this.OnExpiratyNextPlanId != null &&
                    this.OnExpiratyNextPlanId.Equals(other.OnExpiratyNextPlanId)
                ) && 
                (
                    this.UpgradeLevel == other.UpgradeLevel ||
                    this.UpgradeLevel != null &&
                    this.UpgradeLevel.Equals(other.UpgradeLevel)
                ) && 
                (
                    this.RequirePaymentMethod == other.RequirePaymentMethod ||
                    this.RequirePaymentMethod != null &&
                    this.RequirePaymentMethod.Equals(other.RequirePaymentMethod)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PackId == other.PackId ||
                    this.PackId != null &&
                    this.PackId.Equals(other.PackId)
                ) && 
                (
                    this.Typ == other.Typ ||
                    this.Typ != null &&
                    this.Typ.Equals(other.Typ)
                ) && 
                (
                    this.UiOrder == other.UiOrder ||
                    this.UiOrder != null &&
                    this.UiOrder.Equals(other.UiOrder)
                ) && 
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
                ) && 
                (
                    this.UiVisible == other.UiVisible ||
                    this.UiVisible != null &&
                    this.UiVisible.Equals(other.UiVisible)
                ) && 
                (
                    this.Withfamily == other.Withfamily ||
                    this.Withfamily != null &&
                    this.Withfamily.Equals(other.Withfamily)
                ) && 
                (
                    this.VariableCostWhenPay == other.VariableCostWhenPay ||
                    this.VariableCostWhenPay != null &&
                    this.VariableCostWhenPay.Equals(other.VariableCostWhenPay)
                ) && 
                (
                    this.OneTimePlan == other.OneTimePlan ||
                    this.OneTimePlan != null &&
                    this.OneTimePlan.Equals(other.OneTimePlan)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.VariableCost != null)
                    hash = hash * 59 + this.VariableCost.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OneTimePay != null)
                    hash = hash * 59 + this.OneTimePay.GetHashCode();
                if (this.HasVariableCost != null)
                    hash = hash * 59 + this.HasVariableCost.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.BeforePlanId != null)
                    hash = hash * 59 + this.BeforePlanId.GetHashCode();
                if (this.OnExpiratyNextPlanId != null)
                    hash = hash * 59 + this.OnExpiratyNextPlanId.GetHashCode();
                if (this.UpgradeLevel != null)
                    hash = hash * 59 + this.UpgradeLevel.GetHashCode();
                if (this.RequirePaymentMethod != null)
                    hash = hash * 59 + this.RequirePaymentMethod.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PackId != null)
                    hash = hash * 59 + this.PackId.GetHashCode();
                if (this.Typ != null)
                    hash = hash * 59 + this.Typ.GetHashCode();
                if (this.UiOrder != null)
                    hash = hash * 59 + this.UiOrder.GetHashCode();
                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();
                if (this.UiVisible != null)
                    hash = hash * 59 + this.UiVisible.GetHashCode();
                if (this.Withfamily != null)
                    hash = hash * 59 + this.Withfamily.GetHashCode();
                if (this.VariableCostWhenPay != null)
                    hash = hash * 59 + this.VariableCostWhenPay.GetHashCode();
                if (this.OneTimePlan != null)
                    hash = hash * 59 + this.OneTimePlan.GetHashCode();
                return hash;
            }
        }
    }

}
