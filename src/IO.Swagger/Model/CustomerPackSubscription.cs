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
    public partial class CustomerPackSubscription :  IEquatable<CustomerPackSubscription>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPackSubscription" /> class.
        /// </summary>
        /// <param name="ClosedTime">ClosedTime.</param>
        /// <param name="CurrentEnjoyId">CurrentEnjoyId.</param>
        /// <param name="State">State.</param>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PackId">PackId.</param>
        /// <param name="CreationTime">CreationTime.</param>
        public CustomerPackSubscription(long? ClosedTime = null, string CurrentEnjoyId = null, StateEnum? State = null, string CustomerId = null, string Id = null, string PackId = null, long? CreationTime = null)
        {
            this.ClosedTime = ClosedTime;
            this.CurrentEnjoyId = CurrentEnjoyId;
            this.State = State;
            this.CustomerId = CustomerId;
            this.Id = Id;
            this.PackId = PackId;
            this.CreationTime = CreationTime;
        }
        
        /// <summary>
        /// Gets or Sets ClosedTime
        /// </summary>
        [DataMember(Name="closedTime", EmitDefaultValue=false)]
        public long? ClosedTime { get; set; }
        /// <summary>
        /// Gets or Sets CurrentEnjoyId
        /// </summary>
        [DataMember(Name="currentEnjoyId", EmitDefaultValue=false)]
        public string CurrentEnjoyId { get; set; }
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
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPackSubscription {\n");
            sb.Append("  ClosedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  CurrentEnjoyId: ").Append(CurrentEnjoyId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PackId: ").Append(PackId).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
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
            return this.Equals(obj as CustomerPackSubscription);
        }

        /// <summary>
        /// Returns true if CustomerPackSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerPackSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPackSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClosedTime == other.ClosedTime ||
                    this.ClosedTime != null &&
                    this.ClosedTime.Equals(other.ClosedTime)
                ) && 
                (
                    this.CurrentEnjoyId == other.CurrentEnjoyId ||
                    this.CurrentEnjoyId != null &&
                    this.CurrentEnjoyId.Equals(other.CurrentEnjoyId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
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
                if (this.ClosedTime != null)
                    hash = hash * 59 + this.ClosedTime.GetHashCode();
                if (this.CurrentEnjoyId != null)
                    hash = hash * 59 + this.CurrentEnjoyId.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PackId != null)
                    hash = hash * 59 + this.PackId.GetHashCode();
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                return hash;
            }
        }
    }

}
