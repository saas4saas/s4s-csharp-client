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
    public partial class Account :  IEquatable<Account>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum WaitingAprove for "WaitingAprove"
            /// </summary>
            [EnumMember(Value = "WaitingAprove")]
            WaitingAprove,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="PrivateData">PrivateData.</param>
        /// <param name="Data">Data.</param>
        /// <param name="DefaultUserId">DefaultUserId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="DefaultUser">DefaultUser.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Typ">Typ.</param>
        public Account(Dictionary<string, string> PrivateData = null, Dictionary<string, string> Data = null, string DefaultUserId = null, string Id = null, User DefaultUser = null, StatusEnum? Status = null, string Typ = null)
        {
            this.PrivateData = PrivateData;
            this.Data = Data;
            this.DefaultUserId = DefaultUserId;
            this.Id = Id;
            this.DefaultUser = DefaultUser;
            this.Status = Status;
            this.Typ = Typ;
        }
        
        /// <summary>
        /// Gets or Sets PrivateData
        /// </summary>
        [DataMember(Name="privateData", EmitDefaultValue=false)]
        public Dictionary<string, string> PrivateData { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, string> Data { get; set; }
        /// <summary>
        /// Gets or Sets DefaultUserId
        /// </summary>
        [DataMember(Name="defaultUserId", EmitDefaultValue=false)]
        public string DefaultUserId { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets DefaultUser
        /// </summary>
        [DataMember(Name="defaultUser", EmitDefaultValue=false)]
        public User DefaultUser { get; set; }
        /// <summary>
        /// Gets or Sets Typ
        /// </summary>
        [DataMember(Name="typ", EmitDefaultValue=false)]
        public string Typ { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  PrivateData: ").Append(PrivateData).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DefaultUserId: ").Append(DefaultUserId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DefaultUser: ").Append(DefaultUser).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Typ: ").Append(Typ).Append("\n");
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
            return this.Equals(obj as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="other">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PrivateData == other.PrivateData ||
                    this.PrivateData != null &&
                    this.PrivateData.SequenceEqual(other.PrivateData)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.DefaultUserId == other.DefaultUserId ||
                    this.DefaultUserId != null &&
                    this.DefaultUserId.Equals(other.DefaultUserId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.DefaultUser == other.DefaultUser ||
                    this.DefaultUser != null &&
                    this.DefaultUser.Equals(other.DefaultUser)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Typ == other.Typ ||
                    this.Typ != null &&
                    this.Typ.Equals(other.Typ)
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
                if (this.PrivateData != null)
                    hash = hash * 59 + this.PrivateData.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.DefaultUserId != null)
                    hash = hash * 59 + this.DefaultUserId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DefaultUser != null)
                    hash = hash * 59 + this.DefaultUser.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Typ != null)
                    hash = hash * 59 + this.Typ.GetHashCode();
                return hash;
            }
        }
    }

}
