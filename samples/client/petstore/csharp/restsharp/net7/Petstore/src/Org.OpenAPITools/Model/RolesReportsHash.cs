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
    /// Role report Hash
    /// </summary>
    [DataContract(Name = "RolesReportsHash")]
    public partial class RolesReportsHash : IEquatable<RolesReportsHash>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesReportsHash" /> class.
        /// </summary>
        /// <param name="roleUuid">roleUuid.</param>
        /// <param name="role">role.</param>
        public RolesReportsHash(Guid roleUuid = default(Guid), RolesReportsHashRole role = default(RolesReportsHashRole))
        {
            RoleUuid = roleUuid;
            Role = role;
        }

        /// <summary>
        /// Gets or Sets RoleUuid
        /// </summary>
        [DataMember(Name = "role_uuid", EmitDefaultValue = false)]
        public Guid RoleUuid { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public RolesReportsHashRole Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RolesReportsHash {\n");
            sb.Append("  RoleUuid: ").Append(RoleUuid).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as RolesReportsHash).AreEqual;
        }

        /// <summary>
        /// Returns true if RolesReportsHash instances are equal
        /// </summary>
        /// <param name="input">Instance of RolesReportsHash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RolesReportsHash input)
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
				hashCode = (hashCode * 59) + RoleUuid.GetHashCode();
				hashCode = (hashCode * 59) + Role.GetHashCode();
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
