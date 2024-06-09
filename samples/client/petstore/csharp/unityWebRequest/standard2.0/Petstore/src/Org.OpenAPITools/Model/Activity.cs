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
    /// test map of maps
    /// </summary>
    [DataContract(Name = "Activity")]
    public partial class Activity : IEquatable<Activity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="activityOutputs">activityOutputs.</param>
        public Activity(Dictionary<string, List<ActivityOutputElementRepresentation>> activityOutputs = default(Dictionary<string, List<ActivityOutputElementRepresentation>>))
        {
            ActivityOutputs = activityOutputs;
        }

        /// <summary>
        /// Gets or Sets ActivityOutputs
        /// </summary>
        [DataMember(Name = "activity_outputs", EmitDefaultValue = false)]
        public Dictionary<string, List<ActivityOutputElementRepresentation>> ActivityOutputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  ActivityOutputs: ").Append(ActivityOutputs).Append("\n");
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
            return Equals(input as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    ActivityOutputs == input.ActivityOutputs ||
                    ActivityOutputs != null &&
                    input.ActivityOutputs != null &&
                    ActivityOutputs.SequenceEqual(input.ActivityOutputs)
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
				if (ActivityOutputs != null)
                {
                    hashCode = (hashCode * 59) + ActivityOutputs.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
