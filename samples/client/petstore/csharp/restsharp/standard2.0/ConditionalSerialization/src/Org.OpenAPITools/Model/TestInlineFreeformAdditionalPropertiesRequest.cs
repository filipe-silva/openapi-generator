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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TestInlineFreeformAdditionalPropertiesRequest
    /// </summary>
    [DataContract(Name = "testInlineFreeformAdditionalProperties_request")]
    public partial class TestInlineFreeformAdditionalPropertiesRequest : IEquatable<TestInlineFreeformAdditionalPropertiesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestInlineFreeformAdditionalPropertiesRequest" /> class.
        /// </summary>
        /// <param name="someProperty">someProperty.</param>
        public TestInlineFreeformAdditionalPropertiesRequest(string someProperty = default(string))
        {
            _SomeProperty = someProperty;
            if (SomeProperty != null)
            {
                _flagSomeProperty = true;
            }
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets SomeProperty
        /// </summary>
        [DataMember(Name = "someProperty", EmitDefaultValue = false)]
        public string SomeProperty
        {
            get{ return _SomeProperty;}
            set
            {
                _SomeProperty = value;
                _flagSomeProperty = true;
            }
        }
        private string _SomeProperty;
        private bool _flagSomeProperty;

        /// <summary>
        /// Returns false as SomeProperty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSomeProperty()
        {
            return _flagSomeProperty;
        }
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
            sb.Append("class TestInlineFreeformAdditionalPropertiesRequest {\n");
            sb.Append("  SomeProperty: ").Append(SomeProperty).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as TestInlineFreeformAdditionalPropertiesRequest).AreEqual;
        }

        /// <summary>
        /// Returns true if TestInlineFreeformAdditionalPropertiesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TestInlineFreeformAdditionalPropertiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestInlineFreeformAdditionalPropertiesRequest input)
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
				if (SomeProperty != null)
                {
                    hashCode = (hashCode * 59) + SomeProperty.GetHashCode();
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
