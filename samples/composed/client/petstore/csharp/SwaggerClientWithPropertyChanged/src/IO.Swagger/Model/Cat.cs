/* 
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Cat
    /// </summary>
    [DataContract]
        public partial class Cat : Pet,  IEquatable<Cat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat" /> class.
        /// </summary>
        /// <param name="hunts">hunts.</param>
        /// <param name="age">age.</param>
        public Cat(bool? hunts = default(bool?), int? age = default(int?), bool? hunts = default(bool?), int? age = default(int?), long? id = default(long?), string name = default(string), StatusEnum? status = default(StatusEnum?), List<PetPart> part = default(List<PetPart>)) : base(id, name, status, part)
        {
            this.Hunts = hunts;
            this.Age = age;
        }
        
        /// <summary>
        /// Gets or Sets Hunts
        /// </summary>
        [DataMember(Name="hunts", EmitDefaultValue=false)]
        public bool? Hunts { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public int? Age { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cat {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Hunts: ").Append(Hunts).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Cat);
        }

        /// <summary>
        /// Returns true if Cat instances are equal
        /// </summary>
        /// <param name="input">Instance of Cat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cat input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Hunts == input.Hunts ||
                    (this.Hunts != null &&
                    this.Hunts.Equals(input.Hunts))
                ) && base.Equals(input) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
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
                int hashCode = base.GetHashCode();
                if (this.Hunts != null)
                    hashCode = hashCode * 59 + this.Hunts.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
