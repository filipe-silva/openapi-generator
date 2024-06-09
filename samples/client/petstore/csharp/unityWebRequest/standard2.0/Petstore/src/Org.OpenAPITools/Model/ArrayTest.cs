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
    /// ArrayTest
    /// </summary>
    [DataContract(Name = "ArrayTest")]
    public partial class ArrayTest : IEquatable<ArrayTest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTest" /> class.
        /// </summary>
        /// <param name="arrayOfString">arrayOfString.</param>
        /// <param name="arrayArrayOfInteger">arrayArrayOfInteger.</param>
        /// <param name="arrayArrayOfModel">arrayArrayOfModel.</param>
        public ArrayTest(List<string> arrayOfString = default(List<string>), List<List<long>> arrayArrayOfInteger = default(List<List<long>>), List<List<ReadOnlyFirst>> arrayArrayOfModel = default(List<List<ReadOnlyFirst>>))
        {
            ArrayOfString = arrayOfString;
            ArrayArrayOfInteger = arrayArrayOfInteger;
            ArrayArrayOfModel = arrayArrayOfModel;
        }

        /// <summary>
        /// Gets or Sets ArrayOfString
        /// </summary>
        [DataMember(Name = "array_of_string", EmitDefaultValue = false)]
        public List<string> ArrayOfString { get; set; }

        /// <summary>
        /// Gets or Sets ArrayArrayOfInteger
        /// </summary>
        [DataMember(Name = "array_array_of_integer", EmitDefaultValue = false)]
        public List<List<long>> ArrayArrayOfInteger { get; set; }

        /// <summary>
        /// Gets or Sets ArrayArrayOfModel
        /// </summary>
        [DataMember(Name = "array_array_of_model", EmitDefaultValue = false)]
        public List<List<ReadOnlyFirst>> ArrayArrayOfModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArrayTest {\n");
            sb.Append("  ArrayOfString: ").Append(ArrayOfString).Append("\n");
            sb.Append("  ArrayArrayOfInteger: ").Append(ArrayArrayOfInteger).Append("\n");
            sb.Append("  ArrayArrayOfModel: ").Append(ArrayArrayOfModel).Append("\n");
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
            return Equals(input as ArrayTest);
        }

        /// <summary>
        /// Returns true if ArrayTest instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayTest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    ArrayOfString == input.ArrayOfString ||
                    ArrayOfString != null &&
                    input.ArrayOfString != null &&
                    ArrayOfString.SequenceEqual(input.ArrayOfString)
                ) && 
                (
                    ArrayArrayOfInteger == input.ArrayArrayOfInteger ||
                    ArrayArrayOfInteger != null &&
                    input.ArrayArrayOfInteger != null &&
                    ArrayArrayOfInteger.SequenceEqual(input.ArrayArrayOfInteger)
                ) && 
                (
                    ArrayArrayOfModel == input.ArrayArrayOfModel ||
                    ArrayArrayOfModel != null &&
                    input.ArrayArrayOfModel != null &&
                    ArrayArrayOfModel.SequenceEqual(input.ArrayArrayOfModel)
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
				if (ArrayOfString != null)
                {
                    hashCode = (hashCode * 59) + ArrayOfString.GetHashCode();
                }
				if (ArrayArrayOfInteger != null)
                {
                    hashCode = (hashCode * 59) + ArrayArrayOfInteger.GetHashCode();
                }
				if (ArrayArrayOfModel != null)
                {
                    hashCode = (hashCode * 59) + ArrayArrayOfModel.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
