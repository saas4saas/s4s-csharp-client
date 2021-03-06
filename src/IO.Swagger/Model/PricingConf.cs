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
    public partial class PricingConf :  IEquatable<PricingConf>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingConf" /> class.
        /// </summary>
        /// <param name="Currencies">Currencies.</param>
        /// <param name="DefaultCurrency">DefaultCurrency.</param>
        /// <param name="Plans">Plans.</param>
        /// <param name="Policy">Policy.</param>
        public PricingConf(List<string> Currencies = null, string DefaultCurrency = null, Dictionary<string, Plan> Plans = null, PricingPolicy Policy = null)
        {
            this.Currencies = Currencies;
            this.DefaultCurrency = DefaultCurrency;
            this.Plans = Plans;
            this.Policy = Policy;
        }
        
        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<string> Currencies { get; set; }
        /// <summary>
        /// Gets or Sets DefaultCurrency
        /// </summary>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; set; }
        /// <summary>
        /// Gets or Sets Plans
        /// </summary>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public Dictionary<string, Plan> Plans { get; set; }
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public PricingPolicy Policy { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingConf {\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(obj as PricingConf);
        }

        /// <summary>
        /// Returns true if PricingConf instances are equal
        /// </summary>
        /// <param name="other">Instance of PricingConf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingConf other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Currencies == other.Currencies ||
                    this.Currencies != null &&
                    this.Currencies.SequenceEqual(other.Currencies)
                ) && 
                (
                    this.DefaultCurrency == other.DefaultCurrency ||
                    this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(other.DefaultCurrency)
                ) && 
                (
                    this.Plans == other.Plans ||
                    this.Plans != null &&
                    this.Plans.SequenceEqual(other.Plans)
                ) && 
                (
                    this.Policy == other.Policy ||
                    this.Policy != null &&
                    this.Policy.Equals(other.Policy)
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
                if (this.Currencies != null)
                    hash = hash * 59 + this.Currencies.GetHashCode();
                if (this.DefaultCurrency != null)
                    hash = hash * 59 + this.DefaultCurrency.GetHashCode();
                if (this.Plans != null)
                    hash = hash * 59 + this.Plans.GetHashCode();
                if (this.Policy != null)
                    hash = hash * 59 + this.Policy.GetHashCode();
                return hash;
            }
        }
    }

}
