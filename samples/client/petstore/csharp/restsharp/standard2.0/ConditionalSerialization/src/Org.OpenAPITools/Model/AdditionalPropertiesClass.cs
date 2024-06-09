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
    /// AdditionalPropertiesClass
    /// </summary>
    [DataContract(Name = "AdditionalPropertiesClass")]
    public partial class AdditionalPropertiesClass : IEquatable<AdditionalPropertiesClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="mapProperty">mapProperty.</param>
        /// <param name="mapOfMapProperty">mapOfMapProperty.</param>
        /// <param name="anytype1">anytype1.</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype1">mapWithUndeclaredPropertiesAnytype1.</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype2">mapWithUndeclaredPropertiesAnytype2.</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype3">mapWithUndeclaredPropertiesAnytype3.</param>
        /// <param name="emptyMap">an object with no declared properties and no undeclared properties, hence it&#39;s an empty map..</param>
        /// <param name="mapWithUndeclaredPropertiesString">mapWithUndeclaredPropertiesString.</param>
        public AdditionalPropertiesClass(Dictionary<string, string> mapProperty = default(Dictionary<string, string>), Dictionary<string, Dictionary<string, string>> mapOfMapProperty = default(Dictionary<string, Dictionary<string, string>>), Object anytype1 = default(Object), Object mapWithUndeclaredPropertiesAnytype1 = default(Object), Object mapWithUndeclaredPropertiesAnytype2 = default(Object), Dictionary<string, Object> mapWithUndeclaredPropertiesAnytype3 = default(Dictionary<string, Object>), Object emptyMap = default(Object), Dictionary<string, string> mapWithUndeclaredPropertiesString = default(Dictionary<string, string>))
        {
            _MapProperty = mapProperty;
            if (MapProperty != null)
            {
                _flagMapProperty = true;
            }
            _MapOfMapProperty = mapOfMapProperty;
            if (MapOfMapProperty != null)
            {
                _flagMapOfMapProperty = true;
            }
            _Anytype1 = anytype1;
            if (Anytype1 != null)
            {
                _flagAnytype1 = true;
            }
            _MapWithUndeclaredPropertiesAnytype1 = mapWithUndeclaredPropertiesAnytype1;
            if (MapWithUndeclaredPropertiesAnytype1 != null)
            {
                _flagMapWithUndeclaredPropertiesAnytype1 = true;
            }
            _MapWithUndeclaredPropertiesAnytype2 = mapWithUndeclaredPropertiesAnytype2;
            if (MapWithUndeclaredPropertiesAnytype2 != null)
            {
                _flagMapWithUndeclaredPropertiesAnytype2 = true;
            }
            _MapWithUndeclaredPropertiesAnytype3 = mapWithUndeclaredPropertiesAnytype3;
            if (MapWithUndeclaredPropertiesAnytype3 != null)
            {
                _flagMapWithUndeclaredPropertiesAnytype3 = true;
            }
            _EmptyMap = emptyMap;
            if (EmptyMap != null)
            {
                _flagEmptyMap = true;
            }
            _MapWithUndeclaredPropertiesString = mapWithUndeclaredPropertiesString;
            if (MapWithUndeclaredPropertiesString != null)
            {
                _flagMapWithUndeclaredPropertiesString = true;
            }
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets MapProperty
        /// </summary>
        [DataMember(Name = "map_property", EmitDefaultValue = false)]
        public Dictionary<string, string> MapProperty
        {
            get{ return _MapProperty;}
            set
            {
                _MapProperty = value;
                _flagMapProperty = true;
            }
        }
        private Dictionary<string, string> _MapProperty;
        private bool _flagMapProperty;

        /// <summary>
        /// Returns false as MapProperty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapProperty()
        {
            return _flagMapProperty;
        }
        /// <summary>
        /// Gets or Sets MapOfMapProperty
        /// </summary>
        [DataMember(Name = "map_of_map_property", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, string>> MapOfMapProperty
        {
            get{ return _MapOfMapProperty;}
            set
            {
                _MapOfMapProperty = value;
                _flagMapOfMapProperty = true;
            }
        }
        private Dictionary<string, Dictionary<string, string>> _MapOfMapProperty;
        private bool _flagMapOfMapProperty;

        /// <summary>
        /// Returns false as MapOfMapProperty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapOfMapProperty()
        {
            return _flagMapOfMapProperty;
        }
        /// <summary>
        /// Gets or Sets Anytype1
        /// </summary>
        [DataMember(Name = "anytype_1", EmitDefaultValue = true)]
        public Object Anytype1
        {
            get{ return _Anytype1;}
            set
            {
                _Anytype1 = value;
                _flagAnytype1 = true;
            }
        }
        private Object _Anytype1;
        private bool _flagAnytype1;

        /// <summary>
        /// Returns false as Anytype1 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAnytype1()
        {
            return _flagAnytype1;
        }
        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype1
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_anytype_1", EmitDefaultValue = false)]
        public Object MapWithUndeclaredPropertiesAnytype1
        {
            get{ return _MapWithUndeclaredPropertiesAnytype1;}
            set
            {
                _MapWithUndeclaredPropertiesAnytype1 = value;
                _flagMapWithUndeclaredPropertiesAnytype1 = true;
            }
        }
        private Object _MapWithUndeclaredPropertiesAnytype1;
        private bool _flagMapWithUndeclaredPropertiesAnytype1;

        /// <summary>
        /// Returns false as MapWithUndeclaredPropertiesAnytype1 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapWithUndeclaredPropertiesAnytype1()
        {
            return _flagMapWithUndeclaredPropertiesAnytype1;
        }
        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype2
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_anytype_2", EmitDefaultValue = false)]
        public Object MapWithUndeclaredPropertiesAnytype2
        {
            get{ return _MapWithUndeclaredPropertiesAnytype2;}
            set
            {
                _MapWithUndeclaredPropertiesAnytype2 = value;
                _flagMapWithUndeclaredPropertiesAnytype2 = true;
            }
        }
        private Object _MapWithUndeclaredPropertiesAnytype2;
        private bool _flagMapWithUndeclaredPropertiesAnytype2;

        /// <summary>
        /// Returns false as MapWithUndeclaredPropertiesAnytype2 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapWithUndeclaredPropertiesAnytype2()
        {
            return _flagMapWithUndeclaredPropertiesAnytype2;
        }
        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype3
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_anytype_3", EmitDefaultValue = false)]
        public Dictionary<string, Object> MapWithUndeclaredPropertiesAnytype3
        {
            get{ return _MapWithUndeclaredPropertiesAnytype3;}
            set
            {
                _MapWithUndeclaredPropertiesAnytype3 = value;
                _flagMapWithUndeclaredPropertiesAnytype3 = true;
            }
        }
        private Dictionary<string, Object> _MapWithUndeclaredPropertiesAnytype3;
        private bool _flagMapWithUndeclaredPropertiesAnytype3;

        /// <summary>
        /// Returns false as MapWithUndeclaredPropertiesAnytype3 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapWithUndeclaredPropertiesAnytype3()
        {
            return _flagMapWithUndeclaredPropertiesAnytype3;
        }
        /// <summary>
        /// an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.
        /// </summary>
        /// <value>an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.</value>
        [DataMember(Name = "empty_map", EmitDefaultValue = false)]
        public Object EmptyMap
        {
            get{ return _EmptyMap;}
            set
            {
                _EmptyMap = value;
                _flagEmptyMap = true;
            }
        }
        private Object _EmptyMap;
        private bool _flagEmptyMap;

        /// <summary>
        /// Returns false as EmptyMap should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmptyMap()
        {
            return _flagEmptyMap;
        }
        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesString
        /// </summary>
        [DataMember(Name = "map_with_undeclared_properties_string", EmitDefaultValue = false)]
        public Dictionary<string, string> MapWithUndeclaredPropertiesString
        {
            get{ return _MapWithUndeclaredPropertiesString;}
            set
            {
                _MapWithUndeclaredPropertiesString = value;
                _flagMapWithUndeclaredPropertiesString = true;
            }
        }
        private Dictionary<string, string> _MapWithUndeclaredPropertiesString;
        private bool _flagMapWithUndeclaredPropertiesString;

        /// <summary>
        /// Returns false as MapWithUndeclaredPropertiesString should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapWithUndeclaredPropertiesString()
        {
            return _flagMapWithUndeclaredPropertiesString;
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
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  MapProperty: ").Append(MapProperty).Append("\n");
            sb.Append("  MapOfMapProperty: ").Append(MapOfMapProperty).Append("\n");
            sb.Append("  Anytype1: ").Append(Anytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype1: ").Append(MapWithUndeclaredPropertiesAnytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype2: ").Append(MapWithUndeclaredPropertiesAnytype2).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype3: ").Append(MapWithUndeclaredPropertiesAnytype3).Append("\n");
            sb.Append("  EmptyMap: ").Append(EmptyMap).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesString: ").Append(MapWithUndeclaredPropertiesString).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as AdditionalPropertiesClass).AreEqual;
        }

        /// <summary>
        /// Returns true if AdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalPropertiesClass input)
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
				if (MapProperty != null)
                {
                    hashCode = (hashCode * 59) + MapProperty.GetHashCode();
                }
				if (MapOfMapProperty != null)
                {
                    hashCode = (hashCode * 59) + MapOfMapProperty.GetHashCode();
                }
				if (Anytype1 != null)
                {
                    hashCode = (hashCode * 59) + Anytype1.GetHashCode();
                }
				if (MapWithUndeclaredPropertiesAnytype1 != null)
                {
                    hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesAnytype1.GetHashCode();
                }
				if (MapWithUndeclaredPropertiesAnytype2 != null)
                {
                    hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesAnytype2.GetHashCode();
                }
				if (MapWithUndeclaredPropertiesAnytype3 != null)
                {
                    hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesAnytype3.GetHashCode();
                }
				if (EmptyMap != null)
                {
                    hashCode = (hashCode * 59) + EmptyMap.GetHashCode();
                }
				if (MapWithUndeclaredPropertiesString != null)
                {
                    hashCode = (hashCode * 59) + MapWithUndeclaredPropertiesString.GetHashCode();
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
