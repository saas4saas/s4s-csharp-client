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
    public partial class ResourcePatch :  IEquatable<ResourcePatch>
    {
        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpEnum
        {
            
            /// <summary>
            /// Enum Dec for "Dec"
            /// </summary>
            [EnumMember(Value = "Dec")]
            Dec,
            
            /// <summary>
            /// Enum Inc for "Inc"
            /// </summary>
            [EnumMember(Value = "Inc")]
            Inc,
            
            /// <summary>
            /// Enum Nothing for "Nothing"
            /// </summary>
            [EnumMember(Value = "Nothing")]
            Nothing
        }

        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public OpEnum? Op { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePatch" /> class.
        /// </summary>
        /// <param name="Op">Op.</param>
        /// <param name="Value">Value.</param>
        /// <param name="PatchWhatIsPossible">PatchWhatIsPossible.</param>
        public ResourcePatch(OpEnum? Op = null, long? Value = null, bool? PatchWhatIsPossible = null)
        {
            this.Op = Op;
            this.Value = Value;
            this.PatchWhatIsPossible = PatchWhatIsPossible;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }
        /// <summary>
        /// Gets or Sets PatchWhatIsPossible
        /// </summary>
        [DataMember(Name="patchWhatIsPossible", EmitDefaultValue=false)]
        public bool? PatchWhatIsPossible { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcePatch {\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PatchWhatIsPossible: ").Append(PatchWhatIsPossible).Append("\n");
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
            return this.Equals(obj as ResourcePatch);
        }

        /// <summary>
        /// Returns true if ResourcePatch instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourcePatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcePatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Op == other.Op ||
                    this.Op != null &&
                    this.Op.Equals(other.Op)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.PatchWhatIsPossible == other.PatchWhatIsPossible ||
                    this.PatchWhatIsPossible != null &&
                    this.PatchWhatIsPossible.Equals(other.PatchWhatIsPossible)
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
                if (this.Op != null)
                    hash = hash * 59 + this.Op.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.PatchWhatIsPossible != null)
                    hash = hash * 59 + this.PatchWhatIsPossible.GetHashCode();
                return hash;
            }
        }
    }

}
