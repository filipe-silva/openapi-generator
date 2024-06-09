/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Org.OpenAPITools.Client.FileParameter;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EnumArrays
    /// </summary>
    [DataContract(Name = "EnumArrays")]
    public partial class EnumArrays : IEquatable<EnumArrays>, IValidatableObject
    {
        /// <summary>
        /// Defines JustSymbol
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustSymbolEnum
        {
            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: &gt;&#x3D;
            /// </summary>
            [EnumMember(Value = ">=")]
            GreaterThanOrEqualTo = 1,

            /// <summary>
            /// Enum Dollar for value: $
            /// </summary>
            [EnumMember(Value = "$")]
            Dollar = 2
        }


        /// <summary>
        /// Gets or Sets JustSymbol
        /// </summary>
        [DataMember(Name = "just_symbol", EmitDefaultValue = false)]
        public JustSymbolEnum? JustSymbol { get; set; }
        /// <summary>
        /// Defines ArrayEnum
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ArrayEnumEnum
        {
            /// <summary>
            /// Enum Fish for value: fish
            /// </summary>
            [EnumMember(Value = "fish")]
            Fish = 1,

            /// <summary>
            /// Enum Crab for value: crab
            /// </summary>
            [EnumMember(Value = "crab")]
            Crab = 2
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumArrays" /> class.
        /// </summary>
        /// <param name="justSymbol">justSymbol.</param>
        /// <param name="arrayEnum">arrayEnum.</param>
        public EnumArrays(JustSymbolEnum? justSymbol = default(JustSymbolEnum?), List<ArrayEnumEnum> arrayEnum = default(List<ArrayEnumEnum>))
        {
            JustSymbol = justSymbol;
            ArrayEnum = arrayEnum;
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets ArrayEnum
        /// </summary>
        [DataMember(Name = "array_enum", EmitDefaultValue = false)]
        public List<EnumArrays.ArrayEnumEnum> ArrayEnum { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnumArrays {\n");
            sb.Append("  JustSymbol: ").Append(JustSymbol).Append("\n");
            sb.Append("  ArrayEnum: ").Append(ArrayEnum).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as EnumArrays).AreEqual;
        }

        /// <summary>
        /// Returns true if EnumArrays instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumArrays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumArrays input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = (hashCode * 59) + JustSymbol.GetHashCode();
				if (ArrayEnum != null)
                {
                    hashCode = (hashCode * 59) + ArrayEnum.GetHashCode();
                }
                if (AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
