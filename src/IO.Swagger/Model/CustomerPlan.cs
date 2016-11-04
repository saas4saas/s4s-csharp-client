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
    public partial class CustomerPlan :  IEquatable<CustomerPlan>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum History for "History"
            /// </summary>
            [EnumMember(Value = "History")]
            History,
            
            /// <summary>
            /// Enum Enjoy for "Enjoy"
            /// </summary>
            [EnumMember(Value = "Enjoy")]
            Enjoy
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPlan" /> class.
        /// </summary>
        /// <param name="CurrentBillId">CurrentBillId.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="EndPeriodToPlanId">EndPeriodToPlanId.</param>
        /// <param name="SwapPlanId">SwapPlanId.</param>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PackId">PackId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="TotalInPayment">TotalInPayment.</param>
        /// <param name="PlanId">PlanId.</param>
        /// <param name="Family">Family.</param>
        /// <param name="OnExpirePlanId">OnExpirePlanId.</param>
        /// <param name="StartDate">StartDate.</param>
        public CustomerPlan(string CurrentBillId = null, long? EndDate = null, string EndPeriodToPlanId = null, string SwapPlanId = null, string CustomerId = null, string Id = null, string PackId = null, StatusEnum? Status = null, Dictionary<string, long?> TotalInPayment = null, string PlanId = null, string Family = null, string OnExpirePlanId = null, long? StartDate = null)
        {
            this.CurrentBillId = CurrentBillId;
            this.EndDate = EndDate;
            this.EndPeriodToPlanId = EndPeriodToPlanId;
            this.SwapPlanId = SwapPlanId;
            this.CustomerId = CustomerId;
            this.Id = Id;
            this.PackId = PackId;
            this.Status = Status;
            this.TotalInPayment = TotalInPayment;
            this.PlanId = PlanId;
            this.Family = Family;
            this.OnExpirePlanId = OnExpirePlanId;
            this.StartDate = StartDate;
        }
        
        /// <summary>
        /// Gets or Sets CurrentBillId
        /// </summary>
        [DataMember(Name="currentBillId", EmitDefaultValue=false)]
        public string CurrentBillId { get; set; }
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
        /// <summary>
        /// Gets or Sets EndPeriodToPlanId
        /// </summary>
        [DataMember(Name="endPeriodToPlanId", EmitDefaultValue=false)]
        public string EndPeriodToPlanId { get; set; }
        /// <summary>
        /// Gets or Sets SwapPlanId
        /// </summary>
        [DataMember(Name="swapPlanId", EmitDefaultValue=false)]
        public string SwapPlanId { get; set; }
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
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
        /// Gets or Sets TotalInPayment
        /// </summary>
        [DataMember(Name="totalInPayment", EmitDefaultValue=false)]
        public Dictionary<string, long?> TotalInPayment { get; set; }
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="planId", EmitDefaultValue=false)]
        public string PlanId { get; set; }
        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public string Family { get; set; }
        /// <summary>
        /// Gets or Sets OnExpirePlanId
        /// </summary>
        [DataMember(Name="onExpirePlanId", EmitDefaultValue=false)]
        public string OnExpirePlanId { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPlan {\n");
            sb.Append("  CurrentBillId: ").Append(CurrentBillId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndPeriodToPlanId: ").Append(EndPeriodToPlanId).Append("\n");
            sb.Append("  SwapPlanId: ").Append(SwapPlanId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PackId: ").Append(PackId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalInPayment: ").Append(TotalInPayment).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  OnExpirePlanId: ").Append(OnExpirePlanId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(obj as CustomerPlan);
        }

        /// <summary>
        /// Returns true if CustomerPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentBillId == other.CurrentBillId ||
                    this.CurrentBillId != null &&
                    this.CurrentBillId.Equals(other.CurrentBillId)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.EndPeriodToPlanId == other.EndPeriodToPlanId ||
                    this.EndPeriodToPlanId != null &&
                    this.EndPeriodToPlanId.Equals(other.EndPeriodToPlanId)
                ) && 
                (
                    this.SwapPlanId == other.SwapPlanId ||
                    this.SwapPlanId != null &&
                    this.SwapPlanId.Equals(other.SwapPlanId)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TotalInPayment == other.TotalInPayment ||
                    this.TotalInPayment != null &&
                    this.TotalInPayment.SequenceEqual(other.TotalInPayment)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
                ) && 
                (
                    this.OnExpirePlanId == other.OnExpirePlanId ||
                    this.OnExpirePlanId != null &&
                    this.OnExpirePlanId.Equals(other.OnExpirePlanId)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
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
                if (this.CurrentBillId != null)
                    hash = hash * 59 + this.CurrentBillId.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.EndPeriodToPlanId != null)
                    hash = hash * 59 + this.EndPeriodToPlanId.GetHashCode();
                if (this.SwapPlanId != null)
                    hash = hash * 59 + this.SwapPlanId.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PackId != null)
                    hash = hash * 59 + this.PackId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TotalInPayment != null)
                    hash = hash * 59 + this.TotalInPayment.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();
                if (this.OnExpirePlanId != null)
                    hash = hash * 59 + this.OnExpirePlanId.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                return hash;
            }
        }
    }

}
