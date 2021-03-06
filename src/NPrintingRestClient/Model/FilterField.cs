/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Qlik.NPrinting.Rest.Client.Model
{
    /// <summary>
    /// FilterField
    /// </summary>
    [DataContract]
    public partial class FilterField :  IEquatable<FilterField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterField" /> class.
        /// </summary>
        /// <param name="ConnectionId">The unique identifier that represents a specific connection..</param>
        /// <param name="Name">The name of the filter field..</param>
        /// <param name="OverrideValues">Indicates whether the values of this filter field should override the values of the filter fields (with same name and connectionId) previously applied in the filter chain, if any..</param>
        /// <param name="Values">The values of the filter field. If overrideValues flag is set to false the array must not be empty..</param>
        public FilterField(Guid? ConnectionId = default(Guid?), string Name = default(string), bool? OverrideValues = default(bool?), List<FilterFieldValue> Values = default(List<FilterFieldValue>))
        {
            this.ConnectionId = ConnectionId;
            this.Name = Name;
            this.OverrideValues = OverrideValues;
            this.Values = Values;
        }
        
        /// <summary>
        /// The unique identifier that represents a specific connection.
        /// </summary>
        /// <value>The unique identifier that represents a specific connection.</value>
        [DataMember(Name="connectionId", EmitDefaultValue=false)]
        public Guid? ConnectionId { get; set; }
        /// <summary>
        /// The name of the filter field.
        /// </summary>
        /// <value>The name of the filter field.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether the values of this filter field should override the values of the filter fields (with same name and connectionId) previously applied in the filter chain, if any.
        /// </summary>
        /// <value>Indicates whether the values of this filter field should override the values of the filter fields (with same name and connectionId) previously applied in the filter chain, if any.</value>
        [DataMember(Name="overrideValues", EmitDefaultValue=false)]
        public bool? OverrideValues { get; set; }
        /// <summary>
        /// The values of the filter field. If overrideValues flag is set to false the array must not be empty.
        /// </summary>
        /// <value>The values of the filter field. If overrideValues flag is set to false the array must not be empty.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<FilterFieldValue> Values { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterField {\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OverrideValues: ").Append(OverrideValues).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FilterField);
        }

        /// <summary>
        /// Returns true if FilterField instances are equal
        /// </summary>
        /// <param name="other">Instance of FilterField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectionId == other.ConnectionId ||
                    this.ConnectionId != null &&
                    this.ConnectionId.Equals(other.ConnectionId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OverrideValues == other.OverrideValues ||
                    this.OverrideValues != null &&
                    this.OverrideValues.Equals(other.OverrideValues)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ConnectionId != null)
                    hash = hash * 59 + this.ConnectionId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OverrideValues != null)
                    hash = hash * 59 + this.OverrideValues.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
