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
    /// FormatTest
    /// </summary>
    [DataContract(Name = "format_test")]
    public partial class FormatTest : IEquatable<FormatTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormatTest()
        {
            AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="integer">integer.</param>
        /// <param name="int32">int32.</param>
        /// <param name="unsignedInteger">unsignedInteger.</param>
        /// <param name="int64">int64.</param>
        /// <param name="unsignedLong">unsignedLong.</param>
        /// <param name="number">number (required).</param>
        /// <param name="varFloat">varFloat.</param>
        /// <param name="varDouble">varDouble.</param>
        /// <param name="varDecimal">varDecimal.</param>
        /// <param name="varString">varString.</param>
        /// <param name="varByte">varByte (required).</param>
        /// <param name="binary">binary.</param>
        /// <param name="date">date (required).</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="password">password (required).</param>
        /// <param name="patternWithDigits">A string that is a 10 digit number. Can have leading zeros..</param>
        /// <param name="patternWithDigitsAndDelimiter">A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01..</param>
        /// <param name="patternWithBackslash">None.</param>
        public FormatTest(int integer = default(int), int int32 = default(int), uint unsignedInteger = default(uint), long int64 = default(long), ulong unsignedLong = default(ulong), decimal number = default(decimal), float varFloat = default(float), double varDouble = default(double), decimal varDecimal = default(decimal), string varString = default(string), byte[] varByte = default(byte[]), FileParameter binary = default(FileParameter), DateTime date = default(DateTime), DateTime dateTime = default(DateTime), Guid uuid = default(Guid), string password = default(string), string patternWithDigits = default(string), string patternWithDigitsAndDelimiter = default(string), string patternWithBackslash = default(string))
        {
            Number = number;
            // to ensure "varByte" is required (not null)
            if (varByte == null)
            {
                throw new ArgumentNullException("varByte is a required property for FormatTest and cannot be null");
            }
            Byte = varByte;
            Date = date;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for FormatTest and cannot be null");
            }
            Password = password;
            Integer = integer;
            Int32 = int32;
            UnsignedInteger = unsignedInteger;
            Int64 = int64;
            UnsignedLong = unsignedLong;
            Float = varFloat;
            Double = varDouble;
            Decimal = varDecimal;
            String = varString;
            Binary = binary;
            DateTime = dateTime;
            Uuid = uuid;
            PatternWithDigits = patternWithDigits;
            PatternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
            PatternWithBackslash = patternWithBackslash;
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [DataMember(Name = "integer", EmitDefaultValue = false)]
        public int Integer { get; set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [DataMember(Name = "int32", EmitDefaultValue = false)]
        public int Int32 { get; set; }

        /// <summary>
        /// Gets or Sets UnsignedInteger
        /// </summary>
        [DataMember(Name = "unsigned_integer", EmitDefaultValue = false)]
        public uint UnsignedInteger { get; set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [DataMember(Name = "int64", EmitDefaultValue = false)]
        public long Int64 { get; set; }

        /// <summary>
        /// Gets or Sets UnsignedLong
        /// </summary>
        [DataMember(Name = "unsigned_long", EmitDefaultValue = false)]
        public ulong UnsignedLong { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public decimal Number { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name = "float", EmitDefaultValue = false)]
        public float Float { get; set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name = "double", EmitDefaultValue = false)]
        public double Double { get; set; }

        /// <summary>
        /// Gets or Sets Decimal
        /// </summary>
        [DataMember(Name = "decimal", EmitDefaultValue = false)]
        public decimal Decimal { get; set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [DataMember(Name = "string", EmitDefaultValue = false)]
        public string String { get; set; }

        /// <summary>
        /// Gets or Sets Byte
        /// </summary>
        [DataMember(Name = "byte", IsRequired = true, EmitDefaultValue = true)]
        public byte[] Byte { get; set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name = "binary", EmitDefaultValue = false)]
        public FileParameter Binary { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /// <example>Sun Feb 02 00:00:00 UTC 2020</example>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        /// <example>2007-12-03T10:15:30+01:00</example>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        /// <example>72f98069-206d-4f12-9f12-3d1e525a8e84</example>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// A string that is a 10 digit number. Can have leading zeros.
        /// </summary>
        /// <value>A string that is a 10 digit number. Can have leading zeros.</value>
        [DataMember(Name = "pattern_with_digits", EmitDefaultValue = false)]
        public string PatternWithDigits { get; set; }

        /// <summary>
        /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
        /// </summary>
        /// <value>A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</value>
        [DataMember(Name = "pattern_with_digits_and_delimiter", EmitDefaultValue = false)]
        public string PatternWithDigitsAndDelimiter { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "pattern_with_backslash", EmitDefaultValue = false)]
        public string PatternWithBackslash { get; set; }

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
            sb.Append("class FormatTest {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  UnsignedInteger: ").Append(UnsignedInteger).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  UnsignedLong: ").Append(UnsignedLong).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Decimal: ").Append(Decimal).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Byte: ").Append(Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PatternWithDigits: ").Append(PatternWithDigits).Append("\n");
            sb.Append("  PatternWithDigitsAndDelimiter: ").Append(PatternWithDigitsAndDelimiter).Append("\n");
            sb.Append("  PatternWithBackslash: ").Append(PatternWithBackslash).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as FormatTest).AreEqual;
        }

        /// <summary>
        /// Returns true if FormatTest instances are equal
        /// </summary>
        /// <param name="input">Instance of FormatTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormatTest input)
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
                hashCode = (hashCode * 59) + Integer.GetHashCode();
                hashCode = (hashCode * 59) + Int32.GetHashCode();
                hashCode = (hashCode * 59) + UnsignedInteger.GetHashCode();
                hashCode = (hashCode * 59) + Int64.GetHashCode();
                hashCode = (hashCode * 59) + UnsignedLong.GetHashCode();
                hashCode = (hashCode * 59) + Number.GetHashCode();
                hashCode = (hashCode * 59) + Float.GetHashCode();
                hashCode = (hashCode * 59) + Double.GetHashCode();
                hashCode = (hashCode * 59) + Decimal.GetHashCode();
				hashCode = (hashCode * 59) + String.GetHashCode();
				hashCode = (hashCode * 59) + Byte.GetHashCode();
				hashCode = (hashCode * 59) + Binary.GetHashCode();
				hashCode = (hashCode * 59) + Date.GetHashCode();
				hashCode = (hashCode * 59) + DateTime.GetHashCode();
				hashCode = (hashCode * 59) + Uuid.GetHashCode();
				hashCode = (hashCode * 59) + Password.GetHashCode();
				hashCode = (hashCode * 59) + PatternWithDigits.GetHashCode();
				hashCode = (hashCode * 59) + PatternWithDigitsAndDelimiter.GetHashCode();
				hashCode = (hashCode * 59) + PatternWithBackslash.GetHashCode();
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
            // Integer (int) maximum
            if (this.Integer > (int)100)
            {
                yield return new ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if (this.Integer < (int)10)
            {
                yield return new ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            // Int32 (int) maximum
            if (this.Int32 > (int)200)
            {
                yield return new ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if (this.Int32 < (int)20)
            {
                yield return new ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // UnsignedInteger (uint) maximum
            if (this.UnsignedInteger > (uint)200)
            {
                yield return new ValidationResult("Invalid value for UnsignedInteger, must be a value less than or equal to 200.", new [] { "UnsignedInteger" });
            }

            // UnsignedInteger (uint) minimum
            if (this.UnsignedInteger < (uint)20)
            {
                yield return new ValidationResult("Invalid value for UnsignedInteger, must be a value greater than or equal to 20.", new [] { "UnsignedInteger" });
            }

            // Number (decimal) maximum
            if (this.Number > (decimal)543.2)
            {
                yield return new ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if (this.Number < (decimal)32.1)
            {
                yield return new ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // Float (float) maximum
            if (this.Float > (float)987.6)
            {
                yield return new ValidationResult("Invalid value for Float, must be a value less than or equal to 987.6.", new [] { "Float" });
            }

            // Float (float) minimum
            if (this.Float < (float)54.3)
            {
                yield return new ValidationResult("Invalid value for Float, must be a value greater than or equal to 54.3.", new [] { "Float" });
            }

            // Double (double) maximum
            if (this.Double > (double)123.4)
            {
                yield return new ValidationResult("Invalid value for Double, must be a value less than or equal to 123.4.", new [] { "Double" });
            }

            // Double (double) minimum
            if (this.Double < (double)67.8)
            {
                yield return new ValidationResult("Invalid value for Double, must be a value greater than or equal to 67.8.", new [] { "Double" });
            }

            if (this.String != null) {
                // String (string) pattern
                Regex regexString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
                if (!regexString.Match(this.String).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for String, must match a pattern of " + regexString, new [] { "String" });
                }
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 64)
            {
                yield return new ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 10)
            {
                yield return new ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            if (this.PatternWithDigits != null) {
                // PatternWithDigits (string) pattern
                Regex regexPatternWithDigits = new Regex(@"^\d{10}$", RegexOptions.CultureInvariant);
                if (!regexPatternWithDigits.Match(this.PatternWithDigits).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigits, must match a pattern of " + regexPatternWithDigits, new [] { "PatternWithDigits" });
                }
            }

            if (this.PatternWithDigitsAndDelimiter != null) {
                // PatternWithDigitsAndDelimiter (string) pattern
                Regex regexPatternWithDigitsAndDelimiter = new Regex(@"^image_\d{1,3}$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
                if (!regexPatternWithDigitsAndDelimiter.Match(this.PatternWithDigitsAndDelimiter).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigitsAndDelimiter, must match a pattern of " + regexPatternWithDigitsAndDelimiter, new [] { "PatternWithDigitsAndDelimiter" });
                }
            }

            if (this.PatternWithBackslash != null) {
                // PatternWithBackslash (string) pattern
                Regex regexPatternWithBackslash = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\/([0-9]|[1-2][0-9]|3[0-2]))$", RegexOptions.CultureInvariant);
                if (!regexPatternWithBackslash.Match(this.PatternWithBackslash).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithBackslash, must match a pattern of " + regexPatternWithBackslash, new [] { "PatternWithBackslash" });
                }
            }

            yield break;
        }
    }

}
