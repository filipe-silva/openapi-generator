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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ArrayOfNumberOnly
    /// </summary>
    [DataContract(Name = "ArrayOfNumberOnly")]
    public partial class ArrayOfNumberOnly : IEquatable<ArrayOfNumberOnly>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayOfNumberOnly" /> class.
        /// </summary>
        /// <param name="arrayNumber">arrayNumber.</param>
        public ArrayOfNumberOnly(List<decimal> arrayNumber = default(List<decimal>))
        {
            ArrayNumber = arrayNumber;
        }

        /// <summary>
        /// Gets or Sets ArrayNumber
        /// </summary>
        [DataMember(Name = "ArrayNumber", EmitDefaultValue = false)]
        public List<decimal> ArrayNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArrayOfNumberOnly {\n");
            sb.Append("  ArrayNumber: ").Append(ArrayNumber).Append("\n");
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
            return Equals(input as ArrayOfNumberOnly);
        }

        /// <summary>
        /// Returns true if ArrayOfNumberOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayOfNumberOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayOfNumberOnly input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    ArrayNumber == input.ArrayNumber ||
                    ArrayNumber != null &&
                    input.ArrayNumber != null &&
                    ArrayNumber.SequenceEqual(input.ArrayNumber)
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
				if (ArrayNumber != null)
                {
                    hashCode = (hashCode * 59) + ArrayNumber.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
