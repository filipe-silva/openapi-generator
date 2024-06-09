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
    /// ActivityOutputElementRepresentation
    /// </summary>
    [DataContract(Name = "ActivityOutputElementRepresentation")]
    public partial class ActivityOutputElementRepresentation : IEquatable<ActivityOutputElementRepresentation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOutputElementRepresentation" /> class.
        /// </summary>
        /// <param name="prop1">prop1.</param>
        /// <param name="prop2">prop2.</param>
        public ActivityOutputElementRepresentation(string prop1 = default(string), Object prop2 = default(Object))
        {
            _Prop1 = prop1;
            if (Prop1 != null)
            {
                _flagProp1 = true;
            }
            _Prop2 = prop2;
            if (Prop2 != null)
            {
                _flagProp2 = true;
            }
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Prop1
        /// </summary>
        [DataMember(Name = "prop1", EmitDefaultValue = false)]
        public string Prop1
        {
            get{ return _Prop1;}
            set
            {
                _Prop1 = value;
                _flagProp1 = true;
            }
        }
        private string _Prop1;
        private bool _flagProp1;

        /// <summary>
        /// Returns false as Prop1 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProp1()
        {
            return _flagProp1;
        }
        /// <summary>
        /// Gets or Sets Prop2
        /// </summary>
        [DataMember(Name = "prop2", EmitDefaultValue = false)]
        public Object Prop2
        {
            get{ return _Prop2;}
            set
            {
                _Prop2 = value;
                _flagProp2 = true;
            }
        }
        private Object _Prop2;
        private bool _flagProp2;

        /// <summary>
        /// Returns false as Prop2 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProp2()
        {
            return _flagProp2;
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
            sb.Append("class ActivityOutputElementRepresentation {\n");
            sb.Append("  Prop1: ").Append(Prop1).Append("\n");
            sb.Append("  Prop2: ").Append(Prop2).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as ActivityOutputElementRepresentation).AreEqual;
        }

        /// <summary>
        /// Returns true if ActivityOutputElementRepresentation instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityOutputElementRepresentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOutputElementRepresentation input)
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
				hashCode = (hashCode * 59) + Prop1.GetHashCode();
				hashCode = (hashCode * 59) + Prop2.GetHashCode();
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
